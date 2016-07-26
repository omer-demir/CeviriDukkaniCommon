using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Tangent.CeviriDukkani.Domain.Entities.Common;
using Tangent.CeviriDukkani.Domain.Entities.Document;
using Tangent.CeviriDukkani.Domain.Entities.System;

namespace Tangent.CeviriDukkani.Domain.Entities.Translation {
    [Table("TranslationOperation", Schema = "Translation")]
    public class TranslationOperation:BaseEntity {
        public int TranslationDocumentPartId { get; set; }
        public virtual TranslationDocumentPart TranslationDocumentPart { get; set; }

        public int? TranslatorId { get; set; }
        public virtual User Translator { get; set; }
        public string TranslatedContent { get; set; }

        public int? EditorId { get; set; }
        public virtual User Editor { get; set; }
        public string EditedContent { get; set; }

        public int? ProofReaderId { get; set; }
        public virtual User ProofReader { get; set; }
        public string ProofReadContent { get; set; }

        public virtual List<Comment> Comments { get; set; }

        public int TranslationOperationStatusId { get; set; }
        public TranslationOperationStatus TranslationOperationStatus { get; set; }

        public int TranslationProgressStatusId { get; set; }
        public TranslationProgressStatus TranslationProgressStatus { get; set; }
    }
}