using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using NetBLog.Api.Aspects;
using NetBLog.Api.Validators;
using NetBLog.Contract;
using NetBLog.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace NetBLog.Api.Controllers
{
    public class UserController : BaseController
    {
        private readonly IUserService _userService;
        private readonly IConfiguration _configuration;
        public UserController(IUserService userService, IConfiguration configuration)
        {
            _userService = userService;
            _configuration = configuration;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("Login")]
        [ParameterValidator(typeof(LoginValidator))]
        public async Task<IActionResult> Login(LoginContract contract)
        {
            var user = await _userService.Login(contract.Email, contract.Password);
            var token = CreateToken(user);
            return Ok(token);
        }

        private string CreateToken(UserContract user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            var securityKey = _configuration.GetSection("AppSettings:Secret").Value;
            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));

            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256Signature);

            var claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.NameIdentifier, user.Email));
            claims.Add(new Claim(ClaimTypes.Name, user.Name));
            claims.Add(new Claim(ClaimTypes.Surname, user.Surname));
            claims.Add(new Claim(ClaimTypes.Email, user.Email));
            if (!string.IsNullOrEmpty(user.Role))
            {
                foreach (var item in user.Role.Split(','))
                {
                    claims.Add(new Claim(ClaimTypes.Role, item.Trim()));
                }
            }
            claims.Add(new Claim("Id", user.Id.ToString()));

            var token = new JwtSecurityToken(
                issuer: _configuration.GetSection("AppSettings:Issuer").Value,
                audience: _configuration.GetSection("AppSettings:Audience").Value,
                expires: DateTime.Now.AddHours(int.Parse(_configuration.GetSection("AppSettings:TokenExpiresHour").Value)),
                signingCredentials: signingCredentials,
                claims: claims
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}