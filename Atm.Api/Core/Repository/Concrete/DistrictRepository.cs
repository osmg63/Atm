using Atm.Api.Core.Repository.Abstract;
using Atm.Api.Data.Entities;
using Atm.Api.DataAccess;

namespace Atm.Api.Core.Repository.Concrete
{
    public class DistrictRepository : BaseRepository<District>, IDistrictRepository
    {
        public DistrictRepository(AtmDbContext context) : base(context)
        {
        }
    }
}
