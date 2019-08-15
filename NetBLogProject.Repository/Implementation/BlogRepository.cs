using Microsoft.EntityFrameworkCore;
using NetBLog.Repository.Interfaces;
using NetBLog.Entity;

namespace NetBLog.Repository.Implementation
{
    public class BlogRepository : Repository<Blog>, IBlogRepository
    {
        public BlogRepository(DbContext context) : base(context)
        {
        }
    }
}
