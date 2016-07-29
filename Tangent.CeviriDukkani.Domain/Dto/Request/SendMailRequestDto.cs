using System.Collections.Generic;
using Tangent.CeviriDukkani.Domain.Dto.Enums;
using Tangent.CeviriDukkani.Domain.Entities.System;

namespace Tangent.CeviriDukkani.Domain.Dto.Request
{
    public class SendMailRequestDto
    {
        public MailSenderTypeEnum MailSender { get; set; }
        public string Message { get; set; }
        public string Subject { get; set; }
        public List<string> To { get; set; }
    }
}
