using Tangent.CeviriDukkani.Domain.Dto.Common;

namespace Tangent.CeviriDukkani.Domain.Dto.System
{
    public class UserLanguageDto : BaseDto {
        public int UserId { get; set; }
        public virtual UserDto User { get; set; }
        public int LanguageId { get; set; }
        public virtual LanguageDto Language { get; set; }
        public int? TerminologyId { get; set; }
        public virtual TerminologyDto Terminology { get; set; }
    }
}
