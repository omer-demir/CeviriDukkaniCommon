using Tangent.CeviriDukkani.Domain.Dto.System;

namespace Tangent.CeviriDukkani.Domain.Dto.Sale {
    public class SimultaneousTranslatingOrderTranslatorDto:BaseDto {
        public int SimultaneousTranslatingOrderId { get; set; }
        public virtual SimultaneousTranslatingOrderDto SimultaneousTranslatingOrder { get; set; }

        public int UserId { get; set; }
        public virtual UserDto User { get; set; }
    }
}