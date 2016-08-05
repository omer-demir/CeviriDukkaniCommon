namespace Tangent.CeviriDukkani.Domain.Dto.Request {
    public class CreateCommentRequestDto {
        public int TranslationDocumentPartId { get; set; }
        public int CommentCreatorId { get; set; }
        public string Content { get; set; }
    }
}