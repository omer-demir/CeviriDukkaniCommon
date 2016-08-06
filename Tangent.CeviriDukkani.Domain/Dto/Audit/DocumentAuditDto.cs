using System;

namespace Tangent.CeviriDukkani.Domain.Dto.Audit
{
    public class DocumentAuditDto
    {
        public int Id { get; set; }

        public int DocumentId { get; set; }
        public string Message { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }
    }
}
