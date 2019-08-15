using NetBLog.Contract;
using System.Collections.Generic;

namespace NetBLog.Service.Interfaces
{
    public interface ICommentService
    {
        CommentContract Add(CommentContract contract);
        IEnumerable<CommentContract> GetByBlogId(int blogId);
        void Delete(int id);
    }
}
