using Microsoft.EntityFrameworkCore;
using NetBLog.Repository.Interfaces;
using NetBLog.Entity.TableOptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace NetBLog.Repository.Implementation
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        //TODO: options to be made
        private readonly DbContext _context;
        public Repository(DbContext context)
        {
            _context = context;
        }

        public T Add(T entity)
        {
            if (entity is IModifiable)
                (entity as IModifiable).CreatedAt = DateTime.Now;

            return _context.Set<T>().Add(entity).Entity;
        }

        public void AddRange(IEnumerable<T> entities)
        {
            var createdAt = DateTime.Now;

            foreach (var item in entities)
                if (item is IModifiable)
                    (item as IModifiable).CreatedAt = createdAt;

            _context.Set<T>().AddRange(entities);
        }

        public void Delete(object id)
        {
            _context.Set<T>().Remove(GetById(id));
        }

        public void Delete(T entity)
        {
            if (entity is ISoftDelete)
            {
                (entity as ISoftDelete).DeletedAt = DateTime.Now;
                Update(entity);
            }
            else
                _context.Set<T>().Remove(entity);
        }

        public void DeleteRange(IEnumerable<T> entities)
        {
            var entity = entities.FirstOrDefault();
            if (entity is ISoftDelete)
            {
                foreach (var item in entities)
                    Delete(item);
            }
            else
                _context.Set<T>().RemoveRange(entities);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().AsNoTracking().Where(expression);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().AsNoTracking().AsEnumerable();
        }

        public T GetById(object id)
        {
            return _context.Set<T>().Find(id);
        }

        public T Update(T entity)
        {
            return _context.Set<T>().Update(entity).Entity;
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
