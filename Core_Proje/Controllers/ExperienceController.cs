using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Core_Proje.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Deneyim Listesi";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyimler Listesi";
            var values = experienceManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddExperience()
        {
            ViewBag.v1 = "Deneyim Ekleme";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyim Ekleme";
            return View();
        }

        [HttpPost]
        public IActionResult AddExperience(Experience p)
        {
            
            experienceManager.TAdd(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditExperience(int id)
        {
            var values = experienceManager.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditExperience(Experience p)
        {
            ViewBag.v1 = "Deneyim Güncelleme";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyim Güncelleme";
            experienceManager.TUpdate(p);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteExperience(int id)
        {
            var values = experienceManager.TGetByID(id);    
            experienceManager.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
