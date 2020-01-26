using NetBLog.Contract;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetBLog.Service.Interfaces
{
    public interface IBlogService : IServiceBase
    {
        Task<IEnumerable<BlogContract>> List(DataFilterContract contract);
        Task<BlogContract> Add(BlogContract contract);
    }
}
