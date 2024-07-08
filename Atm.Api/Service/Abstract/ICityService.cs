using Atm.Api.Data.Entities;
using System.Linq.Expressions;

namespace Atm.Api.Service.Abstract
{
    public interface ICityService
    {
        
        City Get(Expression<Func<City, bool>> filter);
        List<City> GetAll(Expression<Func<City, bool>> filter = null);
    }
}
