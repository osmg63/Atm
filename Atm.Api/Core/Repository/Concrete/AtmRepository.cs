using Atm.Api.Core.Repository.Abstract;
using Atm.Api.Data.Entities;
using Atm.Api.DataAccess;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Atm.Api.Core.Repository.Concrete
{
    public class AtmRepository : BaseRepository<AtmMachine>, IAtmMachineRepository
    {
        public AtmRepository(AtmDbContext context) : base(context)
        {
          

        }
       

    }
}
