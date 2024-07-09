using Atm.Api.Data.DTOs;
using Atm.Api.Data.Entities;
using System.Linq.Expressions;

namespace Atm.Api.Service.Abstract
{
    public interface IDistrictService
    {
        DistrictDto Get(int id);
        List<DistrictDto> GetAll();
    }
}
