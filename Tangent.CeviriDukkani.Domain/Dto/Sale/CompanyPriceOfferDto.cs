using Tangent.CeviriDukkani.Domain.Dto.Common;

namespace Tangent.CeviriDukkani.Domain.Dto.Sale {
    public class CompanyPriceOfferDto:BaseDto {
        public int CompanyId { get; set; }
        public virtual CompanyDto Company { get; set; }
        public int WorkingTypeId { get; set; }
        public virtual WorkingTypeDto WokWorkingType { get; set; }
        public decimal? Price { get; set; }
        public bool IsApplicableForCalculation { get; set; }
    }
}