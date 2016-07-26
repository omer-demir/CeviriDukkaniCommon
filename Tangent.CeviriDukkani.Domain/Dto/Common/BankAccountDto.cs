namespace Tangent.CeviriDukkani.Domain.Dto.Common {
    public class BankAccountDto : BaseDto {
        public int BankAccountTypeId { get; set; }
        public virtual BankAccountTypeDto BankAccountType { get; set; }

        public string BankName { get; set; }
        public string AccountHolderFullName { get; set; }
        public string IBAN { get; set; }
    }
}