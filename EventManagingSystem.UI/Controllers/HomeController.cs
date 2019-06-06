using EventManagingSystem.UI.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventManagingSystem.UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [MyAuthenticationFilter,LogFilter]
        public ActionResult Index()
        {
            return View();
        }
    }
}