using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using RabbitMQ.Client;

namespace Tangent.CeviriDukkani.Messaging.Producer
{
    public class RabbitMqCommitDispatcher : IDispatchCommits
    {
        private readonly IConnection connection;
        private readonly string topicExchangeName;

        public RabbitMqCommitDispatcher(IConnection connection, string topicExchangeName)
        {
            this.connection = connection;
            this.topicExchangeName = topicExchangeName;
        }

        public void Dispose()
        {

        }

        public void Dispatch(ICollection<EventMessage> events)
        {
            using (var channel = connection.CreateModel())
            {
                channel.ExchangeDeclare(topicExchangeName, ExchangeType.Topic, true);
                var basicProperties = channel.CreateBasicProperties();
                basicProperties.Persistent = true;

                foreach (var eventMessage in events)
                {
                    var routingKey = eventMessage.Headers["EventType"].ToString();
                    var payload = ConvertToMessageFormat(eventMessage);

                    channel.BasicPublish(topicExchangeName, routingKey, basicProperties, payload);
                }
            }
        }

        private static byte[] ConvertToMessageFormat(EventMessage eventMessage)
        {
            return Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(eventMessage));
        }
    }
}
