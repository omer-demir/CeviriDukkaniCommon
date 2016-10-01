namespace Tangent.CeviriDukkani.Domain.Dto.System {
    public class AccountRegistrationDto : BaseDto {
        public int UserId { get; set; }
        public int CurrentStep { get; set; }
        public bool IsConfirmed { get; set; }

        public UserDto User { get; set; }
    }
}
