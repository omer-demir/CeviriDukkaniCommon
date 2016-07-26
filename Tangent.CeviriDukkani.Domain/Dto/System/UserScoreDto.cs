using System.Collections.Generic;
using System.Linq;
using Tangent.CeviriDukkani.Domain.Dto.Enums;

namespace Tangent.CeviriDukkani.Domain.Dto.System
{
    public class UserScoreDto : BaseDto {
        //TODO bunu nasıl quality olarak ifade edicez?
        //ComputedColumn
        public double AverageTranslatingScore {
            get { return UserScoreTransactions.Average(a => GetScoreValue(a.TranslatingScore)); }
            private set { }
        }
        public double AverageEditingScore {
            get { return UserScoreTransactions.Average(a => GetScoreValue(a.EditingScore)); }
            private set { }
        }
        public double AverageProofReadingScore {
            get { return UserScoreTransactions.Average(a=>GetScoreValue(a.ProofReadingScore)); }
            private set { }
        }

        public List<UserScoreTransactionDto> UserScoreTransactions { get; set; }

        private int GetScoreValue(BaseDto item) => item?.Id ?? 0;
    }
}
