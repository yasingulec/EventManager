using EventManagingSystem.BLL;
using EventManagingSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventManagingSystem.UI.Controllers
{
    public class JoinController : Controller
    {
        PersonEventManager eventManager = new PersonEventManager();
        // GET: Join
        [HttpGet]
        public ActionResult JoinEvent(int id)
        {
            Session["EventID"] = id;
            return View();
        }
        [HttpPost]
        public ActionResult JoinEvent(EventPerson eventPerson)
        {
            Person per =(Person) Session["Login"];
            eventPerson.PersonID = per.PersonID;
            eventPerson.EventID = (int)Session["EventID"];
            eventPerson.TotalPerson = eventPerson.TotalPerson + 1;
            eventManager.Join(eventPerson);
            return View();
        }
    }
}