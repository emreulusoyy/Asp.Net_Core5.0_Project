using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Core_Proje.Areas.Writers.Controllers
{
    [Area("Writers")]
    [AllowAnonymous]

    public class DashboardController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public DashboardController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name); //Giriş yapan kullanıcı ismini bul
            ViewBag.v = values.Name + " " + values.Surname;

            //Weather APi
            //string api = "14ad2aba611dbef9c504b82a127794c5";
            //string connection = "http://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + api;
            //XDocument document = XDocument.Load(connection);
            //ViewBag.v5 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;

            //statistics
            Context cm= new Context();
            ViewBag.v1 = cm.writerMessages.Where(x=>x.Reciver==values.Email).Count();   
            ViewBag.v2 = cm.Announcements.Count();
            ViewBag.v3 = cm.Users.Count();
            ViewBag.v4 = cm.Skills.Count();
            return View();
        }
    }
}
