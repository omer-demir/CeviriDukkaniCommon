using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using RabbitMQ.Util;

namespace Tangent.CeviriDukkani.Messaging.Consumer {
    public class CustomQueueingBasicConsumer:DefaultBasicConsumer,IQueueingBasicConsumer {
        #region Implementation of IQueueingBasicConsumer

        public SharedQueue<BasicDeliverEventArgs> Queue { get; }

        #endregion

        /// <summary>
        /// Creates a fresh <see cref="CustomQueueingBasicConsumer"/>,
        ///  initialising the <see cref="DefaultBasicConsumer.Model"/> property to null
        ///  and the <see cref="Queue"/> property to a fresh <see cref="SharedQueue"/>.
        /// </summary>
        public CustomQueueingBasicConsumer() : this(null)
        {
        }

        /// <summary>
        /// Creates a fresh <see cref="CustomQueueingBasicConsumer"/>, with <see cref="DefaultBasicConsumer.Model"/>
        ///  set to the argument, and <see cref="Queue"/> set to a fresh <see cref="SharedQueue"/>.
        /// </summary>
        public CustomQueueingBasicConsumer(IModel model) : this(model, new SharedQueue<BasicDeliverEventArgs>())
        {
        }

        /// <summary>
        /// Creates a fresh <see cref="CustomQueueingBasicConsumer"/>,
        ///  initialising the <see cref="DefaultBasicConsumer.Model"/>
        ///  and <see cref="Queue"/> properties to the given values.
        /// </summary>
        public CustomQueueingBasicConsumer(IModel model, SharedQueue<BasicDeliverEventArgs> queue) : base(model)
        {
            Queue = queue;
        }
        

        /// <summary>
        /// Overrides <see cref="DefaultBasicConsumer"/>'s  <see cref="HandleBasicDeliver"/> implementation,
        ///  building a <see cref="BasicDeliverEventArgs"/> instance and placing it in the Queue.
        /// </summary>
        public override void HandleBasicDeliver(string consumerTag,
            ulong deliveryTag,
            bool redelivered,
            string exchange,
            string routingKey,
            IBasicProperties properties,
            byte[] body) {
            var eventArgs = new BasicDeliverEventArgs {
                ConsumerTag = consumerTag,
                DeliveryTag = deliveryTag,
                Redelivered = redelivered,
                Exchange = exchange,
                RoutingKey = routingKey,
                BasicProperties = properties,
                Body = body
            };
            Queue.Enqueue(eventArgs);
        }

        /// <summary>
        /// Overrides <see cref="DefaultBasicConsumer"/>'s OnCancel implementation,
        ///  extending it to call the Close() method of the <see cref="SharedQueue"/>.
        /// </summary>
        public override void OnCancel() {
            base.OnCancel();
            Queue.Close();
        }
    }
}
