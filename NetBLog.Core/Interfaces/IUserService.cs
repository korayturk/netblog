using NetBLog.Contract;
using System.Threading.Tasks;

namespace NetBLog.Service.Interfaces
{
    public interface IUserService : IServiceBase
    {
        Task<UserContract> Login(string email, string password);
        Task<UserContract> AddUser(UserContract contract);
        Task<UserContract> GetByEmail(string email);
    }
}
