using System.ComponentModel.DataAnnotations.Schema;
using Tangent.CeviriDukkani.Domain.Entities.System;

namespace Tangent.CeviriDukkani.Domain.Entities.Sale {
    [Table("SimultaneousTranslatingOrderTranslator", Schema = "Order")]
    public class SimultaneousTranslatingOrderTranslator:BaseEntity {
        public int SimultaneousTranslatingOrderId { get; set; }
        public virtual SimultaneousTranslatingOrder SimultaneousTranslatingOrder { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
        
    }
}