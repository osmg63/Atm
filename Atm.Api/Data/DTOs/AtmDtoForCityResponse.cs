namespace Atm.Api.Data.DTOs
{
    public class AtmDtoForCityResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string Adress { get; set; }
        public int DistrictId { get; set; }
        public int CityId {  get; set; }

        public string CityName { get; set; }
        public string DistrictName { get; set; }
        public bool IsActive { get; set; }
    }
}
