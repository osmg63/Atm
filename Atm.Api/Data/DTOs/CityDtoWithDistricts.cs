namespace Atm.Api.Data.DTOs
{
    public class CityDtoWithDistricts
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<DistrictDtoResponse> Districts { get; set; }
    }
}
