using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NetBLog.Api.Filters;

namespace NetBLog.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    [TypeFilter(typeof(TransactionManagerFilter))]
    public class BaseController : ControllerBase
    {
    }
}