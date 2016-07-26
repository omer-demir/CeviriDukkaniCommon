using System.ComponentModel.DataAnnotations.Schema;

namespace Tangent.CeviriDukkani.Domain.Entities.Common
{
    [Table("District", Schema = "Common")]
    public class District: BaseEntity
    {
        public string Name { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
    }
}
