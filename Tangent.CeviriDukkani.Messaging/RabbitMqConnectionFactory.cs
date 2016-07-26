using System;
using RabbitMQ.Client;

namespace Tangent.CeviriDukkani.Messaging {
    public class RabbitMqConnectionFactory {
        private readonly string _hostAddress;
        private readonly int _port;
        private readonly string _userName;
        private readonly string _password;

        public RabbitMqConnectionFactory(string hostAddress, string userName, string password) {
            _hostAddress = hostAddress;
            _port = 5672;
            _userName = userName;
            _password = password;
        }

        public RabbitMqConnectionFactory(string hostAddress, int port, string userName, string password) {
            _hostAddress = hostAddress;
            _port = port;
            _userName = userName;
            _password = password;
        }

        public IConnection CreateConnection() {
            var connectionFactory = new ConnectionFactory {
                UserName = _userName,
                Password = _password,
                VirtualHost = "/",
                HostName = _hostAddress,
                Port = _port,
                AutomaticRecoveryEnabled = true,
                NetworkRecoveryInterval = TimeSpan.FromMilliseconds(100),
                TopologyRecoveryEnabled = true,
                RequestedHeartbeat = 30,
            };

            connectionFactory.ClientProperties.Add("ProcessName", System.Diagnostics.Process.GetCurrentProcess().ProcessName);
            return connectionFactory.CreateConnection();
        }

    }

}