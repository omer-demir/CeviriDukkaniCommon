using Tangent.CeviriDukkani.Domain.Dto.Common;

namespace Tangent.CeviriDukkani.Domain.Dto.Sale {
    public class SimultaneousTranslatingOrderTargetLanguageDto:BaseDto {
        public int SimultaneousTranslatingOrderId { get; set; }
        public virtual SimultaneousTranslatingOrderDto SimultaneousTranslatingOrder { get; set; }

        public int LanguageId { get; set; }
        public virtual LanguageDto Language { get; set; }
    }
}