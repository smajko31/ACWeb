using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ACWeb.Models;

namespace ACWeb.Controllers
{
    public class ServiceController : Controller
    {
        [HttpPost]
        public ActionResult Contact(ContactInfo ci)
        {
            return View();
        }
    }
}