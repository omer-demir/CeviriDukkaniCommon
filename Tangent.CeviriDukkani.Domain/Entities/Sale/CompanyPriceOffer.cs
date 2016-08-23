using System.ComponentModel.DataAnnotations.Schema;
using Tangent.CeviriDukkani.Domain.Entities.Common;

namespace Tangent.CeviriDukkani.Domain.Entities.Sale {
    [Table("CompanyPriceOffer",Schema = "Sale")]
    public class CompanyPriceOffer:BaseEntity {
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public decimal PricePerCharacter { get; set; }
    }
}