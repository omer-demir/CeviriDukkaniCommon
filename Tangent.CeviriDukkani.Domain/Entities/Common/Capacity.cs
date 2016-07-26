using System.ComponentModel.DataAnnotations.Schema;

namespace Tangent.CeviriDukkani.Domain.Entities.Common {
    [Table("Capacity", Schema = "Common")]
    public class Capacity:BaseEntity {
        public int Translation { get; set; }
        public int Reviews { get; set; }
        public int ProofReading { get; set; }
    }
}