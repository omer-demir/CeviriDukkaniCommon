using System.ComponentModel.DataAnnotations.Schema;
using Tangent.CeviriDukkani.Domain.Entities.Common;

namespace Tangent.CeviriDukkani.Domain.Entities.System
{
    [Table("UserLanguage", Schema = "System")]
    public class UserLanguage : BaseEntity
    {
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int LanguageId { get; set; }
        public virtual Language Language { get; set; }
        public int? TerminologyId { get; set; }
        public virtual Terminology Terminology { get; set; }
    }
}
