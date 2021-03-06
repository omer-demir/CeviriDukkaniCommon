﻿using System;

namespace Tangent.CeviriDukkani.Domain.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }

        protected BaseEntity()
        {
            CreatedAt = DateTime.Now;
            Active = true;
        }
    }
}
