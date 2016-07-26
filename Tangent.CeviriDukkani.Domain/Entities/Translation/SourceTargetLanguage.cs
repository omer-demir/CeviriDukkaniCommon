using System.ComponentModel.DataAnnotations.Schema;
using Tangent.CeviriDukkani.Domain.Entities.Common;

namespace Tangent.CeviriDukkani.Domain.Entities.Translation
{
    [Table("SourceTargetLanguage", Schema = "Translation")]
    public class SourceTargetLanguage : BaseEntity
    {
        public int SourceLanguageId { get; set; }
        public virtual Language SourceLanguage { get; set; }
        public int TargetLanguageId { get; set; }
        public virtual Language TargetLanguage { get; set; }
    }
}
