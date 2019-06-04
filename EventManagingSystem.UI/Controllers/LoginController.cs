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
    public class LoginController : Controller
    {
        PersonManager personManager = new PersonManager();
        // GET: Login
        [HttpGet]
        public ActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signup(Person person)
        {
            personManager.Register(person);
            return RedirectToAction("Signin");
        }
        [HttpGet]
        public ActionResult Signin()
        {
            return View();
        }
        [LogFilter]
        [HttpPost]
        public ActionResult Signin(Person person)
        {
           Person per= personManager.GetPerson(person);
            if (per!=null)
            {
                Session["Login"] = per;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("LoginHata");
            }      
        }
    
        public ActionResult LoginHata()
        {
            return View();
        }
        public ActionResult Logout()
        {
            Session.Remove("Login");
            return RedirectToAction("Signin");
        }
    }
}