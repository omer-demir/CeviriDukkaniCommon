using Tangent.CeviriDukkani.Domain.Dto.Common;

namespace Tangent.CeviriDukkani.Domain.Dto.Sale {
    public class CompanyPriceOfferDto:BaseDto {
        public int CompanyId { get; set; }
        public virtual CompanyDto Company { get; set; }
        public decimal PricePerCharacter { get; set; }
    }
}