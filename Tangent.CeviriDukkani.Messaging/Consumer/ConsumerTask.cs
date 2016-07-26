using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using RabbitMQ.Client.Exceptions;
using RabbitMQ.Client.Framing;

namespace Tangent.CeviriDukkani.Messaging.Consumer {
    public class ConsumerTask {

        private readonly IConnection connection;
        private readonly Delegate handler;
        private readonly string exchangeName;
        private readonly string queueName;
        private readonly string routingKey;
        private readonly Type eventType;
        private bool isClosed;
        private CustomQueueingBasicConsumer consumer;

        private readonly string errorQueueName;

        public ConsumerTask(IConnection connection, KeyValuePair<string, HandlerInfo> handlerEntry, string exchangeName) {
            this.connection = connection;
            handler = handlerEntry.Value.Handler;
            this.exchangeName = exchangeName;
            queueName = handlerEntry.Key;
            routingKey = handlerEntry.Value.EventType.FullName;
            eventType = handlerEntry.Value.EventType;
            errorQueueName = queueName +"Error";
        }

        public void Start() {
            Task.Factory.StartNew(() => {
                try {
                    var subscriptionClosed = false;
                    while (!subscriptionClosed) {
                        try {
                            using (var channel = connection.CreateModel()) {
                                ConfigureConsumer(channel);
                                subscriptionClosed = TryToConsumeQueue(channel);
                            }
                        } catch (AlreadyClosedException exception) {
                            //logger.WarnFormat("RabbitMQ connection was lost", exception);
                            Thread.Sleep(1000);
                        }
                    }
                } catch (Exception exception) {
                    //logger.Error(exception);
                }
            }, TaskCreationOptions.LongRunning);
        }

        public void StopSubscription() {
            isClosed = true;
        }

        private bool TryToConsumeQueue(IModel channel) {
            while (!isClosed) {
                BasicDeliverEventArgs deliverEventArgs = null;
                try {
                    if (consumer.Queue.Dequeue(500, out deliverEventArgs)) {
                        ProcessEvent(channel, deliverEventArgs);
                    }
                } catch (EndOfStreamException) {
                    Thread.Sleep(0);
                    return isClosed;
                } catch (Exception e) {
                    if (deliverEventArgs == null) {
                        //logger.Error(e);
                        Console.WriteLine(e);
                    } else {
                        //logger.ErrorFormat("Cannot consume event type {0}, exception message: {1}, deliverEventArgs: {2}", e, eventType, e.Message, deliverEventArgs);

                        if (deliverEventArgs.Redelivered) {
                            PublishToErrorQueue(channel, deliverEventArgs);
                            if (channel.IsOpen) {
                                channel.BasicReject(deliverEventArgs.DeliveryTag, false);
                            }
                        } else {
                            if (channel.IsOpen) {
                                channel.BasicNack(deliverEventArgs.DeliveryTag, false, true);
                            }
                        }
                    }
                }
            }
            return isClosed;
        }

        private void ProcessEvent(IModel channel, BasicDeliverEventArgs deliverEventArgs) {
            var body = Encoding.UTF8.GetString(deliverEventArgs.Body);
            var eventMessageConsumed = EventMessageExtensions.FromJson(body);
            var eventConsumed = EventExtensions.FromJson(eventMessageConsumed, eventType);

            //logger.DebugFormat("RabbitMQ is sending the event: {0}", eventConsumed.ToJson());

            if (channel.IsOpen) {
                handler.DynamicInvoke(eventConsumed);
                channel.BasicAck(deliverEventArgs.DeliveryTag, false);
            }
        }

        private void ConfigureConsumer(IModel channel) {
            var errorRoutingKey = errorQueueName;

            channel.ExchangeDeclare(exchangeName, ExchangeType.Topic, true);
            channel.QueueDeclare(queueName, true, false, false, null);
            channel.QueueDeclare(errorQueueName, true, false, false, null);
            channel.BasicQos(0, 50, false);

            //logger.InfoFormat("QUEUE created or checked {0}", queueName);

            channel.QueueBind(queueName, exchangeName, routingKey, null);
            channel.QueueBind(errorQueueName, exchangeName, errorRoutingKey, null);

            consumer = new CustomQueueingBasicConsumer(channel);
            channel.BasicConsume(queueName, false, consumer);
        }

        private void PublishToErrorQueue(IModel channel, BasicDeliverEventArgs deliverEventArgs) {
            var errorRoutingKey = errorQueueName;

            var basicProperties = channel.CreateBasicProperties();
            basicProperties.Persistent = true;

            channel.BasicPublish(exchangeName, errorRoutingKey, basicProperties, deliverEventArgs.Body);
        }
    }

}