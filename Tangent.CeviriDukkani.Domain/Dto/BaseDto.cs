using System;

namespace Tangent.CeviriDukkani.Domain.Dto
{
    public class BaseDto
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }

        protected BaseDto()
        {
            CreatedAt = DateTime.Now;
        }
    }
}
