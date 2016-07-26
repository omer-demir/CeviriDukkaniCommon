namespace Tangent.CeviriDukkani.Domain.Dto.Common
{
    public class DistrictDto : BaseDto {
        public string Name { get; set; }
        public int CityId { get; set; }
        public CityDto City { get; set; }
    }
}
