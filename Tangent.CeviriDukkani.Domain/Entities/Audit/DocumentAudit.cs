using System;

namespace Tangent.CeviriDukkani.Domain.Entities.Audit
{
    public class DocumentAudit
    {
        public int Id { get; set; }
        
        public int DocumentId { get; set; }
        public string Message { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }
    }
}
