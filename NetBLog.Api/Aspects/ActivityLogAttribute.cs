using Microsoft.AspNetCore.Mvc.Filters;
using Serilog;
using System;
using System.IO;

namespace NetBLog.Api.Aspects
{
    public class ActivityLogAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            using (StreamReader reader = new StreamReader(context.HttpContext.Request.Body))
            { 
                var username = context.HttpContext.User.Identity.IsAuthenticated ? context.HttpContext.User.Identity.Name : "Anonymous User";

                var logger = (ILogger)context.HttpContext.RequestServices.GetService(typeof(ILogger));
                logger.Information("[{date}] {user} visited to {url}. Query Params: {queryString}. Body Params: {bodyParams}",
                    DateTime.Now, username, context.HttpContext.Request.Path, context.HttpContext.Request.QueryString, reader.ReadToEnd());
            }
            
        }
    }
}
