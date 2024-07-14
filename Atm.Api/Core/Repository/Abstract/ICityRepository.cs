using Atm.Api.Data.DTOs;
using Atm.Api.Data.Entities;

namespace Atm.Api.Core.Repository.Abstract
{
    public interface ICityRepository:IBaseRepository<City>
    {
        List<AtmDtoForCityResponse> GetAtmsWithCityId(int cityId);
        List<DistrictDtoResponse> GetDistrictByCityId(int cityId);



    }
}
