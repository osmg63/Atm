namespace Atm.Api.Data.DTOs
{
    public class CityDtoWithAtms
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<AtmDtoForCityResponse> AtmMachines { get; set; }
    }
}
