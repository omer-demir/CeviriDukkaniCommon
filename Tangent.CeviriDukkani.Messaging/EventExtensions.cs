using System;
using System.Collections.Generic;
using log4net;
using Newtonsoft.Json;
using Tangent.CeviriDukkani.Domain.Common;

namespace Tangent.CeviriDukkani.Messaging {
    public static class EventExtensions {


        public static EventMessage ToEventMessage<T>(this T @event) where T : class, IEvent {
            return new EventMessage {
                Headers = new Dictionary<string, object>
                {
                    { "EventId", @event.Id },
                    { "EventType", @event.GetType() }
                },
                Body = @event.ToJson()
            };
        }

        public static string ToJson<T>(this T @event) where T : class, IEvent {
            return JsonConvert.SerializeObject(@event);
        }

        public static IEvent FromJson(EventMessage eventMessage, Type type) {
            IEvent @event = null;
            try {
                var body = JsonConvert.DeserializeObject<dynamic>(eventMessage.Body.ToString());

                string payload = body.ToString();

                @event = JsonConvert.DeserializeObject(payload, type) as IEvent;
            } catch (JsonSerializationException ex) {
                Console.WriteLine($"Cannot deserialize string {ex}to event");
                //Logger.ErrorFormat("Cannot deserialize string {0} to event", ex, eventMessage);
            }

            return @event;
        }
    }
}