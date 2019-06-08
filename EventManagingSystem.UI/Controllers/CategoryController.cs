using EventManagingSystem.BLL;
using EventManagingSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventManagingSystem.UI.Controllers
{
    public class CategoryController : Controller
    {
        EventManager events = new EventManager();
        // GET: Category
        public ActionResult CategoryEvents(int id)
        {
            List<Event> CatEvents = events.GetEvents(id);
            return View(CatEvents);
        }
        public ActionResult CategoryList()
        {
            return View();
        }
    }
}