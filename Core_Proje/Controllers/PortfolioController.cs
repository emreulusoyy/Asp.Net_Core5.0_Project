using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
        public IActionResult Index()
        {
            
            var values = portfolioManager.TGetList();
            return View(values);
        }

        public IActionResult DeletePortfolio(int id)
        {
            var values = portfolioManager.TGetByID(id);
            portfolioManager.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditPortfolio(int id)
        {
            var values = portfolioManager.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditPortfolio(Portfolio p)
        {
            portfolioManager.TUpdate(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddPortfolio()
        {
            

           
            return View();
        }

        [HttpPost]
        public IActionResult AddPortfolio(Portfolio p)
        {
            PortfolioValidator validator = new PortfolioValidator();
            ValidationResult result = validator.Validate(p);
            if (result.IsValid)
            {
                portfolioManager.TAdd(p);
                return RedirectToAction("Index");

            }
            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
        }
    }
}
