using Atm.Api.Core.Repository.Abstract;
using Atm.Api.Data.DTOs;
using Atm.Api.Data.Entities;
using Atm.Api.DataAccess;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Atm.Api.Core.Repository.Concrete
{
    public class AtmRepository : BaseRepository<AtmMachine>, IAtmMachineRepository
    {
        private readonly AtmDbContext _context;
        public AtmRepository(AtmDbContext context) : base(context)
        {
          
            _context = context;
        }

        public List<AtmMachineDto> GetAllWithCityAndDistrictName()
        {
             var query = from atmMachine in _context.AtmMachines
                        join city in _context.Cities on atmMachine.CityId equals city.Id
                        join district in _context.Districts on atmMachine.DistrictId equals district.Id
                        select new AtmMachineDto()
                        {
                            Id = atmMachine.Id,
                            Name = atmMachine.Name,
                            Latitude = atmMachine.Latitude,
                            Longitude = atmMachine.Longitude,
                            Adress = atmMachine.Adress,
                            DistrictId = atmMachine.DistrictId,
                            DistrictName = district.Name,
                            CityId = atmMachine.CityId,
                            CityName = city.Name,
                        };

            return query.ToList();
        }

        public AtmMachineDto GetById(int id)
        {
            var query = from atmMachine in _context.AtmMachines
                        join city in _context.Cities on atmMachine.CityId equals city.Id
                        join district in _context.Districts on atmMachine.DistrictId equals district.Id
                        where atmMachine.Id == id
                        select new AtmMachineDto()
                        {
                            Id = atmMachine.Id,
                            Name = atmMachine.Name,
                            Latitude = atmMachine.Latitude,
                            Longitude = atmMachine.Longitude,
                            Adress = atmMachine.Adress,
                            DistrictId = atmMachine.DistrictId,
                            DistrictName = district.Name,
                            CityId = atmMachine.CityId,
                            CityName = city.Name,
                        };

            return query.FirstOrDefault();
        }



    }
}
