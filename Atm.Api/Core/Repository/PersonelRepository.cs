using Atm.Api.Data.Entities;
using Atm.Api.DataAccess;

namespace Atm.Api.Core.Repository
{
    public class PersonelRepository : BaseRepository<Personel>, IPersonelRepository
    {
        public PersonelRepository(AtmDbContext context):base(context)
        {


        }
    }
}
