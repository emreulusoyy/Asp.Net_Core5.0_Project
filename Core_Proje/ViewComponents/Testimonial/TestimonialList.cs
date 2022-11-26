using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Testimonial
{
    public class TestimonialList : ViewComponent
    {
        TestimonialManager manager = new TestimonialManager(new EfTestimonialDal()); 
        public IViewComponentResult Invoke()
        {
            var values = manager.TGetList();
            return View(values);
        }
    }
}
