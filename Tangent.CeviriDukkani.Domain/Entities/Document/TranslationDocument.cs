using System.ComponentModel.DataAnnotations.Schema;

namespace Tangent.CeviriDukkani.Domain.Entities.Document {
    [Table("TranslationDocument", Schema = "Document")]
    public class TranslationDocument:Document {
        public int PageCount { get; set; }
        public int CharCount { get; set; }
        public int CharCountWithSpaces { get; set; }
    }
}