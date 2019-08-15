using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using NetBLog.Api.Cache;
using NetBLog.Common;
using System;
using System.IO;
using System.Text;

namespace NetBLog.Api.Aspects
{
    public class CacheAttribute : ActionFilterAttribute
    {
        private bool isCached = false;
        private string key = null;

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            isCached = false;
            var cacheManager = context.GetCacheManager();
            key = GenerateKey(context);

            var result = cacheManager.Get<OkObjectResult>(key);
            if (result != null)
            {
                isCached = true;
                context.Result = result;
            }
        }

        public override void OnResultExecuted(ResultExecutedContext context)
        {
            if (isCached)
                return;

            var cacheManager = context.GetCacheManager();

            var result = context.Result as OkObjectResult;
            if (result != null)
                cacheManager.Set(key, result);
        }

        private string GenerateKey(FilterContext context)
        {
            var request = context.HttpContext.Request;
            request.EnableRewind();
            request.Body.Position = 0;

            using (var reader = new StreamReader(request.Body))
            {
                var builder = new StringBuilder();
                builder.Append(context.RouteData.Values["controller"]);
                builder.Append(context.RouteData.Values["action"]);
                builder.Append(context.HttpContext.Request.Query.ToJson());
                builder.Append(context.HttpContext.User.Identity.Name);

                var requestBody = reader.ReadToEnd().ToJson();
                if (requestBody != null && requestBody != "\"\"")
                    builder.Append(requestBody);

                //TODO: check performance control
                return builder.ToString().ToMD5();
            }
        }
    }
}
