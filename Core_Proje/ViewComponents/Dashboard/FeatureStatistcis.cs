using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class FeatureStatistcis : ViewComponent
    {

        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Skills.Count();
            ViewBag.v2 = c.Messages.Where(x => x.Status == false).Count(); //okunmamış mesaj sayısı
            ViewBag.v3 = c.Messages.Where(x => x.Status == true).Count(); //okunmuş mesaj sayısı
            ViewBag.v4 = c.Experiences.Count(); // Deneyim sayısı
            return View();
        }

    }
}
