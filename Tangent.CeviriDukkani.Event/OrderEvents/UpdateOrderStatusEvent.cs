using System;
using Tangent.CeviriDukkani.Domain.Common;

namespace Tangent.CeviriDukkani.Event.OrderEvents {
    public class UpdateOrderStatusEvent:IEvent {
        #region Implementation of IEvent

        public Guid Id { get; set; }
        public int CreatedBy { get; set; }

        #endregion

        public int TranslationOperationId { get; set; }
        public int StatusId { get; set; }
    }
}