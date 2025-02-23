using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace MiddlewareShortCircuitExcercise.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class ShortCircuitMiddleware
    {
        private readonly RequestDelegate _next;

        public ShortCircuitMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            if(context.Request.Path=="/short-circuit")
            {
                await context.Response.WriteAsync("short circuited");
            }
            else
            {
                await context.Response.WriteAsync("Normal Request ");
                await _next(context);
            }
           
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    //public static class MiddlewareExtensions
    //{
    //    public static IApplicationBuilder UseMiddleware(this IApplicationBuilder builder)
    //    {
    //        return builder.UseMiddleware<ShortCircuitMiddleware>();
    //    }
    //}
}
