using System;
using Tangent.CeviriDukkani.Domain.Common;

namespace Tangent.CeviriDukkani.Messaging {
    public interface IConsumer {
        IConsumer WithAppName(string appName);

        IConsumer WithEvent<TEvent>(Action<TEvent> handler) where TEvent : class, IEvent;

        IConsumer Subscribe();

        void StopSubscriptionTasks();
    }
}