using System;
using System.Collections.Generic;

namespace Tangent.CeviriDukkani.Messaging {
    [Serializable]
    public class EventMessage {
        public EventMessage() {
            Headers = new Dictionary<string, object>();
        }

        public Dictionary<string, object> Headers { get; set; }

        public object Body { get; set; }
    }
}