namespace Tangent.CeviriDukkani.Domain.Dto.Common
{
    public class CityDto : BaseDto {
        public string Name { get; set; }
        public string Code { get; set; } // Plaka Kod
        public int CountryId { get; set; }
        public CountryDto Country { get; set; }
    }
}
