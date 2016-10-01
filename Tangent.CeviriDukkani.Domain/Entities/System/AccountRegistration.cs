using System.ComponentModel.DataAnnotations.Schema;

namespace Tangent.CeviriDukkani.Domain.Entities.System {
    [Table("AccountRegistration", Schema = "System")]
    public class AccountRegistration : BaseEntity {
        public int UserId { get; set; }
        public int CurrentStep { get; set; }
        public bool IsConfirmed { get; set; }

        public virtual User User { get; set; }
    }
}