using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tangent.CeviriDukkani.Domain.Entities.Sale {
    [Table("CampaignItem",Schema = "Sale")]
    public class CampaignItem : BaseEntity {
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal DiscountRate { get; set; }
        public bool Used { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}