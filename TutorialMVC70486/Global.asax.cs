using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Interception;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TutorialMVC70486.Models;

namespace TutorialMVC70486
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

          // ClientDataTypeModelValidatorProvider.ResourceClassKey = "Messages";
          // DefaultModelBinder.ResourceClassKey = "Messages";

            //Inicializar la base de datos
           // Database.SetInitializer(new EscuelaDbInit());
           //definir un interceptor a la base de datos
            // DbInterception.Add(new EscuelaInterceptor());

           
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
