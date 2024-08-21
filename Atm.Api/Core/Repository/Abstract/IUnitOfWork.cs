namespace Atm.Api.Core.Repository.Abstract
{
    public interface IUnitOfWork
    {
        ICityRepository CityRepository { get; }
        IDistrictRepository DistrictRepository { get; }
        IAtmMachineRepository AtmMachineRepository { get; }
        Task<int> SaveChangesAsync();
    }
}
