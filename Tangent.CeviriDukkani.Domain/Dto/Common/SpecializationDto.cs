using Tangent.CeviriDukkani.Domain.Dto.System;

namespace Tangent.CeviriDukkani.Domain.Dto.Common
{
    public class SpecializationDto : KeyValueDto
    {
        public int UserAbilityId { get; set; }
        public virtual UserAbilityDto UserAbility { get; set; }
    }
}