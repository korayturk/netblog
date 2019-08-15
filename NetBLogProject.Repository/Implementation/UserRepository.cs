using Microsoft.EntityFrameworkCore;
using NetBLog.Entity;
using NetBLog.Repository.Interfaces;

namespace NetBLog.Repository.Implementation
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(DbContext context) : base(context)
        {
        }
    }
}
