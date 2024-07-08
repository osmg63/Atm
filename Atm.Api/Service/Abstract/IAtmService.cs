using Atm.Api.Data.Entities;
using System.Linq.Expressions;

namespace Atm.Api.Service.Abstract
{
    public interface IAtmService
    {
        void Add(AtmMachine entity);
        void Delete(int id);
        AtmMachine Get(Expression<Func<AtmMachine, bool>> filter);
        List<AtmMachine> GetAll(Expression<Func<AtmMachine, bool>> filter = null);
        void Update(AtmMachine entity);

    }
}
