using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MyApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {            
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            
            // Only JSON!
            if (config.Formatters.Contains(config.Formatters.XmlFormatter))
            {
                config.Formatters.Remove(config.Formatters.XmlFormatter);
            }
        }
    }
}