using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Areas.Writers.Controllers
{
    public class MessageController : Controller
    {
        [Area("Writers")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
