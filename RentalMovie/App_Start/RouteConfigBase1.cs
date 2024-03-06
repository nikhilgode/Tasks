using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace RentalMovie
{
    public class RouteConfigBase1
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
              name: "Default",
               url: "/{controller}/{action}", // Remove extra curly braces
              defaults: new { controller = "Home", action = "Index" }
                );

        }
    }
}