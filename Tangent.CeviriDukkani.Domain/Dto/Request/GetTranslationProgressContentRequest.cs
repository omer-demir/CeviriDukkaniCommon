namespace Tangent.CeviriDukkani.Domain.Dto.Request {
    public class GetTranslationProgressContentRequest {
        public int TranslationDocumentPartId { get; set; }
        public int UserId { get; set; }
    }
}