using System;
using System.ComponentModel.DataAnnotations.Schema;
using Tangent.CeviriDukkani.Domain.Entities.Sale;
using Tangent.CeviriDukkani.Domain.Entities.System;

namespace Tangent.CeviriDukkani.Domain.Entities.Common
{
    [Table("Message", Schema = "Common")]
    public class Message : BaseEntity
    {
        public int? FromUserId { get; set; }
        public virtual User FromUser { get; set; }
        public int? ToUserId { get; set; }
        public virtual User ToUser { get; set; }
        public int? FromCustomerId { get; set; }
        public virtual Customer FromCustomer { get; set; }
        public int? ToCustomerId { get; set; }
        public virtual Customer ToCustomer { get; set; }
        public string MessageText { get; set; }
        public DateTime? ReadDate { get; set; }
        public bool FromStatus { get; set; }
        public bool ToStatus { get; set; }
        public string Subject { get; set; }
    }
}
