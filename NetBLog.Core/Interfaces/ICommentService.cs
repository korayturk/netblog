using NetBLog.Contract;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetBLog.Service.Interfaces
{
    public interface ICommentService : IServiceBase
    {
        Task<CommentContract> Add(CommentContract contract);
        Task<IEnumerable<CommentContract>> GetByBlogId(int blogId);
        Task Delete(int id);
    }
}
