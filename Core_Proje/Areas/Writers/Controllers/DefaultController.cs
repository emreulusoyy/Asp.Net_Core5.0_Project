using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Areas.Writers.Controllers
{
    [Area("Writers")]
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
