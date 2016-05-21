using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TutorialMVC70486
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            //rutas webforms
            routes.MapPageRoute("webf", "webform/{pagename}", "~/static/{pagename}.aspx");
                
            //rutas personalizadas en el controlador
            routes.MapMvcAttributeRoutes();

            //registrar las areas
            AreaRegistration.RegisterAllAreas();

            //rutas de forma tradicional/ traditional routes
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

           
        }
    }
}
