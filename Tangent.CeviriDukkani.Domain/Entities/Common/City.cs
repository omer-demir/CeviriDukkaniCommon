using System.ComponentModel.DataAnnotations.Schema;

namespace Tangent.CeviriDukkani.Domain.Entities.Common
{
    [Table("City", Schema = "Common")]
    public class City : BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; } // Plaka Kod
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
