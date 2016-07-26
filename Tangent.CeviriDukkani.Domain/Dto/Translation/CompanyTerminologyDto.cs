using System.Collections.Generic;
using Tangent.CeviriDukkani.Domain.Dto.Common;
using Tangent.CeviriDukkani.Domain.Dto.Enums;

namespace Tangent.CeviriDukkani.Domain.Dto.Translation
{
    public class CompanyTerminologyDto : BaseDto
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string FileUrl { get; set; }
        public virtual CompanyDto Company { get; set; }
        public virtual List<TerminologyItemDto> TerminologyItems { get; set; }
        public CompanyTerminologyStatusDto CompanyTerminologyStatus { get; set; }
    }
}
