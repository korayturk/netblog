using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace NetBLog.Repository.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class, new()
    {
        Task<TEntity> Add(TEntity entity);
        Task AddRange(IEnumerable<TEntity> entities);
        Task<TEntity> Update(TEntity entity);
        Task<TEntity> GetById(object id);
        Task<IEnumerable<TEntity>> GetAll();
        Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> expression);
        Task Delete(object id);
        Task Delete(TEntity entity);
        Task DeleteRange(IEnumerable<TEntity> entities);
        Task<int> SaveChanges();
    }
}
