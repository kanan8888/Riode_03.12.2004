using Microsoft.EntityFrameworkCore;
using WebApp_Riode_03._12._2024.Models;

namespace WebApp_Riode_03._12._2024.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }





    }
}
