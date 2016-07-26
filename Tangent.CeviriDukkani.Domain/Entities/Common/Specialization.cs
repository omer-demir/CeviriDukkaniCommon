using System.ComponentModel.DataAnnotations.Schema;
using Tangent.CeviriDukkani.Domain.Entities.System;

namespace Tangent.CeviriDukkani.Domain.Entities.Common
{
    [Table("Specialization", Schema = "Common")]
    public class Specialization : BaseEntity
    {
        public int UserAbilityId { get; set; }
        public virtual UserAbility UserAbility { get; set; }

        public int TerminologyId { get; set; }
        public virtual Terminology Terminology { get; set; }
    }
}
