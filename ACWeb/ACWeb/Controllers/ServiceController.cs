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
            TempData["sent"] = "Contact information sent successfully!";
            return RedirectToAction("Contact", "Main");
        }
    }
}