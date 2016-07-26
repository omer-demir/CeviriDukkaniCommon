namespace Tangent.CeviriDukkani.Domain.Dto.Document {
    public class TranslationDocumentDto : DocumentDto {
        public int PageCount { get; set; }
        public int CharCount { get; set; }
        public int CharCountWithSpaces { get; set; }
    }
}