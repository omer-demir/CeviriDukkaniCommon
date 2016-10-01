using System.ComponentModel.DataAnnotations.Schema;
using Tangent.CeviriDukkani.Domain.Entities.Translation;

namespace Tangent.CeviriDukkani.Domain.Entities.Sale {
    [Table("OrderDetail", Schema = "Sale")]
    public class OrderDetail:BaseEntity {
        public int TranslatingOrderId { get; set; }
        public virtual TranslatingOrder TranslatingOrder { get; set; }

        public int TranslationOperationId { get; set; }
        public virtual TranslationOperation TranslationOperation { get; set; }

        public decimal AveragePrice { get; set; }
        public decimal? OfferedPrice { get; set; }
        public decimal? AcceptedPrice { get; set; }

        public decimal EditorAveragePrice { get; set; }
        public decimal? EditorOfferedPrice { get; set; }
        public decimal? EditorAcceptedPrice { get; set; }

        public decimal ProofReaderAveragePrice { get; set; }
        public decimal? ProofReaderOfferedPrice { get; set; }
        public decimal? ProofReaderAcceptedPrice { get; set; }
    }
}