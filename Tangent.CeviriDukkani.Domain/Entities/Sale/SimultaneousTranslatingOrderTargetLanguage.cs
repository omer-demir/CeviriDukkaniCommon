using System.ComponentModel.DataAnnotations.Schema;
using Tangent.CeviriDukkani.Domain.Entities.Common;

namespace Tangent.CeviriDukkani.Domain.Entities.Sale
{
    [Table("SimultaneousTranslatingOrderTargetLanguage", Schema = "Order")]
    public class SimultaneousTranslatingOrderTargetLanguage : BaseEntity
    {
        public int SimultaneousTranslatingOrderId { get; set; }
        public virtual SimultaneousTranslatingOrder SimultaneousTranslatingOrder { get; set; }

        public int LanguageId { get; set; }
        public virtual Language Language { get; set; }
    }
}
