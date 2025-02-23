using Microsoft.AspNetCore.Http;

namespace MiddlewareExcercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.Use(LoggingMiddleware);

            app.Map("/Hello", (appbuilder) =>
            {
                appbuilder.Run(async (context) =>
                {
                    await context.Response.WriteAsync("<h1>Hello Login successful!!</h1>\n");
                });

            });
           

            app.Use(AuthenticationMiddleware);
           
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Middleware3: Catching result\n");
              

            });
            

            app.Run();

        }
        private static async Task LoggingMiddleware(HttpContext context,Func<Task> next)
        {
            
            await context.Response.WriteAsync("Getting Login Detail from First Middleware\n");
            await next();
            await context.Response.WriteAsync("ougoing Login response Detail from First Middleware\n");
        }
        private static async Task AuthenticationMiddleware(HttpContext context, Func<Task> next)
        {
          
            await context.Response.WriteAsync("Login Authenticated in second middleware\n");
            await next();
            await context.Response.WriteAsync("ougoing authentication response Detail from Second Middleware\n");
        }

    }
}
