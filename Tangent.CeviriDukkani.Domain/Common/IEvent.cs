using System;

namespace Tangent.CeviriDukkani.Domain.Common {
    public interface IEvent {
        Guid Id { get; set; }
        int CreatedBy { get; set; }
    }
}