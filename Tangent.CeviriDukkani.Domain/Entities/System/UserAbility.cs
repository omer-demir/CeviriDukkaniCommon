using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Tangent.CeviriDukkani.Domain.Entities.Common;

namespace Tangent.CeviriDukkani.Domain.Entities.System {
    [Table("UserAbility", Schema = "System")]
    public class UserAbility:BaseEntity {
        public int MotherTongueId { get; set; }
        public virtual Tongue MotherTongue { get; set; }

        public int BilingualTongueId { get; set; }
        public virtual Tongue BilingualTongue { get; set; }

        public float YearsOfExperience { get; set; }

        public string FreelanceCompanyName { get; set; }
        public string Title { get; set; }

        public string Timezone { get; set; }

        public string WorkingDays { get; set; }
        public string WorkingHoursStart { get; set; }
        public string WorkingHoursEnd { get; set; }

        public int CapacityId { get; set; }
        public virtual Capacity Capacity { get; set; }

        public string QualityEnsureDescription { get; set; }
        public string Qualifications { get; set; }
        public string MainClients { get; set; }

        public List<Specialization> Specializations { get; set; }
        //public List<UserSpecialization> UserSpecializations { get; set; }
        public List<TechnologyKnowledge> TechnologyKnowledges { get; set; }

    }
}