using System.ComponentModel.DataAnnotations.Schema;
using Tangent.CeviriDukkani.Domain.Entities.Common;

namespace Tangent.CeviriDukkani.Domain.Entities.Sale
{
    [Table("PriceList", Schema = "Sale")]
    public class PriceList :BaseEntity
    {
        public int SourceLanguageId { get; set; }
        public int TargetLanguageId { get; set; }
        public decimal Char_0_100 { get; set; }
        public decimal Char_100_150 { get; set; }
        public decimal Char_150_200 { get; set; }
        public decimal Char_200_500 { get; set; }
        public decimal Char_500_More { get; set; }
        public virtual Language SourceLanguage { get; set; }
        public virtual Language TargetLanguage { get; set; }
    }
}
