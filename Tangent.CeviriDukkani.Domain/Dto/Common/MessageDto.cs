using System;
using Tangent.CeviriDukkani.Domain.Dto.Sale;
using Tangent.CeviriDukkani.Domain.Dto.System;

namespace Tangent.CeviriDukkani.Domain.Dto.Common
{
    public class MessageDto : BaseDto {
        public int? FromUserId { get; set; }
        public virtual UserDto FromUser { get; set; }
        public int? ToUserId { get; set; }
        public virtual UserDto ToUser { get; set; }
        public int? FromCustomerId { get; set; }
        public virtual CustomerDto FromCustomer { get; set; }
        public int? ToCustomerId { get; set; }
        public virtual CustomerDto ToCustomer { get; set; }
        public string MessageText { get; set; }
        public DateTime? ReadDate { get; set; }
        public bool FromStatus { get; set; }
        public bool ToStatus { get; set; }
    }
}
