using Tangent.CeviriDukkani.Domain.Dto.System;

namespace Tangent.CeviriDukkani.Domain.Dto.Common
{
    public class SpecializationDto : BaseDto
    {
        public int UserAbilityId { get; set; }
        //public virtual UserAbilityDto UserAbility { get; set; }

        public int TerminologyId { get; set; }
        public virtual TerminologyDto Terminology { get; set; }
    }
}