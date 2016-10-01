using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Tangent.CeviriDukkani.Domain.Entities.Common;
using Tangent.CeviriDukkani.Domain.Entities.Document;
using Tangent.CeviriDukkani.Domain.Entities.Translation;

namespace Tangent.CeviriDukkani.Domain.Entities.Sale {
    public class Order:BaseEntity {

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public int SourceLanguageId { get; set; }
        public virtual Language SourceLanguage { get; set; }

        public virtual List<OrderTargetLanguage> TargetLanguages { get; set; }

        public int TerminologyId { get; set; }
        public virtual Terminology Terminology { get; set; }

        public int? CompanyTerminologyId { get; set; }
        public virtual CompanyTerminology CompanyTerminology { get; set; }

        public decimal CalculatedPrice { get; set; }
        public decimal VatPrice { get; set; }

        public int OrderStatusId { get; set; }
        public OrderStatus OrderStatus { get; set; }

        public int? CampaignItemId { get; set; }
        public virtual CampaignItem CampaignItem { get; set; }
    }
}