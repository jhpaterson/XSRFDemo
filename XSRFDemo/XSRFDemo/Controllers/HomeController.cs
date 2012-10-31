using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XSRFDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string username)
        {
            ViewBag.Message = "XSS Demo";
            ViewBag.UserName = username;

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        // Use AccountController for XSRF and open redirection, account jim/Pa$$w0rd
    }
}
