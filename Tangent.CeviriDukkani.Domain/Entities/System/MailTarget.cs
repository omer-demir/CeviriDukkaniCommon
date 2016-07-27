using System.ComponentModel.DataAnnotations.Schema;

namespace Tangent.CeviriDukkani.Domain.Entities.System {
    [Table("MailTargets", Schema = "System")]
    public class MailTarget:BaseEntity {
        public string MailAddres { get; set; }
    }
}