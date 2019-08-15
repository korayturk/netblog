using NetBLog.Contract;
using System.Collections.Generic;

namespace NetBLog.Service.Interfaces
{
    public interface IBlogService
    {
        IEnumerable<BlogContract> List(DataFilterContract contract);
        BlogContract Add(BlogContract contract);
    }
}
