using EventManagingSystem.BLL;
using EventManagingSystem.Entities;
using EventManagingSystem.UI.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventManagingSystem.UI.Controllers
{
    public class EventController : Controller
    {
        EventManager eventManager = new EventManager();
        // GET: Event
        [MyAuthenticationFilter,LogFilter]
        [HttpGet]
        public ActionResult AddEvent()
        {
            return View(new Event());
        }
        [HttpPost]
        public ActionResult AddEvent(Event events)
        {
            Person person = (Person)Session["Login"];
            events.PersonID = person.PersonID;
            events.CreatedDate = DateTime.Now;
            eventManager.AddEvent(events);
            return RedirectToAction("Index","Home");
        }
        public ActionResult DeleteEvent(int id)
        {
            eventManager.DeleteEvent(id);
            return View();
        }
        [MyAuthenticationFilter,LogFilter]
        public ActionResult ListDetails(int id)
        {
            Event eventt = eventManager.GetEvent(id);
            return View(eventt);
        }
    }
}