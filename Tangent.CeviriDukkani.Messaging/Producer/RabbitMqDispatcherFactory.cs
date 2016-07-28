using log4net;
using RabbitMQ.Client;

namespace Tangent.CeviriDukkani.Messaging.Producer
{
    public class RabbitMqDispatcherFactory : IDispatcherFactory
    {
        private readonly IConnection _connection;
        private readonly string _topicExchangeName;
        private readonly ILog _logger;

        public RabbitMqDispatcherFactory(IConnection connection, string topicExchangeName,ILog logger)
        {
            this._connection = connection;
            this._topicExchangeName = topicExchangeName;
            _logger = logger;
        }

        public IDispatchCommits CreateDispatcher()
        {
            return new RabbitMqCommitDispatcher(_connection, _topicExchangeName, _logger);
        }
    }
}
