using MiddlewareShortCircuitExcercise.Middleware;

namespace MiddlewareShortCircuitExcercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
           
            var app = builder.Build();

            app.UseMiddleware<ShortCircuitMiddleware>();

            //app.MapGet("/", () => "Hello World!");

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello Response");
            });

            app.Run();
        }
    }
}
