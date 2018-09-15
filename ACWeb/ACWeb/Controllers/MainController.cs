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

        [Route("Gallery")]
        public ActionResult Gallery()
        {
            return View();
        }

        [Route("Contact")]
        public ActionResult Contact()
        {
            return View();
        }
    }
}