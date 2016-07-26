using Tangent.CeviriDukkani.Domain.Dto.Common;

namespace Tangent.CeviriDukkani.Domain.Dto.Sale
{
    public class CustomerDto : BaseDto
    {
        public int MembershipTypeId { get; set; }
        
        public MembershipTypeDto MembershipType { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool EmailConfirmed { get; set; }
        public bool SmsConfirmed { get; set; }
        public int? CompanyId { get; set; }
        public virtual CompanyDto Company { get; set; }
        public string InstitutionCode { get; set; } // Kurum Kodu
    }
}
