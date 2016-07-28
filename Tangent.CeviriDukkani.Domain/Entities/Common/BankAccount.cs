using System.ComponentModel.DataAnnotations.Schema;

namespace Tangent.CeviriDukkani.Domain.Entities.Common {
    [Table("BankAccount",Schema = "Common")]
    public class BankAccount:BaseEntity {
        public int BankAccountTypeId { get; set; }
        public virtual BankAccountType BankAccountType { get; set; }

        public string BankName { get; set; }
        public string AccountHolderFullName { get; set; }
        public string IBAN { get; set; }
        public string PaypalEmailAddress { get; set; }
        public string BeneficiaryAddress { get; set; }
        public string AccountNumber { get; set; }
        public string SwiftBicCode { get; set; }
        public string CityCountryBank { get; set; }
        public string BankAddress { get; set; }
    }
}