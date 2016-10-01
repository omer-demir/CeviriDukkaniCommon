using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Tangent.CeviriDukkani.Domain.Entities.Common;
using Tangent.CeviriDukkani.Domain.Entities.Document;
using Tangent.CeviriDukkani.Domain.Entities.Translation;

namespace Tangent.CeviriDukkani.Domain.Entities.Sale {
    [Table("TranslatingOrder", Schema = "Order")]
    public class TranslatingOrder:Order {
        public int TranslationDocumentId { get; set; }
        public virtual TranslationDocument TranslationDocument { get; set; }

        public int? CompanyDocumentTemplateId { get; set; }
        public virtual CompanyDocumentTemplate CompanyDocumentTemplate { get; set; }

        public DateTime? OrderPotentialDeliveryDate { get; set; }

        public virtual List<OrderDetail> OrderDetails { get; set; }

        public int TranslationQualityId { get; set; }
        public TranslationQuality TranslationQuality { get; set; }
    }
}