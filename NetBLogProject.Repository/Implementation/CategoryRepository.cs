using Microsoft.EntityFrameworkCore;
using NetBLog.Repository.Interfaces;
using NetBLog.Entity;

namespace NetBLog.Repository.Implementation
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(DbContext context) : base(context)
        {
        }
    }
}
