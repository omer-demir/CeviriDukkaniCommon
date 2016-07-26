using Newtonsoft.Json;

namespace Tangent.CeviriDukkani.Messaging {
    public static class EventMessageExtensions {

        public static string ToJson(this EventMessage eventMessage) {
            return JsonConvert.SerializeObject(eventMessage);
        }

        public static EventMessage FromJson(string eventString) {
            EventMessage eventMessage = null;

            eventMessage = JsonConvert.DeserializeObject(eventString, typeof(EventMessage)) as EventMessage;

            return eventMessage;
        }
    }
}