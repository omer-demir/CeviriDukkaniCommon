using Tangent.CeviriDukkani.Domain.Dto.Common;

namespace Tangent.CeviriDukkani.Domain.Dto.Translation
{
    public class SourceTargetLanguageDto : BaseDto
    {
        public int SourceLanguageId { get; set; }
        public virtual LanguageDto SourceLanguage { get; set; }
        public int TargetLanguageId { get; set; }
        public virtual LanguageDto TargetLanguage { get; set; }
    }
}
