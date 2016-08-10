namespace Tangent.CeviriDukkani.Domain.Dto.Document
{
    public class TranslationDocumentPartDto : BaseDto {
        public int TranslationDocumentId { get; set; }
        public virtual TranslationDocumentDto TranslationDocument { get; set; }
        public string Path { get; set; }
        public int CharCount { get; set; }
        public int CharCountWithSpaces { get; set; }
        public string Content { get; set; }
    }
}
