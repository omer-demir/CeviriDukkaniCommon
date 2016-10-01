using System.ComponentModel.DataAnnotations.Schema;
using Tangent.CeviriDukkani.Domain.Entities.Common;

namespace Tangent.CeviriDukkani.Domain.Entities.Sale {
    [Table("CompanyPriceOffer",Schema = "Sale")]
    public class CompanyPriceOffer:BaseEntity {
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public int WorkingTypeId { get; set; }
        public virtual WorkingType WokWorkingType { get; set; }
        public decimal? Price { get; set; }
        public bool IsApplicableForCalculation { get; set; }
    }
}