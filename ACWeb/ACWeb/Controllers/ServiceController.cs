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
            TempData["Message"] = "Your message has been delivered!";
            return RedirectToAction("Contact", "Main", null);
        }
    }
}