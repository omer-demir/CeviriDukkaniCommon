
using System.ComponentModel.DataAnnotations.Schema;

namespace Tangent.CeviriDukkani.Domain.Entities.Common {
    [Table("TerminologyPriceRate", Schema = "Common")]
    public class TerminologyPriceRate : BaseEntity {
        public int TerminologyId { get; set; }
        public virtual Terminology Terminology { get; set; }
        public decimal Rate { get; set; }

    }
}