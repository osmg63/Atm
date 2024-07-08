using System.Linq.Expressions;

namespace Atm.Api.Core.Repository.Abstract
{
    public interface IBaseRepository<TEntity>
        where TEntity : class, new()
    {
        void Add(TEntity entity);
        void Delete(TEntity entity);
        TEntity Get(Expression<Func<TEntity, bool>> filter);
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);
        void SaveChanges();
    }
}
