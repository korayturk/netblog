using NetBLog.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetBLog.Repository.Interfaces
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Task<List<Category>> GetForTopMenu(int languageId);
    }
}
