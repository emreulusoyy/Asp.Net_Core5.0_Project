using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "Dashboard";
            ViewBag.v1 = "İstatistikler";
            ViewBag.v1 = "İstatistik Sayfası";
            return View();
        }
    }
}
