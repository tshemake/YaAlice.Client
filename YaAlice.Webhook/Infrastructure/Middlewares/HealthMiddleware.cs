using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Net.Http.Headers;

namespace YaAlice.Webhook.Infrastructure.Middlewares
{
    public class HealthMiddleware
    {
        private readonly RequestDelegate _next;

        public HealthMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            httpContext.Response.ContentType = "text/plain";
            httpContext.Response.StatusCode = StatusCodes.Status204NoContent;
            httpContext.Response.Headers.Add(HeaderNames.Connection, "close");
            await Task.CompletedTask;
        }
    }

    public static class HealthMiddlewareExtensions
    {
        // ReSharper disable once UnusedMethodReturnValue.Global
        public static IApplicationBuilder UseHealthMiddleware(this IApplicationBuilder builder, string path = "/health")
        {
            return builder.Map(path, subApp => subApp.UseMiddleware<HealthMiddleware>());
        }
    }
}
