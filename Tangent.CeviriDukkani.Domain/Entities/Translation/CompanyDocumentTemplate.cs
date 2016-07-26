using System.ComponentModel.DataAnnotations.Schema;
using Tangent.CeviriDukkani.Domain.Entities.Common;

namespace Tangent.CeviriDukkani.Domain.Entities.Translation {
    [Table("CompanyDocumentTemplate", Schema = "Translation")]
    public class CompanyDocumentTemplate:BaseEntity {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string FileUrl { get; set; }
        public virtual Company Company { get; set; }
    }
}