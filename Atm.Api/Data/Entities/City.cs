namespace Atm.Api.Data.Entities
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<District> Districts { get; set; }
        public ICollection<AtmMachine> AtmMachines { get; set; }

    }
}

