namespace Tangent.CeviriDukkani.Domain.Dto.Common {
    public class CapacityDto:BaseDto {
        public int Translation { get; set; }
        public int TranslationWorkingTypeId { get; set; }
        public virtual WorkingTypeDto TranslationWorkingType { get; set; }

        public int Reviews { get; set; }
        public int ReviewsWorkingTypeId { get; set; }
        public virtual WorkingTypeDto ReviewsWorkingType { get; set; }

        public int ProofReading { get; set; }
        public int ProofReadingWorkingTypeId { get; set; }
        public virtual WorkingTypeDto ProofReadingWorkingType { get; set; }
    }
}