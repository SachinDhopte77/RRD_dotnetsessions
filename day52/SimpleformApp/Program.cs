namespace SimpleformApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            app.UseStaticFiles();
            app.MapControllerRoute(
                 name: "default",
                 pattern: "{controller=Customer}/{action=Register}/{id?}"
                );

            //  app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
