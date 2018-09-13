using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ACWeb.Controllers
{
    public class MainController : Controller
    {
        [Route("Home")]
        public ActionResult Home()
        {
            return View();
        }

        [Route("Services")]
        public ActionResult Services()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}