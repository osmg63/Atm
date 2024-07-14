namespace Atm.Api.Data.DTOs
{
    public class DistrictDtoResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CityId { get; set; }
        public string CityName { get; set; }
    }
}
