using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace NetBLog.Repository.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class, new()
    {
        TEntity Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        TEntity Update(TEntity entity);
        TEntity GetById(object id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> expression);
        void Delete(object id);
        void Delete(TEntity entity);
        void DeleteRange(IEnumerable<TEntity> entities);
        int SaveChanges();
    }
}
