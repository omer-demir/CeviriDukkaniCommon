using System.ComponentModel.DataAnnotations.Schema;
using Tangent.CeviriDukkani.Domain.Entities.System;
using Tangent.CeviriDukkani.Domain.Entities.Translation;

namespace Tangent.CeviriDukkani.Domain.Entities.Common {
    [Table("Comment", Schema = "Common")]
    public class Comment:BaseEntity {
        public string Content { get; set; }
        public int FromUserId { get; set; }
        public virtual User FromUser { get; set; }
        public int ToUserId { get; set; }
        public virtual User ToUser { get; set; }
        public int TranslationOperationId { get; set; }
        public virtual TranslationOperation TranslationOperation { get; set; }
    }
}