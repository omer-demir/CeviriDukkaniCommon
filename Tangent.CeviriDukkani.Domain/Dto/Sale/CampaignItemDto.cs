using System;

namespace Tangent.CeviriDukkani.Domain.Dto.Sale {
    public class CampaignItemDto:BaseDto {
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal DiscountRate { get; set; }
        public bool Used { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}