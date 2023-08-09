using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication_DotNet_MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional}
            );


            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}/{abc}",
            //    defaults: new { controller = "Home", action = "About", id = UrlParameter.Optional, abc = UrlParameter.Optional }
            //);
        }
    }
}
