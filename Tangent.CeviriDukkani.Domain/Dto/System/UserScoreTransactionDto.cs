using Tangent.CeviriDukkani.Domain.Dto.Common;
using Tangent.CeviriDukkani.Domain.Dto.Enums;

namespace Tangent.CeviriDukkani.Domain.Dto.System {
    public class UserScoreTransactionDto:BaseDto {
        public int VotingUserId { get; set; }
        public virtual UserDto VotingUser { get; set; }
        public int UserId { get; set; }
        public virtual UserDto User { get; set; }
        public ScoreDto TranslatingScore { get; set; }
        public ScoreDto EditingScore { get; set; }
        public ScoreDto ProofReadingScore { get; set; }
        public int RelatedDocumentId { get; set; }
    }
}