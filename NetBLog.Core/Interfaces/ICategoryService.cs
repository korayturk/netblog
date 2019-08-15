using NetBLog.Contract;
using System.Collections.Generic;

namespace NetBLog.Service.Interfaces
{
    public interface ICategoryService
    {
        IEnumerable<CategoryContract> GetAll();
    }
}
