using System;
using System.Collections.Generic;
using Tangent.CeviriDukkani.Domain.Common;
using Tangent.CeviriDukkani.Domain.Dto.Translation;

namespace Tangent.CeviriDukkani.Event.OrderEvents {
    public class CreateOrderDetailEvent:IEvent {
        #region Implementation of IEvent

        public Guid Id { get; set; }
        public int CreatedBy { get; set; }

        #endregion

        public List<TranslationOperationDto> TranslationOperations { get; set; }
        public int OrderId { get; set; }
    }
}