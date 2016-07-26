using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Tangent.CeviriDukkani.Domain.Entities.Common;
using Tangent.CeviriDukkani.Domain.Entities.Document;
using Tangent.CeviriDukkani.Domain.Entities.Translation;

namespace Tangent.CeviriDukkani.Domain.Entities.Sale {
    [Table("Order", Schema = "Sale")]
    public class Order:BaseEntity {
        public int TranslationDocumentId { get; set; }
        public virtual TranslationDocument TranslationDocument { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public int SourceLanguageId { get; set; }
        public virtual Language SourceLanguage { get; set; }

        public virtual List<OrderTargetLanguage> TargetLanguages { get; set; }

        public int TerminologyId { get; set; }
        public virtual Terminology Terminology { get; set; }

        public int? CompanyTerminologyId { get; set; }
        public virtual CompanyTerminology CompanyTerminology { get; set; }

        public int? CompanyDocumentTemplateId { get; set; }
        public virtual CompanyDocumentTemplate CompanyDocumentTemplate { get; set; }

        public int TranslationQualityId { get; set; }
        public TranslationQuality TranslationQuality { get; set; }

        public decimal CalculatedPrice { get; set; }
        public decimal VatPrice { get; set; }

        public DateTime? OrderPotentialDeliveryDate { get; set; }

        public virtual List<OrderDetail> OrderDetails { get; set; }

        public int OrderStatusId { get; set; }
        public OrderStatus OrderStatus { get; set; }
    }
}