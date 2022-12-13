using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class ToDoListPanel : ViewComponent
    {
        ToDoListManager todo = new ToDoListManager(new EfToDoListDal());
        
        public IViewComponentResult Invoke()
        {
            var values = todo.TGetList();   
            return View(values);    
        }
    }
}
