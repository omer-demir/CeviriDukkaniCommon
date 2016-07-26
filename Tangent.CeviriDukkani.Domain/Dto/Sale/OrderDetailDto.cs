using Tangent.CeviriDukkani.Domain.Dto.Translation;

namespace Tangent.CeviriDukkani.Domain.Dto.Sale {
    public class OrderDetailDto: BaseDto {
        public int OrderId { get; set; }
        public virtual OrderDto Order { get; set; }

        public int TranslationOperationId { get; set; }
        public virtual TranslationOperationDto TranslationOperation { get; set; }

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