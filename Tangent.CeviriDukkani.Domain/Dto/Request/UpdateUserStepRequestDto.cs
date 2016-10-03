using Tangent.CeviriDukkani.Domain.Dto.System;

namespace Tangent.CeviriDukkani.Domain.Dto.Request {
    public class UpdateUserStepRequestDto {
        public UserDto User { get; set; }
        public int Step { get; set; }
    }
}