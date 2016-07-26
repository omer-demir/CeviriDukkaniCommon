using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Tangent.CeviriDukkani.Domain.Entities.Common;

namespace Tangent.CeviriDukkani.Domain.Entities.System
{
    [Table("User", Schema = "System")]
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int GenderId { get; set; }
        [ForeignKey("GenderId")]
        public virtual Gender Gender { get; set; }
        public string MobilePhone { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int PasswordRetryCount { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public virtual List<UserRole> UserRoles { get; set; }


        public int? UserContactId { get; set; }
        public virtual UserContact UserContact { get; set; }

        public int? UserAbilityId { get; set; }
        public virtual UserAbility UserAbility { get; set; }

        public int? UserPaymentId { get; set; }
        public virtual UserPayment UserPayment { get; set; }

        public int? UserRateId { get; set; }
        public virtual UserRate UserRate { get; set; }

        public int? UserScoreId { get; set; }
        public virtual UserScore UserScore { get; set; }

    }
}
