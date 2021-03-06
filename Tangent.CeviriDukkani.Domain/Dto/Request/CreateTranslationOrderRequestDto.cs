﻿using System.Collections.Generic;
using Tangent.CeviriDukkani.Domain.Dto.Document;
using Tangent.CeviriDukkani.Domain.Dto.Translation;

namespace Tangent.CeviriDukkani.Domain.Dto.Request {
    public class CreateTranslationOrderRequestDto {
        public int SourceLanguageId { get; set; }
        public List<int> TargetLanguagesIds { get; set; }
        public string TranslationDocumentPath { get; set; }
        public int CharCount { get; set; }
        public int CharCountWithSpaces { get; set; }
        public int PageCount { get; set; }
        public int TerminologyId { get; set; }
        public int? CompanyTerminologyId { get; set; }
        public int? CompanyDocumentTemplateId { get; set; }
        public int TranslationQualityId { get; set; }   
        public int CustomerId { get; set; }
        public string CampaignItemCode { get; set; }

    }
}