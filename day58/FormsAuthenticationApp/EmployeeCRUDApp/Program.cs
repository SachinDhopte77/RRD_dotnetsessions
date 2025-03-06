using EmployeeCRUDApp.Services;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace EmployeeCRUDApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options => {
                    options.Cookie.Name = "myrrdformcookie";
                    options.LoginPath = "/Login/Index";

                });
            builder.Services.AddControllersWithViews();
            builder.Services.AddSingleton<IEmployeeService, EmployeeInMemoryService>();
           // builder.Services.AddSingleton<IEmployeeService, EmployeeSqlClientService>();
            var app = builder.Build();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseStaticFiles();
            app.MapControllerRoute(
                name:"default",
                pattern: "{controller=Employee}/{action=DisplayAll}/{id?}"
                );
            //app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
