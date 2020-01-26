using Microsoft.EntityFrameworkCore;
using NetBLog.Repository.Interfaces;
using NetBLog.Entity.TableOptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace NetBLog.Repository.Implementation
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        private readonly DbContext _context;
        public Repository(DbContext context)
        {
            _context = context;
        }

        public async Task<T> Add(T entity)
        {
            if (entity is IModifiable)
                (entity as IModifiable).CreatedAt = DateTime.Now;

            return (await _context.Set<T>().AddAsync(entity)).Entity;
        }

        public async Task AddRange(IEnumerable<T> entities)
        {
            var createdAt = DateTime.Now;

            foreach (var item in entities)
                if (item is IModifiable)
                    (item as IModifiable).CreatedAt = createdAt;

            await _context.Set<T>().AddRangeAsync(entities);
        }

        public async Task Delete(object id)
        {
            var entity = await GetById(id);
            await Task.Run(() => _context.Set<T>().Remove(entity));
        }

        public async Task Delete(T entity)
        {
            if (entity is ISoftDelete)
            {
                (entity as ISoftDelete).DeletedAt = DateTime.Now;
                await Update(entity);
            }
            else
                await Task.Run(() => _context.Set<T>().Remove(entity));
        }

        public async Task DeleteRange(IEnumerable<T> entities)
        {
            var entity = entities.FirstOrDefault();
            if (entity is ISoftDelete)
            {
                foreach (var item in entities)
                    await Delete(item);
            }
            else
                await Task.Run(() => _context.Set<T>().RemoveRange(entities));
        }

        public async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> expression)
        {
            return await Task.FromResult(_context.Set<T>().AsNoTracking().Where(expression));
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await Task.FromResult(_context.Set<T>().AsNoTracking().AsEnumerable());
        }

        public async Task<T> GetById(object id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<T> Update(T entity)
        {
            return await Task.FromResult(_context.Set<T>().Update(entity).Entity);
        }

        public async Task<int> SaveChanges()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
