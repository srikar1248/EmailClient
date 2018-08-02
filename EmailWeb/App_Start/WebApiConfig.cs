using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace SendEmailApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/notification/send",
                defaults: new { id = RouteParameter.Optional, controller = "Notification", action = "send" }
            );
            config.Routes.MapHttpRoute(
                name: "DefaultApi1",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
