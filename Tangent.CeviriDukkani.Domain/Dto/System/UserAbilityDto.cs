using System.Collections.Generic;
using System.Linq;
using Tangent.CeviriDukkani.Domain.Dto;
using Tangent.CeviriDukkani.Domain.Dto.Common;
using Tangent.CeviriDukkani.Domain.Dto.Translation;

namespace Tangent.CeviriDukkani.Domain.Dto.System
{
    public class UserAbilityDto : BaseDto
    {
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

        public string TerminologyIdString => Specializations != null ? string.Join(",", Specializations.Select(s => s.TerminologyId)) : "";

        public List<TechnologyKnowledgeDto> TechnologyKnowledges { get; set; }
        public string SoftwareIdString => TechnologyKnowledges != null ? string.Join(",", TechnologyKnowledges.Select(s => s.SoftwareId)) : "";

    }
}