using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Tangent.CeviriDukkani.Domain.Entities.System
{
    [Table("UserScore", Schema = "System")]
    public class UserScore : BaseEntity
    {
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

        public List<UserScoreTransaction> UserScoreTransactions { get; set; }

        private int GetScoreValue(BaseEntity item) => item?.Id ?? 0;
    }
}
