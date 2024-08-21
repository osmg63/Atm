using Atm.Api.Core.Repository.Abstract;
using Atm.Api.DataAccess;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Atm.Api.Core.Repository.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AtmDbContext _dbContext;
        private readonly  IMapper _myMapper;
        private  ICityRepository _cityRepository;
        private IAtmMachineRepository _atmMachineRepository;
        private IDistrictRepository _districtRepository;

        public UnitOfWork(AtmDbContext dbContext,IMapper mapper)
        {
            _myMapper= mapper;
            _dbContext = dbContext;
        }


        public IDistrictRepository DistrictRepository => _districtRepository ??= new DistrictRepository(_dbContext);
        public IAtmMachineRepository AtmMachineRepository => _atmMachineRepository ??= new AtmRepository(_dbContext, _myMapper);
        public ICityRepository CityRepository => _cityRepository ??= new CityRepository(_dbContext);

        public async Task<int> SaveChangesAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }
    }
}
