using Tangent.CeviriDukkani.Domain.Dto.Sale;

namespace Tangent.CeviriDukkani.Domain.Dto.Common
{
    public class OrderTargetLanguageDto : BaseDto
    {
        public int OrderId { get; set; }
        public virtual OrderDto Order { get; set; }

        public int LanguageId { get; set; }
        public virtual LanguageDto Language { get; set; }
    }
}
