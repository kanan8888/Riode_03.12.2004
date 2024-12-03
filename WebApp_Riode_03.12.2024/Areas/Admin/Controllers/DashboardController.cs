using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp_Riode_03._12._2024.DAL;


namespace WebApp_26bovember.Areas.AdminPanel.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {

        AppDbContext _db;
        public DashboardController(AppDbContext db)
        {
            _db = db;
        }

 
        public IActionResult Index()
        {
            return View();
        }





    }
}