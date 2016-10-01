using Tangent.CeviriDukkani.Domain.Dto.Common;

namespace Tangent.CeviriDukkani.Domain.Dto.Sale {
    public class TranslatingOrderTargetLanguageDto:BaseDto {
        public int TranslatingOrderId { get; set; }
        public virtual TranslatingOrderDto TranslatingOrder { get; set; }

        public int LanguageId { get; set; }
        public virtual LanguageDto Language { get; set; }
    }
}