using Tangent.CeviriDukkani.Domain.Dto.Common;

namespace Tangent.CeviriDukkani.Domain.Dto.Document {
    public class UserDocumentDto : DocumentDto {
        public int UserDocumentTypeId { get; set; }
        public UserDocumentTypeDto UserDocumentType { get; set; }
    }
}