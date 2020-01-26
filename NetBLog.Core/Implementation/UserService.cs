using AutoMapper;
using Microsoft.Extensions.Configuration;
using NetBLog.Common;
using NetBLog.Contract;
using NetBLog.Contract.Exceptions;
using NetBLog.Entity;
using NetBLog.Repository.Interfaces;
using NetBLog.Resources;
using NetBLog.Service.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace NetBLog.Service.Implementation
{
    public class UserService : ServiceBase, IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IConfiguration _configuration;
        public UserService(IMapper mapper, IConfiguration configuration, IUserRepository userRepository) : base(mapper)
        {
            _configuration = configuration;
            _userRepository = userRepository;
        }

        public async Task<UserContract> AddUser(UserContract contract)
        {
            var user = Mapper.Map<User>(contract);
            user.Salt = Guid.NewGuid().ToString();
            user.Password = $"{contract.Password}{user.Salt}".ToMD5();

            var newUser = Mapper.Map<UserContract>(await _userRepository.Add(user));
            newUser.Password = string.Empty;

            return newUser;
        }

        public async Task<UserContract> GetByEmail(string email)
        {
            var user = (await _userRepository.Find(x => x.Email == email && x.DeletedAt == null)).FirstOrDefault();
            return Mapper.Map<UserContract>(user);
        }

        public async Task<UserContract> Login(string email, string password)
        {
            var user = (await _userRepository.Find(x => x.Email == email && x.DeletedAt == null)).FirstOrDefault();

            if (user == null || user.Password != $"{password}{user.Salt}".ToMD5())
                throw new UserNotFoundException(SystemMessages.UserNotFoundMessage);

            return Mapper.Map<UserContract>(user);
        }
    }
}
