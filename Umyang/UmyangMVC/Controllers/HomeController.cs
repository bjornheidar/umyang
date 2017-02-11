using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UmyangMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: about
        public ActionResult About()
        {
            return View();
        }

        // GET: Home
        public ActionResult Whatis()
        {
            return View();
        }
    }
}