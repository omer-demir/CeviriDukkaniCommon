using System.ComponentModel.DataAnnotations.Schema;

namespace Tangent.CeviriDukkani.Domain.Entities.Common {
    [Table("Configuration",Schema="Common")]
    public class Configuration:BaseEntity {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}