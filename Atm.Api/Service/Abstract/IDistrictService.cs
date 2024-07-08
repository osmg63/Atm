using Atm.Api.Data.Entities;
using System.Linq.Expressions;

namespace Atm.Api.Service.Abstract
{
    public interface IDistrictService
    {
        District Get(Expression<Func<District, bool>> filter);
        List<District> GetAll(Expression<Func<District, bool>> filter = null);
    }
}
