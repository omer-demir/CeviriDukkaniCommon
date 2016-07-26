using Tangent.CeviriDukkani.Domain.Dto.Common;

namespace Tangent.CeviriDukkani.Domain.Dto.Translation {
    public class CompanyDocumentTemplateDto:BaseDto {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string FileUrl { get; set; }
        public virtual CompanyDto Company { get; set; }
    }
}