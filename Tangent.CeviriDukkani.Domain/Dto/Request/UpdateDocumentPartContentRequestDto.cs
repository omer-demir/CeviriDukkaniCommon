namespace Tangent.CeviriDukkani.Domain.Dto.Request {
    public class UpdateDocumentPartContentRequestDto {
        public int ChangerId { get; set; }
        public int TranslationDocumentPartId { get; set; }
        public string Content { get; set; }
    }
}