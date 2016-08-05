namespace Tangent.CeviriDukkani.Domain.Dto.Request {
    public class MarkOperationAsFinishedRequestDto {
        public int TranslationDocumentPartId { get; set; }
        public int UserId { get; set; }
    }
}