using System.Web.Mvc;
using ACWeb.Models;

namespace ACWeb.Controllers
{
    public class ServiceController : Controller
    {
        [HttpPost]
        public ActionResult Contact(ContactInfo ci)
        {
            ci.Send();
            ViewBag.Message = "Success!";
            return View();
        }
    }
}