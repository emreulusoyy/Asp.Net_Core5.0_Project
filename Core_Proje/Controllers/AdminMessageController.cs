using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Core_Proje.Controllers
{
    public class AdminMessageController : Controller
    {
        WriterMessageManager writermessagemanager = new WriterMessageManager(new EfWriterMessageDal());
        public IActionResult ReciverMessageList()
        {
            string p;
            p = "admin@gmail.com";
            var values = writermessagemanager.GetListReciverMessage(p);
            return View(values);
        }

        public IActionResult SenderMessageList()
        {
            string p;
            p = "admin@gmail.com";
            var values = writermessagemanager.GetListSendMessage(p);
            return View(values);
        }

        public IActionResult AdminMessageDetails(int id)
        {
            var values = writermessagemanager.TGetByID(id);
            return View(values);
        }
        public IActionResult AdminMessageDelete(int id)
        {
            var values = writermessagemanager.TGetByID(id);
            writermessagemanager.TDelete(values);
            return RedirectToAction("SenderMessageList");
        }
        [HttpGet]
        public IActionResult AdminMessageSend()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AdminMessageSend(WriterMessage p)
        {
            p.Sender = "admin@gmail.com";
            p.SenderName = "Admin";
            p.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            Context c = new Context();
            var usernamesurname = c.Users.Where(x => x.Mail == p.Reciver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            p.ReciverName = usernamesurname;
            writermessagemanager.TAdd(p);
            return RedirectToAction("SenderMessageList");
        }
    }
}
