using Tangent.CeviriDukkani.Domain.Dto.Common;
using Tangent.CeviriDukkani.Domain.Dto.Document;

namespace Tangent.CeviriDukkani.Domain.Dto.System {
    public class RateItemDto: BaseDto {
        public int ServiceTypeId { get; set; }
        public ServiceTypeDto ServiceType { get; set; }

        public int SourceLanguageId { get; set; }
        public LanguageDto SourceLanguage { get; set; }

        public int TargetLanguageId { get; set; }
        public LanguageDto TargetLanguage { get; set; }

        public decimal Price { get; set; }

        public bool? SwornOrCertified { get; set; }
        public int? CertificateId { get; set; }
        public virtual UserDocumentDto Certificate { get; set; }

        public int UserRateId { get; set; }
    }
}