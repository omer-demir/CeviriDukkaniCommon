using Tangent.CeviriDukkani.Domain.Dto.Common;

namespace Tangent.CeviriDukkani.Domain.Dto.System
{
    public class UserContactDto : BaseDto {
        
        
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string AlternativeEmail { get; set; }
        public string AlternativePhone1 { get; set; }
        public string AlternativePhone2 { get; set; }
        public string Fax { get; set; }
        public string Skype { get; set; }

        public int UserId { get; set; }
        public virtual UserDto User { get; set; }

        public int DistrictId { get; set; }
        public DistrictDto District { get; set; }
    }
}
