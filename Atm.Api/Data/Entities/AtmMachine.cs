namespace Atm.Api.Data.Entities
{
    public class AtmMachine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string Adress { get; set; }
        public int DistrictId { get; set; }
        public int CityId { get; set; }
        public bool IsActive { get; set; }
        public virtual District District { get; set; }
        public virtual City City { get; set; }
    }
}
