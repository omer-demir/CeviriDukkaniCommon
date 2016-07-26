using System;

namespace Tangent.CeviriDukkani.Messaging.Consumer {
    public class HandlerInfo {
        public Delegate Handler { get; set; }

        public Type EventType { get; set; }

        public HandlerInfo(Delegate handler, Type eventType) {
            Handler = handler;
            EventType = eventType;
        }
    }
}