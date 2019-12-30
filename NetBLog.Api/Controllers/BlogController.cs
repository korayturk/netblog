using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NetBLog.Api.Aspects;
using NetBLog.Api.Validators;
using NetBLog.Contract;
using NetBLog.Service.Interfaces;

namespace NetBLog.Api.Controllers
{
    public class BlogController : BaseController
    {
        private readonly IBlogService _blogService;
        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        [HttpGet]
        [AllowAnonymous]
        [Cache]
        public IActionResult Index(DataFilterContract contract)
        {
            return Ok(_blogService.List(contract));
        }

        [HttpPut]
        [Authorize(Roles = "Admin,Writer")]
        [ActivityLog]
        [ParameterValidator(typeof(BlogValidator))]
        public IActionResult Add(BlogContract contract)
        {
            return Ok(_blogService.Add(contract));
        }
    }
}