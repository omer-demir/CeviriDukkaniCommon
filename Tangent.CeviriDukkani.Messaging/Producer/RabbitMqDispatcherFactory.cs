using RabbitMQ.Client;

namespace Tangent.CeviriDukkani.Messaging.Producer
{
    public class RabbitMqDispatcherFactory : IDispatcherFactory
    {
        private readonly IConnection connection;
        private readonly string topicExchangeName;

        public RabbitMqDispatcherFactory(IConnection connection, string topicExchangeName)
        {
            this.connection = connection;
            this.topicExchangeName = topicExchangeName;
        }

        public IDispatchCommits CreateDispatcher()
        {
            return new RabbitMqCommitDispatcher(connection, topicExchangeName);
        }
    }
}
