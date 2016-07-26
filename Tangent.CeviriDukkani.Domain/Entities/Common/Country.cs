using System.ComponentModel.DataAnnotations.Schema;

namespace Tangent.CeviriDukkani.Domain.Entities.Common
{
    [Table("Country", Schema = "Common")]
    public class Country : BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; } // Ülke Telefon Kodu
    }
}
