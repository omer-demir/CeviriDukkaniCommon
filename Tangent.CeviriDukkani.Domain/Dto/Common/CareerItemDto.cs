using System;

namespace Tangent.CeviriDukkani.Domain.Dto.Common {
    public class CareerItemDto : BaseDto {
        public string Title { get; set; }
        public string Location { get; set; }
        public DateTime PublishedTime { get; set; }
        public int PersonCount { get; set; }
        public string Detail { get; set; }

    }
}