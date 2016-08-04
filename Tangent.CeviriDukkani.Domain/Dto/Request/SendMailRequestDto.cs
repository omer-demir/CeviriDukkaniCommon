using System.Collections.Generic;
using Tangent.CeviriDukkani.Domain.Dto.Enums;

namespace Tangent.CeviriDukkani.Domain.Dto.Request
{
    public class SendMailRequestDto
    {
        public MailType MailType { get; set; }
        public object Data { get; set; }
        public List<string> To { get; set; }
    }
}
