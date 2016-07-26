using System.ComponentModel.DataAnnotations.Schema;
using Tangent.CeviriDukkani.Domain.Entities.Common;

namespace Tangent.CeviriDukkani.Domain.Entities.System
{
    [Table("UserRole", Schema = "System")]
    public class UserRole : BaseEntity
    {
        public int UserId { get; set; }
        public virtual User User { get; set; }

        public int UserRoleTypeId { get; set; }
        public UserRoleType UserRoleType { get; set; }
        
    }
}
