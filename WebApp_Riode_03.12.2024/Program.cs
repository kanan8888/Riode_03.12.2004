using Microsoft.EntityFrameworkCore;
using WebApp_Riode_03._12._2024.DAL;

namespace WebApp_Riode_03._12._2024
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(opt=>opt.UseSqlServer("server=DESKTOP-GTVND9D;database=RiodeDb;Trusted_connection=true;Encrypt=false"));

            var app = builder.Build();


            app.MapControllerRoute(
                name: "areas",
                pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
                );

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}"
                );

            app.UseStaticFiles();

            app.Run();
        }
    }
}
