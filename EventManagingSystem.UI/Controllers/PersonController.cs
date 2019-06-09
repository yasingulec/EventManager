using EventManagingSystem.BLL;
using EventManagingSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventManagingSystem.UI.Controllers
{
    public class PersonController : Controller
    {
        PersonManager personManager = new PersonManager();
        // GET: Person
        public ActionResult PersonList()
        {
            List<Person> person = personManager.GetPersons();
            return View(person);
        }
    }
}