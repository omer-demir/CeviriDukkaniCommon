using System;
using Tangent.CeviriDukkani.Domain.Common;

namespace Tangent.CeviriDukkani.Event.DocumentEvents {
    public class CreateDocumentPartEvent:IEvent {
        #region Implementation of IEvent

        public Guid Id { get; set; }

        #endregion

        public int OrderId { get; set; }
        public int TranslationDocumentId { get; set; }
        public int TranslationQualityId { get; set; }
    }
}