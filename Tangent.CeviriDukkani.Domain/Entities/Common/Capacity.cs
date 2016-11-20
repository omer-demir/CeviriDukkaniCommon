using System.ComponentModel.DataAnnotations.Schema;

namespace Tangent.CeviriDukkani.Domain.Entities.Common {
    [Table("Capacity", Schema = "Common")]
    public class Capacity:BaseEntity {
        public int Translation { get; set; }
        public int TranslationWorkingTypeId { get; set; }
        public virtual WorkingType TranslationWorkingType { get; set; }

        public int Reviews { get; set; }
        public int ReviewsWorkingTypeId { get; set; }
        public virtual WorkingType ReviewsWorkingType { get; set; }

        public int ProofReading { get; set; }
        public int ProofReadingWorkingTypeId { get; set; }
        public virtual WorkingType ProofReadingWorkingType { get; set; }

    }
}