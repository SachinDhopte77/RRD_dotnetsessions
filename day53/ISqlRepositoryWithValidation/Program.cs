using ISqlRepositoryWithValidation.Data;
using Microsoft.EntityFrameworkCore;

namespace ISqlRepositoryWithValidation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            //builder.Services.AddDbContext<ApplicationDbContext>(Options =>
            //{
            //    Options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            //});
           
            var app = builder.Build();
            app.UseStaticFiles();

            //  app.MapDefaultControllerRoute();
            app.MapControllerRoute(name: "default",
    pattern: "{controller=Home}/{action=Index}/{myid?}"

 );

            // app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
