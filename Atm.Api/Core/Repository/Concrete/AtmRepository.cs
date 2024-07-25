using Atm.Api.Core.Repository.Abstract;
using Atm.Api.Data;
using Atm.Api.Data.DTOs;
using Atm.Api.Data.DynamicPagination;
using Atm.Api.Data.Entities;
using AutoMapper.QueryableExtensions;
using Atm.Api.Data.Filters;
using Atm.Api.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Numerics;
using AutoMapper;

namespace Atm.Api.Core.Repository.Concrete
{
    public class AtmRepository : BaseRepository<AtmMachine>, IAtmMachineRepository
    {
        private readonly AtmDbContext _context;
        private readonly IMapper _mapper;
        public AtmRepository(AtmDbContext context,IMapper myMapper) : base(context)
        {
            _mapper = myMapper;
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
                            IsActive= atmMachine.IsActive,
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
                            IsActive= atmMachine.IsActive,
                            DistrictId = atmMachine.DistrictId,
                            DistrictName = district.Name,
                            CityId = atmMachine.CityId,
                            CityName = city.Name,
                        };

            return query.FirstOrDefault();
        }

        public IQueryable<AtmMachineDto> GetFilteredPagination()
        {
            var query = from atmMachine in _context.AtmMachines
                        join city in _context.Cities on atmMachine.CityId equals city.Id
                        join district in _context.Districts on atmMachine.DistrictId equals district.Id
                        select new AtmMachineDto
                        {
                            Id = atmMachine.Id,
                            Name = atmMachine.Name,
                            Latitude = atmMachine.Latitude,
                            Longitude = atmMachine.Longitude,
                            Adress = atmMachine.Adress,
                            IsActive = atmMachine.IsActive,
                            DistrictId = atmMachine.DistrictId,
                            DistrictName = district.Name,
                            CityId = atmMachine.CityId,
                            CityName = city.Name,
                        };


            return query;
        }
        
        public async Task<IList<AtmMachineDto>> GetOrdersView(FilterDTO filter)
        {
            //define the base query
            var ordersQuery = _context
                .AtmMachines
                .ProjectTo<AtmMachineDto>(_mapper.ConfigurationProvider);
            // apply the sort and filter
            ordersQuery = ordersQuery.ToFilterView(filter);
            // return the result
            return await ordersQuery.ToListAsync();
        }



    }
}
