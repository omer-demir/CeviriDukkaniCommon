using System.ComponentModel.DataAnnotations.Schema;

namespace Tangent.CeviriDukkani.Domain.Entities.Common {
    [Table("BankAccountType", Schema = "Common")]
    public class BankAccountType:KeyValue {
        //turkish,european or outside turkey,paypal
    }
}