using System.ComponentModel.DataAnnotations.Schema;
using Tangent.CeviriDukkani.Domain.Entities.Common;
using Tangent.CeviriDukkani.Domain.Entities.System;

namespace Tangent.CeviriDukkani.Domain.Entities.Document
{
    [Table("UserDocument", Schema = "Document")]
    public class UserDocument : Document
    {
        public int UserDocumentTypeId { get; set; }
        public UserDocumentType UserDocumentType { get; set; }

        public int UserRateId { get; set; }
        public UserRate UserRate { get; set; }
    }
}