using System.Web;
using System.Web.Mvc;

namespace TutorialMVC70486
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //si loa agregamos aca todos los controladores estarian protegidos
            // filters.Add(new System.Web.Mvc.AuthorizeAttribute());
            filters.Add(new HandleErrorAttribute());
        }
    }
}
