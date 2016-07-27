using System;
using Tangent.CeviriDukkani.Domain.Common;

namespace Tangent.CeviriDukkani.Event.DocumentEvents {
    public class CreateDocumentPartEvent:IEvent {
        #region Implementation of IEvent

        public Guid Id { get; set; }
        public int CreatedBy { get; set; }

        #endregion

        public int TranslationDocumentId { get; set; }
        public int PartCount { get; set; }
        public int OrderId { get; set; }
    }
}