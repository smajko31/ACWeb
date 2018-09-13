using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ACWeb
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("SpecificRoute", "{action}/{id}", new { controller = "Main", action = "Home", id = UrlParameter.Optional });
            routes.MapRoute("Default","{controller}/{action}", new { controller = "Main", action = "Home", id = UrlParameter.Optional });
        }
    }
}
