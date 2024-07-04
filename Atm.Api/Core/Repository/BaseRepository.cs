using Atm.Api.Data.Entities;
using Atm.Api.DataAccess;
using System.Linq.Expressions;
using System.Security.Principal;

namespace Atm.Api.Core.Repository
{
    
    public class BaseRepository<TEntity>
          where TEntity : class, new()
    {
        private readonly AtmDbContext _context;
        public BaseRepository(AtmDbContext context)
        {
            _context = context; 
        }
        public void Add(TEntity entity)
        {
            
            
                _context.Set<TEntity>().Add(entity);
                _context.SaveChanges();
           
        }

        public void Delete(TEntity entity)
        {
          
            
                _context.Set<TEntity>().Remove(entity);
                _context.SaveChanges();
            
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            
            
                return _context.Set<TEntity>().SingleOrDefault(filter);
            
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
           
            
                return filter == null ? _context.Set<TEntity>().ToList() :
                    _context.Set<TEntity>().Where(filter).ToList();

            
        }

        public void Update(TEntity entity)
        {
            
            
                _context.Set<TEntity>().Update(entity);
                _context.SaveChanges();
            
        }

        public void UpdateById(TEntity entity,int id)
        {
           
            
                TEntity entity1 = _context.Set<TEntity>().Find(id);
                if (entity1 != null)
                {
                    
                    _context.Entry(entity1).CurrentValues.SetValues(entity);
                    _context.SaveChanges();
                }
               
            
        }

    }
}
