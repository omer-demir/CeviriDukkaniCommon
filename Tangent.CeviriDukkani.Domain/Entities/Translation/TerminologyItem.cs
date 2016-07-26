using System.ComponentModel.DataAnnotations.Schema;

namespace Tangent.CeviriDukkani.Domain.Entities.Translation {
    [Table("TerminologyItem", Schema = "Translation")]
    public class TerminologyItem:BaseEntity {
        public string SourceWord { get; set; }
        public string TargetWord { get; set; }
        public bool Approved { get; set; }
        public int CompanyTerminologyId { get; set; }
        public virtual CompanyTerminology CompanyTerminology { get; set; }
        
    }
}