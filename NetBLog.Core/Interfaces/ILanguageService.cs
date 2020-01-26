using NetBLog.Contract;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetBLog.Service.Interfaces
{
    public interface ILanguageService : IServiceBase
    {
        Task<List<LanguageContract>> GetAll();
    }
}
