using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

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
    }
}
