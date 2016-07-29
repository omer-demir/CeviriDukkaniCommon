using System;
using System.Collections.Generic;
using Tangent.CeviriDukkani.Domain.Common;
using Tangent.CeviriDukkani.Domain.Dto.Enums;
using Tangent.CeviriDukkani.Domain.Dto.Translation;

namespace Tangent.CeviriDukkani.Event.MailEvents
{
    public class SendMailEvent: IEvent
    {
        #region Implementation of IEvent

        public Guid Id { get; set; }
        public int CreatedBy { get; set; }

        #endregion
        public MailSenderTypeEnum MailSender { get; set; }
        public string Message { get; set; }
        public string Subject { get; set; }
        public List<string> To { get; set; }
    }
}
