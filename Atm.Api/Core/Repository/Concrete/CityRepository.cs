using Atm.Api.Core.Repository.Abstract;
using Atm.Api.Data.Entities;
using Atm.Api.DataAccess;

namespace Atm.Api.Core.Repository.Concrete
{
    public class CityRepository : BaseRepository<City>, ICityRepository
    {
        public CityRepository(AtmDbContext context) : base(context)
        {
        }
    }
}
