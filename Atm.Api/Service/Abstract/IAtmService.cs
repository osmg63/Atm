using Atm.Api.Data.DTOs;
using Atm.Api.Data.Entities;
using Atm.Api.Data.Filters;
using System.Linq.Expressions;

namespace Atm.Api.Service.Abstract
{
    public interface IAtmService
    {
        AtmMachineDto Add(CreateAtmMachineDto entity);
        void Delete(int id);
        AtmMachineDto Get(int id);
        List<AtmMachineDto> GetAll();
        void Update(UpdateAtmMachineDto entity);
        Task<PaginatedResult<AtmMachineDto>> GetPaginationView(FilterDTO filter);
        AtmMachineDto GetById(int id);
        List<AtmMachineDto> GetAllWithCityAndDistrictName();


    }
}
