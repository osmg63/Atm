using Atm.Api.Data.DTOs;
using Atm.Api.Data.Entities;
using System.Linq.Expressions;

namespace Atm.Api.Service.Abstract
{
    public interface ICityService
    {
        
        CityDto Get(int id);
        List<CityDto> GetAll();
        List<DistrictDto> GetByCityId(int cityId);
    }
}
