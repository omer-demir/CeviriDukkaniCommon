using Tangent.CeviriDukkani.Domain.Dto.Common;

namespace Tangent.CeviriDukkani.Domain.Dto.System
{
    public class UserRoleDto : BaseDto {
        public int UserId { get; set; }
        //public virtual UserDto User { get; set; }
        public int UserRoleTypeId { get; set; }
        public UserRoleTypeDto UserRoleType { get; set; }
    }
}
