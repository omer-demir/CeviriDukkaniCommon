using System.ComponentModel.DataAnnotations.Schema;
using Tangent.CeviriDukkani.Domain.Entities.Common;

namespace Tangent.CeviriDukkani.Domain.Entities.Sale {
    [Table("SimultaneousTranslatingOrderEquipment", Schema = "Order")]
    public class SimultaneousTranslatingOrderEquipment:BaseEntity {
        public int SimultaneousTranslatingOrderId { get; set; }
        public virtual SimultaneousTranslatingOrder SimultaneousTranslatingOrder { get; set; }

        public int EquipmentId { get; set; }
        public virtual Equipment Equipment { get; set; }
    }
}