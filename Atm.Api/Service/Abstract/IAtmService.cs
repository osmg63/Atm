using Atm.Api.Data.DTOs;
using Atm.Api.Data.DynamicPagination;
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
        Task<IList<AtmMachineDto>> GetOrdersView(FilterDTO filter);
        AtmMachineDto GetById(int id);
        List<AtmMachineDto> GetAllWithCityAndDistrictName();
        Task<PaginatedList<AtmMachineDto>> PaginationAsync(PagedRequest request);


    }
}
