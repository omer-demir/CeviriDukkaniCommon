using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Tangent.CeviriDukkani.Domain.Entities.Document;

namespace Tangent.CeviriDukkani.Domain.Entities.System {
    [Table("UserRate", Schema = "System")]
    public class UserRate:BaseEntity {
        public List<RateItem> RateItems { get; set; }
        public decimal DtpRate { get; set; }
        public decimal GlossaryCreationRate { get; set; }
        public decimal TranslationMemoryManagementRate { get; set; }
        public decimal TerminologyExtractionRate { get; set; }
        public decimal ReviewSmeRate { get; set; }
        public decimal LinguisticTestingRate { get; set; }
        public decimal ReviewLqaRate { get; set; }
        public List<UserDocument> UserDocuments{ get; set; }
    }
}