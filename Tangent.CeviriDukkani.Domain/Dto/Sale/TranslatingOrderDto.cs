﻿using System;
using System.Collections.Generic;
using System.Linq;
using Tangent.CeviriDukkani.Domain.Dto.Common;
using Tangent.CeviriDukkani.Domain.Dto.Document;
using Tangent.CeviriDukkani.Domain.Dto.Translation;

namespace Tangent.CeviriDukkani.Domain.Dto.Sale {
    public class TranslatingOrderDto:OrderDto {
        public int TranslationDocumentId { get; set; }
        public virtual TranslationDocumentDto TranslationDocument { get; set; }

        public virtual List<TranslatingOrderTargetLanguageDto> TargetLanguages { get; set; }


        public int? CompanyDocumentTemplateId { get; set; }
        public virtual CompanyDocumentTemplateDto CompanyDocumentTemplate { get; set; }

        public DateTime? OrderPotentialDeliveryDate { get; set; }

        public virtual List<OrderDetailDto> OrderDetails { get; set; }

        public int TranslationQualityId { get; set; }
        public TranslationQualityDto TranslationQuality { get; set; }

        public string TargetLanguagesAsString {
            get {
                if (TargetLanguages != null && TargetLanguages.Any()) {
                    return string.Join(",", TargetLanguages.Select(a => a.Language.Name));
                }
                return "";
            }
        }
    }
}