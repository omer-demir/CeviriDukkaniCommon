
using System.ComponentModel.DataAnnotations.Schema;

namespace Tangent.CeviriDukkani.Domain.Entities.Document
{
    [Table("Document", Schema = "Document")]
    public class Document : BaseEntity
    {
        public string Name { get; set; }
        public string Path { get; set; }
    }
}
