using EventManagingSystem.BLL;
using EventManagingSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventManagingSystem.UI.Controllers
{
    public class ProfileController : Controller
    {
        PersonManager personManager = new PersonManager();
        // GET: Profile
        [HttpGet]
        public ActionResult MyProfile()
        {
            Person person = (Person)Session["Login"];
            var per = personManager.GetPerson(person.PersonID);
            return View(per);
        }
        [HttpPost]
        public ActionResult MyProfile(Person _person)
        {
            personManager.UpdateProfile(_person);
            return View();
        }
    }
}