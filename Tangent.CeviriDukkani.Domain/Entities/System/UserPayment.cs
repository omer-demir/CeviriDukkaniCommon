using System.ComponentModel.DataAnnotations.Schema;
using Tangent.CeviriDukkani.Domain.Entities.Common;

namespace Tangent.CeviriDukkani.Domain.Entities.System {
    [Table("UserPayment", Schema = "System")]
    public class UserPayment:BaseEntity {
        public int BankAccountId{ get; set; }
        public virtual BankAccount BankAccount { get; set; }

        public string VatTaxNo { get; set; }

        public int CurrencyId { get; set; }
        public virtual Currency Currency { get; set; }

        public int WorkingTypeId { get; set; }
        public virtual WorkingType WorkingType { get; set; }

        public decimal MinimumChargeAmount { get; set; }
    }
}