using System.ComponentModel.DataAnnotations.Schema;
using Tangent.CeviriDukkani.Domain.Entities.Common;

namespace Tangent.CeviriDukkani.Domain.Entities.Sale
{
    [Table("TranslatingOrderTargetLanguage", Schema = "Order")]
    public class TranslatingOrderTargetLanguage : BaseEntity
    {
        public int TranslatingOrderId { get; set; }
        public virtual TranslatingOrder TranslatingOrder { get; set; }

        public int LanguageId { get; set; }
        public virtual Language Language { get; set; }
    }
}
