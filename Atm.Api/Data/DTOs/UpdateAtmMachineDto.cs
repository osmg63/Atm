namespace Atm.Api.Data.DTOs
{
    public class UpdateAtmMachineDto
    {
        public int Id { get; set; }
        public string Name { get; set; } 

        public bool IsActive { get; set; }
    }
}
