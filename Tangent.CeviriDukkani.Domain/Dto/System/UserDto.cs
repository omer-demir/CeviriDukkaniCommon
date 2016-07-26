using System;
using System.Collections.Generic;
using Tangent.CeviriDukkani.Domain.Dto.Common;
using Tangent.CeviriDukkani.Domain.Dto.Enums;

namespace Tangent.CeviriDukkani.Domain.Dto.System
{
    public class UserDto : BaseDto
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int GenderId { get; set; }
        public GenderDto Gender { get; set; }

        public GenderEnum GenderType => Gender?.Id == (int)GenderEnum.Female ? GenderEnum.Female : GenderEnum.Male;

        public string MobilePhone { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int PasswordRetryCount { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public virtual List<UserRoleDto> UserRoles { get; set; }


        public int? UserContactId { get; set; }
        public virtual UserContactDto UserContact { get; set; }

        public int? UserAbilityId { get; set; }
        public virtual UserAbilityDto UserAbility { get; set; }

        public int? UserPaymentId { get; set; }
        public virtual UserPaymentDto UserPayment { get; set; }

        public int? UserRateId { get; set; }
        public virtual UserRateDto UserRate { get; set; }

        public int? UserScoreId { get; set; }
        public virtual UserScoreDto UserScore { get; set; }
        public string UserRoleTypeString
        {
            get
            {
                var userRoles = "";
                if (UserRoles?.Count > 0)
                {
                    foreach (var item in UserRoles)
                    {
                        userRoles += item.UserRoleType?.Name + ",";
                    }
                    userRoles = userRoles.Substring(0, userRoles.Length - 1);
                }
                return userRoles;
            }
        }

    }
}
