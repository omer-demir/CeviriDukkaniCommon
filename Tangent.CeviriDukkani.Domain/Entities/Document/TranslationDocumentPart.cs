using System.ComponentModel.DataAnnotations.Schema;

namespace Tangent.CeviriDukkani.Domain.Entities.Document
{
    [Table("TranslationDocumentPart", Schema = "Document")]
    public class TranslationDocumentPart : BaseEntity
    {
        public int TranslationDocumentId { get; set; }
        public virtual TranslationDocument TranslationDocument { get; set; }
        public string Path { get; set; }
        public int CharCount { get; set; }
        public int CharCountWithSpaces { get; set; }
        public string Content { get; set; }
    }
}
