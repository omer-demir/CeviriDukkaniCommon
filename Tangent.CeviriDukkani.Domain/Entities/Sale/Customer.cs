using System.ComponentModel.DataAnnotations.Schema;
using Tangent.CeviriDukkani.Domain.Entities.Common;

namespace Tangent.CeviriDukkani.Domain.Entities.Sale
{
    [Table("Customer", Schema = "Sale")]
    public class Customer : BaseEntity
    {
        public int MembershipTypeId { get; set; }
        public MembershipType MembershipType { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool EmailConfirmed { get; set; }
        public bool SmsConfirmed { get; set; }
        public int? CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public string InstitutionCode { get; set; } // Kurum Kodu
    }
}
