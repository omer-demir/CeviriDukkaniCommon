using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tangent.CeviriDukkani.Domain.Entities.Common {
    [Table("CareerItem",Schema = "Common")]
    public class CareerItem : BaseEntity {
        public string Title { get; set; }
        public string Location { get; set; }
        public DateTime PublishedTime { get; set; }
        public int PersonCount { get; set; }
        public string Detail { get; set; }

    }
}