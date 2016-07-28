using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using RabbitMQ.Client.Exceptions;
using RabbitMQ.Client.Framing;
using Tangent.CeviriDukkani.Logging;

namespace Tangent.CeviriDukkani.Messaging.Consumer {
    public class ConsumerTask {

        private readonly IConnection _connection;
        private readonly Delegate _handler;
        private readonly string _exchangeName;
        private readonly string _queueName;
        private readonly string _routingKey;
        private readonly Type _eventType;
        private bool _isClosed;
        private CustomQueueingBasicConsumer _consumer;
        private readonly ILog _logger = CustomLogger.Logger;

        private readonly string _errorQueueName;

        public ConsumerTask(IConnection connection, KeyValuePair<string, HandlerInfo> handlerEntry, string exchangeName) {
            this._connection = connection;
            _handler = handlerEntry.Value.Handler;
            this._exchangeName = exchangeName;
            _queueName = handlerEntry.Key;
            _routingKey = handlerEntry.Value.EventType.FullName;
            _eventType = handlerEntry.Value.EventType;
            _errorQueueName = _queueName +"Error";
        }

        public void Start() {
            Task.Factory.StartNew(() => {
                try {
                    var subscriptionClosed = false;
                    while (!subscriptionClosed) {
                        try {
                            using (var channel = _connection.CreateModel()) {
                                ConfigureConsumer(channel);
                                subscriptionClosed = TryToConsumeQueue(channel);
                            }
                        } catch (AlreadyClosedException exception) {
                            _logger.WarnFormat("RabbitMQ connection was lost", exception);
                            Thread.Sleep(1000);
                        }
                    }
                } catch (Exception exception) {
                    _logger.Error(exception);
                }
            }, TaskCreationOptions.LongRunning);
        }

        public void StopSubscription() {
            _isClosed = true;
        }

        private bool TryToConsumeQueue(IModel channel) {
            while (!_isClosed) {
                BasicDeliverEventArgs deliverEventArgs = null;
                try {
                    if (_consumer.Queue.Dequeue(500, out deliverEventArgs)) {
                        ProcessEvent(channel, deliverEventArgs);
                    }
                } catch (EndOfStreamException) {
                    Thread.Sleep(0);
                    return _isClosed;
                } catch (Exception e) {
                    if (deliverEventArgs == null) {
                        _logger.Error(e);
                        Console.WriteLine(e);
                    } else {
                        _logger.ErrorFormat("Cannot consume event type {0}, exception message: {1}, deliverEventArgs: {2}", e, _eventType, e.Message, deliverEventArgs);

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
            return _isClosed;
        }

        private void ProcessEvent(IModel channel, BasicDeliverEventArgs deliverEventArgs) {
            var body = Encoding.UTF8.GetString(deliverEventArgs.Body);
            var eventMessageConsumed = EventMessageExtensions.FromJson(body);
            var eventConsumed = EventExtensions.FromJson(eventMessageConsumed, _eventType);

            _logger.DebugFormat("RabbitMQ is sending the event: {0}", eventConsumed.ToJson());

            if (channel.IsOpen) {
                _handler.DynamicInvoke(eventConsumed);
                channel.BasicAck(deliverEventArgs.DeliveryTag, false);
            }
        }

        private void ConfigureConsumer(IModel channel) {
            var errorRoutingKey = _errorQueueName;

            channel.ExchangeDeclare(_exchangeName, ExchangeType.Topic, true);
            channel.QueueDeclare(_queueName, true, false, false, null);
            channel.QueueDeclare(_errorQueueName, true, false, false, null);
            channel.BasicQos(0, 50, false);

            _logger.InfoFormat("QUEUE created or checked {0}", _queueName);

            channel.QueueBind(_queueName, _exchangeName, _routingKey, null);
            channel.QueueBind(_errorQueueName, _exchangeName, errorRoutingKey, null);

            _consumer = new CustomQueueingBasicConsumer(channel);
            channel.BasicConsume(_queueName, false, _consumer);
        }

        private void PublishToErrorQueue(IModel channel, BasicDeliverEventArgs deliverEventArgs) {
            var errorRoutingKey = _errorQueueName;

            var basicProperties = channel.CreateBasicProperties();
            basicProperties.Persistent = true;

            channel.BasicPublish(_exchangeName, errorRoutingKey, basicProperties, deliverEventArgs.Body);
        }
    }

}