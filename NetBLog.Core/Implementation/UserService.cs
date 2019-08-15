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

namespace NetBLog.Service.Implementation
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        private readonly IConfiguration _configuration;
        public UserService(IMapper mapper, IConfiguration configuration, IUserRepository userRepository)
        {
            _mapper = mapper;
            _configuration = configuration;
            _userRepository = userRepository;
        }

        public UserContract AddUser(UserContract contract)
        {
            var user = _mapper.Map<User>(contract);
            user.Salt = Guid.NewGuid().ToString();
            user.Password = $"{contract.Password}{user.Salt}".ToMD5();

            var newUser = _mapper.Map<UserContract>(_userRepository.Add(user));
            newUser.Password = string.Empty;

            return newUser;
        }

        public UserContract GetByEmail(string email)
        {
            var user = _userRepository.Find(x => x.Email == email && x.DeletedAt == null).FirstOrDefault();
            return _mapper.Map<UserContract>(user);
        }

        public UserContract Login(string email, string password)
        {
            var user = _userRepository.Find(x => x.Email == email && x.DeletedAt == null).FirstOrDefault();

            if (user == null || user.Password != $"{password}{user.Salt}".ToMD5())
                throw new UserNotFoundException(SystemMessages.UserNotFoundMessage);

            return _mapper.Map<UserContract>(user);
        }
    }
}
