using Atm.Api.Data.DTOs;
using Atm.Api.Data.DynamicPagination;
using Atm.Api.Data.Entities;
using Atm.Api.Data.Filters;

namespace Atm.Api.Core.Repository.Abstract
{
    public interface IAtmMachineRepository:IBaseRepository<AtmMachine>
    {
        AtmMachineDto GetById(int id);
        List<AtmMachineDto> GetAllWithCityAndDistrictName();
        Task<IList<AtmMachineDto>> GetOrdersView(FilterDTO filter);
        public IQueryable<AtmMachineDto> GetFilteredPagination();
    }
}
