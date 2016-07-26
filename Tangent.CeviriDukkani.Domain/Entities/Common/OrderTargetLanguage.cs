using System.ComponentModel.DataAnnotations.Schema;
using Tangent.CeviriDukkani.Domain.Entities.Sale;

namespace Tangent.CeviriDukkani.Domain.Entities.Common
{
    [Table("OrderTargetLanguage", Schema = "Common")]
    public class OrderTargetLanguage : BaseEntity
    {
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }

        public int LanguageId { get; set; }
        public virtual Language Language { get; set; }
    }
}
