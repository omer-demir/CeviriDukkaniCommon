using Tangent.CeviriDukkani.Domain.Dto.Common;

namespace Tangent.CeviriDukkani.Domain.Dto.System {
    public class UserPaymentDto : BaseDto {
        public int BankAccountId { get; set; }
        public virtual BankAccountDto BankAccount { get; set; }

        public string VatTaxNo { get; set; }

        public int CurrencyId { get; set; }
        public virtual CurrencyDto Currency { get; set; }

        public int WorkingTypeId { get; set; }
        public virtual WorkingTypeDto WorkingType { get; set; }

        public decimal MinimumChargeAmount { get; set; }
    }
}