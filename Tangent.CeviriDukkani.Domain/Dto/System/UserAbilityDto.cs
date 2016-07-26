using System.Collections.Generic;
using Tangent.CeviriDukkani.Domain.Dto.Common;

namespace Tangent.CeviriDukkani.Domain.Dto.System {
    public class UserAbilityDto : BaseDto {
        public int MotherTongueId { get; set; }
        public virtual LanguageDto MotherTongue { get; set; }

        public int BilingualTongueId { get; set; }
        public virtual LanguageDto BilingualTongue { get; set; }

        public float YearsOfExperience { get; set; }

        public int CapacityId { get; set; }
        public virtual CapacityDto Capacity { get; set; }

        public string QualityEnsureDescription { get; set; }
        public string Qualifications { get; set; }
        public string MainClients { get; set; }

        public List<SpecializationDto> Specializations { get; set; }
        public List<TechnologyKnowledgeDto> TechnologyKnowledges { get; set; }

    }
}