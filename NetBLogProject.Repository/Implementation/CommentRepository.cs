using Microsoft.EntityFrameworkCore;
using NetBLog.Entity;
using NetBLog.Repository.Interfaces;

namespace NetBLog.Repository.Implementation
{
    public class CommentRepository : Repository<Comment>, ICommentRepository
    {
        public CommentRepository(DbContext context) : base(context)
        {
        }
    }
}
