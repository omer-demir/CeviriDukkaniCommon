using System;
using System.Collections.Generic;
using Tangent.CeviriDukkani.Domain.Common;
using Tangent.CeviriDukkani.Domain.Dto.Enums;

namespace Tangent.CeviriDukkani.Event.MailEvents
{
    public class SendMailEvent: IEvent
    {
        #region Implementation of IEvent

        public Guid Id { get; set; }
        public int CreatedBy { get; set; }

        #endregion
        public MailTypeEnum MailType { get; set; }
        public object Data { get; set; }
        public List<string> To { get; set; }
    }
}
