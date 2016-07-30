using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using log4net;
using MongoDB.Driver;
using Newtonsoft.Json;
using RabbitMQ.Client;

namespace Tangent.CeviriDukkani.Messaging.Producer {
    public class RabbitMqCommitDispatcher : IDispatchCommits {
        private readonly IConnection _connection;
        private readonly string _topicExchangeName;
        private readonly ILog _logger;

        public RabbitMqCommitDispatcher(IConnection connection, string topicExchangeName, ILog logger) {
            this._connection = connection;
            this._topicExchangeName = topicExchangeName;
            _logger = logger;
        }

        public void Dispose() {

        }

        public void Dispatch(ICollection<EventMessage> events) {
            PersistingEvents(events);

            using (var channel = _connection.CreateModel()) {
                channel.ExchangeDeclare(_topicExchangeName, ExchangeType.Topic, true);
                var basicProperties = channel.CreateBasicProperties();
                basicProperties.Persistent = true;

                _logger.Info("Publishing events...");
                foreach (var eventMessage in events) {
                    var routingKey = eventMessage.Headers["EventType"].ToString();
                    var payload = ConvertToMessageFormat(eventMessage);

                    channel.BasicPublish(_topicExchangeName, routingKey, basicProperties, payload);
                }
            }
        }

        private void PersistingEvents(ICollection<EventMessage> events) {
            _logger.Info("Persisting the events to event store");

            var mongoEventStore = ConfigurationManager.AppSettings["MongoEventStore"];
            var mongoEventDatabase = ConfigurationManager.AppSettings["MongoEventDatabase"];
            var mongoEventCollectionName = ConfigurationManager.AppSettings["MongoEventCollection"];

            var mongoConnection = new MongoClient(mongoEventStore);
            var eventDatabase = mongoConnection.GetDatabase(mongoEventDatabase);
            var eventCollection =
                eventDatabase.GetCollection<EventMessage>(mongoEventCollectionName);

            if (eventCollection == null) {
                eventDatabase.CreateCollection(mongoEventCollectionName);
                eventCollection =
                    eventDatabase.GetCollection<EventMessage>(mongoEventCollectionName);
            }
            //foreach (var eventMessage in events) {
            //    Console.WriteLine(eventMessage.ToJson());
            //    //eventCollection.InsertOne(eventMessage);
            //}
            eventCollection.InsertMany(events);
        }

        private static byte[] ConvertToMessageFormat(EventMessage eventMessage) {
            return Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(eventMessage));
        }
    }
}
