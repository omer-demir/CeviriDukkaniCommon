using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Tangent.CeviriDukkani.Domain.Entities.Common;

namespace Tangent.CeviriDukkani.Domain.Entities.Translation
{
    [Table("CompanyTerminology", Schema = "Translation")]
    public class CompanyTerminology : BaseEntity
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string FileUrl { get; set; }
        public virtual Company Company { get; set; }
        public virtual List<TerminologyItem> TerminologyItems { get; set; }

        public int CompanyTerminologyStatusId { get; set; }
        public CompanyTerminologyStatus  CompanyTerminologyStatus { get; set; }
    }
}
