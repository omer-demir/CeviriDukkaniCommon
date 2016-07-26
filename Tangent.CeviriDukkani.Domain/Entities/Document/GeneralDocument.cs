using System.ComponentModel.DataAnnotations.Schema;
using Tangent.CeviriDukkani.Domain.Entities.Common;

namespace Tangent.CeviriDukkani.Domain.Entities.Document {
    [Table("GeneralDocument", Schema = "Document")]
    public class GeneralDocument:Document {
        public int GeneralDocumentTypeId { get; set; }
        public GeneralDocumentType GeneralDocumentType { get; set; }
    }
}