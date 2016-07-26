using Tangent.CeviriDukkani.Domain.Dto.Common;

namespace Tangent.CeviriDukkani.Domain.Dto.Sale
{
    public class PriceListDto : BaseDto {
        public int SourceLanguageId { get; set; }
        public int TargetLanguageId { get; set; }
        public decimal Char_0_100 { get; set; }
        public decimal Char_100_150 { get; set; }
        public decimal Char_150_200 { get; set; }
        public decimal Char_200_500 { get; set; }
        public decimal Char_500_More { get; set; }
        public virtual LanguageDto SourceLanguage { get; set; }
        public virtual LanguageDto TargetLanguage { get; set; }
    }
}
