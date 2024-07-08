using Atm.Api.Core.Repository.Abstract;
using Atm.Api.Data.Entities;
using Atm.Api.Service.Abstract;
using System.Linq.Expressions;

namespace Atm.Api.Service.Concrete
{
    public class AtmService : IAtmService
    {
        private readonly IAtmMachineRepository _atmMachineRepository;

        public AtmService(IAtmMachineRepository atmMachineRepository)
        {
            this._atmMachineRepository = atmMachineRepository;
        }

        public void Add(AtmMachine entity)
        {
             _atmMachineRepository.Add(entity);
        }

        public void Delete(int id)
        {
            Expression<Func<AtmMachine, bool>> filter = atm => atm.Id == id;
            var entity =Get(filter);
            _atmMachineRepository.Delete(entity);

        }

        public AtmMachine Get(Expression<Func<AtmMachine, bool>> filter)
        {
            return _atmMachineRepository.Get(filter);  
        }

        public List<AtmMachine> GetAll(Expression<Func<AtmMachine, bool>> filter = null)
        {
            return _atmMachineRepository.GetAll(filter);
        }

        public void Update(AtmMachine entity)
        {
            var data = _atmMachineRepository.Get(x => x.Id == entity.Id);
            if (data != null)
            {
                data.Adress = entity.Adress;
                data.Name = entity.Name;    
                _atmMachineRepository.SaveChanges();
            }
        }

    }
}
