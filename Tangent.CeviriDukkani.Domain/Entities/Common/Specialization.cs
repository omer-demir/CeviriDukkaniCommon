using System.ComponentModel.DataAnnotations.Schema;
using Tangent.CeviriDukkani.Domain.Entities.System;

namespace Tangent.CeviriDukkani.Domain.Entities.Common
{
    [Table("Specialization", Schema = "Common")]
    public class Specialization : KeyValue
    {
        public int UserAbilityId { get; set; }
        public virtual UserAbility UserAbility { get; set; }
    }
}
