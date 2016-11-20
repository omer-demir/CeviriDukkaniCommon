using System.ComponentModel.DataAnnotations.Schema;
using Tangent.CeviriDukkani.Domain.Entities.Common;
using Tangent.CeviriDukkani.Domain.Entities.Document;

namespace Tangent.CeviriDukkani.Domain.Entities.System {
    [Table("RateItem", Schema = "System")]
    public class RateItem:BaseEntity {
        public int ServiceTypeId { get; set; }
        public ServiceType ServiceType { get; set; }

        public int SourceLanguageId { get; set; }
        public Language SourceLanguage { get; set; }

        public int TargetLanguageId { get; set; }
        public Language TargetLanguage { get; set; }

        public decimal Price { get; set; }

        public int CurrencyId { get; set; }
        public virtual Currency Currency { get; set; }

        public bool? SwornOrCertified { get; set; }
        public int? CertificateId { get; set; }
        public virtual UserDocument Certificate { get; set; }

        public int UserRateId { get; set; }
        public virtual UserRate UserRate { get; set; }
        
    }
}