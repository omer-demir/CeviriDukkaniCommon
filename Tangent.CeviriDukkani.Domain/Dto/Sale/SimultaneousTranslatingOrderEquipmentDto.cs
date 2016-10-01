using Tangent.CeviriDukkani.Domain.Dto.Common;

namespace Tangent.CeviriDukkani.Domain.Dto.Sale {
    public class SimultaneousTranslatingOrderEquipmentDto:BaseDto {
        public int SimultaneousTranslatingOrderId { get; set; }
        public virtual SimultaneousTranslatingOrderDto SimultaneousTranslatingOrder { get; set; }

        public int EquipmentId { get; set; }
        public virtual EquipmentDto Equipment { get; set; }
    }
}