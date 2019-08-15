using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Threading.Tasks;

namespace NetBLog.Api.Middleware
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        public ErrorHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                var code = (int)HttpStatusCode.InternalServerError;

                context.Response.ContentType = "application/json";
                context.Response.StatusCode = code;

                var result = JsonConvert.SerializeObject(new
                {
                    statusCode = code,
                    errorMessage = ex.Message
                });
                await context.Response.WriteAsync(result);
            }
        }
    }
}
