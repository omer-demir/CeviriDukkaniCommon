using System;
using System.Collections.Generic;
using Tangent.CeviriDukkani.Domain.Dto.Common;
using Tangent.CeviriDukkani.Domain.Dto.Enums;
using Tangent.CeviriDukkani.Domain.Dto.Translation;

namespace Tangent.CeviriDukkani.Domain.Dto.Sale {
    public class OrderDto : BaseDto {
        public int DocumentId { get; set; }
        public virtual Document.DocumentDto Document { get; set; }

        public int CustomerId { get; set; }
        public virtual CustomerDto Customer { get; set; }

        public int SourceLanguageId { get; set; }
        public virtual LanguageDto SourceLanguage { get; set; }

        public virtual List<OrderTargetLanguageDto> TargetLanguages { get; set; }

        public int TerminologyId { get; set; }
        public virtual TerminologyDto Terminology { get; set; }

        public int? CompanyTerminologyId { get; set; }
        public virtual CompanyTerminologyDto CompanyTerminology { get; set; }

        public int? CompanyDocumentTemplateId { get; set; }
        public virtual CompanyDocumentTemplateDto CompanyDocumentTemplate { get; set; }

        public int TranslationQualityId { get; set; }
        public TranslationQualityDto TranslationQuality { get; set; }

        public decimal CalculatedPrice { get; set; }
        public decimal VatPrice { get; set; }

        public DateTime? OrderPotentialDeliveryDate { get; set; }

        public virtual List<OrderDetailDto> OrderDetails { get; set; }

        public int OrderStatusId { get; set; }
        public OrderStatusDto OrderStatus { get; set; }

        public int? CampaignItemId { get; set; }
        public virtual CampaignItemDto CampaignItem { get; set; }
    }
}