using Tangent.CeviriDukkani.Domain.Dto.Common;

namespace Tangent.CeviriDukkani.Domain.Dto.System {
    public class TechnologyKnowledgeDto : BaseDto {
        public int SoftwareId { get; set; }
        public virtual SoftwareDto Software { get; set; }

        public string SoftwareVersion { get; set; }
        public string OperatingSystem { get; set; }
        public int Rating { get; set; }
        public int UserAbilityId { get; set; }
        //public virtual UserAbilityDto UserAbility { get; set; }
    }
}