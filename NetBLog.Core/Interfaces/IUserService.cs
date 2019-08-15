using NetBLog.Contract;

namespace NetBLog.Service.Interfaces
{
    public interface IUserService
    {
        UserContract Login(string email, string password);
        UserContract AddUser(UserContract contract);
        UserContract GetByEmail(string email);
    }
}
