
namespace Tangent.CeviriDukkani.Domain.Dto.Common {
    public class TerminologyPriceRateDto:BaseDto {
        public int TerminologyId { get; set; }
        public virtual TerminologyDto Terminology { get; set; }
        public decimal Rate { get; set; }
    }
}