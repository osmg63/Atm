using Atm.Api.Core.Repository.Abstract;
using Atm.Api.Data.DTOs;
using Atm.Api.Data.Entities;
using Atm.Api.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace Atm.Api.Core.Repository.Concrete
{
    public class CityRepository : BaseRepository<City>, ICityRepository
    {
        private readonly AtmDbContext _context;
        public CityRepository(AtmDbContext context) : base(context)
        {
            _context = context;
        }

   

       
        public List<AtmDtoForCityResponse> GetAtmsWithCityId(int cityId)
        {
            var query = from atmMachine in _context.AtmMachines
                        join city in _context.Cities on atmMachine.CityId equals city.Id
                        join district in _context.Districts on atmMachine.DistrictId equals district.Id
                        where atmMachine.CityId == cityId
                        select new AtmDtoForCityResponse
                        {
                            Id = atmMachine.Id,
                            Name = atmMachine.Name,
                            CityId = atmMachine.CityId,
                            CityName = city.Name,
                            Adress= atmMachine.Adress,
                            IsActive = atmMachine.IsActive,
                            Longitude= atmMachine.Longitude,
                            Latitude= atmMachine.Latitude,
                            DistrictId= atmMachine.DistrictId,
                            DistrictName=district.Name,

                        };

            return query.ToList();
        }



        public List<DistrictDtoResponse> GetDistrictByCityId(int cityId)
        {

            var query = from district in _context.Districts
                        join city in _context.Cities on district.CityId equals city.Id
                        where district.CityId == cityId
                        select new DistrictDtoResponse
                        {
                            Id = district.Id,
                            Name = district.Name,
                            CityId = district.CityId,
                            CityName = city.Name,

                        };

            return query.ToList();



        }

    }
}
