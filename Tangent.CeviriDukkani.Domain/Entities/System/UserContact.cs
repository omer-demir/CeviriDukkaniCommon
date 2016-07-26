using System.ComponentModel.DataAnnotations.Schema;
using Tangent.CeviriDukkani.Domain.Entities.Common;

namespace Tangent.CeviriDukkani.Domain.Entities.System
{
    [Table("UserContact", Schema = "System")]
    public class UserContact : BaseEntity
    {
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string AlternativeEmail { get; set; }
        public string AlternativePhone1 { get; set; }
        public string AlternativePhone2 { get; set; }
        public string Fax { get; set; }
        public string Skype { get; set; }

        //public int UserId { get; set; }
        //public virtual User User { get; set; }

        public int DistrictId { get; set; }
        public District District { get; set; }
    }
}
