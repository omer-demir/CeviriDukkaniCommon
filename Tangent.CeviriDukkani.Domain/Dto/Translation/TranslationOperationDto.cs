using System.Collections.Generic;
using Tangent.CeviriDukkani.Domain.Dto.Common;
using Tangent.CeviriDukkani.Domain.Dto.Document;
using Tangent.CeviriDukkani.Domain.Dto.System;

namespace Tangent.CeviriDukkani.Domain.Dto.Translation {
    public class TranslationOperationDto:BaseDto {
        public int TranslationDocumentPartId { get; set; }
        public virtual TranslationDocumentPartDto DocumentPart { get; set; }

        public int? TranslatorId { get; set; }
        public virtual UserDto Translator { get; set; }
        public string TranslatedContent { get; set; }

        public int? EditorId { get; set; }
        public virtual UserDto Editor { get; set; }
        public string EditedContent { get; set; }

        public int? ProofReaderId { get; set; }
        public virtual UserDto ProofReader { get; set; }
        public string ProofReadContent { get; set; }

        public virtual List<CommentDto> Comments { get; set; }

        public int TranslationOperationStatusId { get; set; }
        public TranslationOperationStatusDto TranslationOperationStatus { get; set; }

        public int TranslationProgressStatusId { get; set; }
        public TranslationProgressStatusDto TranslationProgressStatus { get; set; }
    }
}