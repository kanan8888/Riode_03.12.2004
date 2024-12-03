using Microsoft.AspNetCore.Mvc;

namespace WebApp_Riode_03._12._2024.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
