using Atm.Api.Data.DTOs;
using Atm.Api.Data.Entities;
using Atm.Api.Data.Filters;

namespace Atm.Api.Core.Repository.Abstract
{
    public interface IAtmMachineRepository:IBaseRepository<AtmMachine>
    {
        AtmMachineDto GetById(int id);
        List<AtmMachineDto> GetAllWithCityAndDistrictName();
        Task<PaginatedResult<AtmMachineDto>> GetPaginationView(FilterDTO filter);
    }
}
