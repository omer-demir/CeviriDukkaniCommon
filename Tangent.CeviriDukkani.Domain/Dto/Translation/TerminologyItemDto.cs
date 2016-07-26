namespace Tangent.CeviriDukkani.Domain.Dto.Translation {
    public class TerminologyItemDto:BaseDto {
        public string SourceWord { get; set; }
        public string TargetWord { get; set; }
        public bool Approved { get; set; }

        public int CompanyTerminologyId { get; set; }
        public virtual CompanyTerminologyDto CompanyTerminology { get; set; }

    }
}