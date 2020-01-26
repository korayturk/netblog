using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NetBLog.Service.Interfaces;
using System.Threading.Tasks;

namespace NetBLog.Api.Controllers
{
    public class LanguageController : BaseController
    {
        private readonly ILanguageService _languageService;
        public LanguageController(ILanguageService languageService)
        {
            _languageService = languageService;            
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            return Ok(await _languageService.GetAll());
        }
    }
}