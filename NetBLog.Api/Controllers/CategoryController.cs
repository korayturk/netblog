using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NetBLog.Service.Interfaces;
using System.Threading.Tasks;

namespace NetBLog.Api.Controllers
{
    public class CategoryController : BaseController
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return Ok(await _categoryService.GetForTopMenu(HeaderLanguage));
        }
    }
}