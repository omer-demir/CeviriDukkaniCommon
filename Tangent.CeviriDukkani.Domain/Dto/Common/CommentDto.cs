using Tangent.CeviriDukkani.Domain.Dto.System;

namespace Tangent.CeviriDukkani.Domain.Dto.Common {
    public class CommentDto : BaseDto {
        public string Content { get; set; }
        public int FromUserId { get; set; }
        public virtual UserDto FromUser { get; set; }
        public int ToUserId { get; set; }
        public virtual UserDto ToUser { get; set; }
    }
}