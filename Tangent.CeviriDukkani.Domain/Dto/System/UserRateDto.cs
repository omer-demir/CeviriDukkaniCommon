using System.Collections.Generic;
using Tangent.CeviriDukkani.Domain.Dto.Document;

namespace Tangent.CeviriDukkani.Domain.Dto.System {
    public class UserRateDto : BaseDto {
        public List<RateItemDto> RateItems { get; set; }
        public decimal DtpRate { get; set; }
        public decimal GlossaryCreationRate { get; set; }
        public decimal TranslationMemoryManagementRate { get; set; }
        public decimal TerminologyExtractionRate { get; set; }
        public decimal ReviewSmeRate { get; set; }
        public decimal LinguisticTestingRate { get; set; }
        public decimal ReviewLqaRate { get; set; }
        public List<UserDocumentDto> UserDocuments{ get; set; }
    }
}