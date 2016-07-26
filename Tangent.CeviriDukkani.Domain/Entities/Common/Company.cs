using System.ComponentModel.DataAnnotations.Schema;

namespace Tangent.CeviriDukkani.Domain.Entities.Common
{
    [Table("Company", Schema = "Common")]
    public class Company : BaseEntity
    {
        public string Name { get; set; }
        public string AuthorizedEmail { get; set; }
        public string AuthorizedFullName { get; set; }
        public string AuthorizedMobilePhone { get; set; }
        public string Phone { get; set; }
        public string ExtensionNumber { get; set; }
        public string AccountingEmail { get; set; }
        public bool? IsUsingPo { get; set; }
        public string TaxNumber { get; set; }
        public string TaxOffice { get; set; }
        public string Address { get; set; }
        public bool? IsContractPrice { get; set; }
    }
}
