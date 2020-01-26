using Microsoft.EntityFrameworkCore;
using NetBLog.Entity;

namespace NetBLog.Data
{

    public class NetBLogDbContext : DbContext
    {
        public NetBLogDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Blog> Blog { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Language> Language { get; set; }
    }    
}
