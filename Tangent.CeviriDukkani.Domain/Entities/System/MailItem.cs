using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Tangent.CeviriDukkani.Domain.Dto.Enums;

namespace Tangent.CeviriDukkani.Domain.Entities.System {
    [Table("Mail", Schema = "System")]
    public class MailItem:BaseEntity {
        public List<MailTarget> To { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public MailStatusTypeEnum Status { get; set; }
        public MailSenderTypeEnum MailSender { get; set; }
        public DateTime SendTime { get; set; }
        public string Exception { get; set; }
    }

}