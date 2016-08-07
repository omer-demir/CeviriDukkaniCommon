using System;

namespace Tangent.CeviriDukkani.Domain.Entities.Sale {
    public class CampaignItem : BaseEntity {
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal DiscountRate { get; set; }
        public bool Used { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}