using System.ComponentModel.DataAnnotations.Schema;
using Tangent.CeviriDukkani.Domain.Entities.Common;

namespace Tangent.CeviriDukkani.Domain.Entities.System {
    [Table("UserScoreTransaction", Schema = "System")]
    public class UserScoreTransaction:BaseEntity {
        public int VotingUserId { get; set; }
        public virtual User VotingUser { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }

        public int TranslatingScoreId { get; set; }
        public Score TranslatingScore { get; set; }

        public int EditingScoreId { get; set; }
        public Score EditingScore { get; set; }

        public int ProofReadingScoreId { get; set; }
        public Score ProofReadingScore { get; set; }

        public int RelatedDocumentId { get; set; }

        public int UserScoreId { get; set; }
        public virtual UserScore UserScore { get; set; }
        
    }
}