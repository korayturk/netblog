using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NetBLog.Contract;
using NetBLog.Service.Interfaces;

namespace NetBLog.Api.Controllers
{
    public class TestController : BaseController
    {
        private readonly IUserService _userService;
        public TestController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            var email = "korayturkk@gmail.com";
            var user = _userService.GetByEmail(email);

            if (user == null)
            {
                user = _userService.AddUser(new UserContract
                {
                    Email = email,
                    Name = "Koray",
                    Surname = "Türk",
                    Password = "123456",
                    Role = "asdf"
                });
            }

            return Ok("Test is available");
        }

        [HttpPost]
        [Route("auth")]
        [Authorize]
        public IActionResult Auth()
        {
            return Ok($"{User.Identity.Name}, Test is OK!");
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("noauth")]
        public IActionResult NoAuth()
        {
            return Ok("Test is OK!");
        }
    }
}