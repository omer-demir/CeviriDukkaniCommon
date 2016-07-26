using System;
using System.Collections.Generic;

namespace Tangent.CeviriDukkani.Messaging.Producer {
    public interface IDispatchCommits : IDisposable {
        void Dispatch(ICollection<EventMessage> events);
    }
}