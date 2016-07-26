using System.ComponentModel.DataAnnotations.Schema;
using Tangent.CeviriDukkani.Domain.Entities.Common;

namespace Tangent.CeviriDukkani.Domain.Entities.System
{
    [Table("TechnologyKnowledge", Schema = "System")]
    public class TechnologyKnowledge : BaseEntity
    {
        public int SoftwareId { get; set; }
        [ForeignKey("SoftwareId")]
        public virtual Software Software { get; set; }

        public string SoftwareVersion { get; set; }
        public string OperatingSystem { get; set; }
        public int Rating { get; set; }

        public int UserAbilityId { get; set; }
        public virtual UserAbility UserAbility { get; set; }
    }
}