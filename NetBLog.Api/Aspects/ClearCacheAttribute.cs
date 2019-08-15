using Microsoft.AspNetCore.Mvc.Filters;

namespace NetBLog.Api.Aspects
{
    public class ClearCacheAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            var cacheManager = context.GetCacheManager();
            cacheManager.ClearCache();
        }
    }
}
