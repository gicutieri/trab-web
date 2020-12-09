using System.Web.Http;

namespace TrabalhoWeb.Ecommerce.Api
{
    public class RouteConfig
    {
        public static void RegisterRoutes(HttpConfiguration config)
        {
            // Enable attribute routing
            config.MapHttpAttributeRoutes();

            // Add default route using convention-based routing
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
