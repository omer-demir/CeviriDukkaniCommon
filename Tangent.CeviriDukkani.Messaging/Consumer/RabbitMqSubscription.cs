using System;
using System.Collections.Generic;
using RabbitMQ.Client;
using Tangent.CeviriDukkani.Domain.Common;

namespace Tangent.CeviriDukkani.Messaging.Consumer {
    public class RabbitMqSubscription : IConsumer {
        private string _appName;
        private readonly string _exchangeName;
        private readonly Dictionary<string, HandlerInfo> _handlerMap = new Dictionary<string, HandlerInfo>();
        private readonly List<ConsumerTask> _consumerTaskList = new List<ConsumerTask>();
        private readonly IConnection _rabbitConnection;

        public RabbitMqSubscription(IConnection rabbitConnection, string exchangeName) {
            this._exchangeName = exchangeName;
            this._rabbitConnection = rabbitConnection;
        }

        public IConsumer WithAppName(string value) {
            _appName = value;
            return this;
        }

        public IConsumer WithEvent<TEvent>(Action<TEvent> handler) where TEvent : class, IEvent {
            var eventType = typeof(TEvent);

            var queueName = string.Format("{0}.{1}", _appName, eventType.FullName);
            var handlerInfo = new HandlerInfo(handler, eventType);
            _handlerMap.Add(queueName, handlerInfo);
            return this;
        }

        public IConsumer Subscribe() {
            foreach (var handlerEntry in _handlerMap) {
                var consumerTask = new ConsumerTask(_rabbitConnection, handlerEntry, _exchangeName);
                _consumerTaskList.Add(consumerTask);
                consumerTask.Start();
            }

            return this;
        }

        public void StopSubscriptionTasks() {
            _consumerTaskList.ForEach(task => task.StopSubscription());
        }
    }
}