using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Areas.Writers.Controllers
{
    [Area("Writers")]
    public class RegisterController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string p)
        {
            return View();
        }
    }
}
