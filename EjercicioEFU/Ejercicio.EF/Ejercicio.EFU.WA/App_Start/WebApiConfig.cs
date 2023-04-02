using Newtonsoft.Json;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Ejercicio.EFU.WA
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {


            config.MapHttpAttributeRoutes();
            var jsonSettings = config.Formatters.JsonFormatter.SerializerSettings;
            jsonSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}