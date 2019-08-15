using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FlavaSolutionsFinal
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                 name: "StartPage",
                 url: "",
                 defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
             );

            routes.MapRoute(
                name: "Login1",
                url: "Views/User/Login",
                defaults: new { controller = "User", action = "Login", id = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "Login",
               url: "Login",
               defaults: new { controller = "User", action = "Login", id = UrlParameter.Optional }
           );

            routes.MapRoute(
             name: "Registration",
             url: "Register",
             defaults: new { controller = "User", action = "Registration", id = UrlParameter.Optional }
         );

            routes.MapRoute(
             name: "Registration1",
             url: "Registration",
             defaults: new { controller = "User", action = "Registration", id = UrlParameter.Optional }
         );

            routes.MapRoute(
                name: "Home",
                url: "Home",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Home1",
                url: "Home/Home",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
               name: "Home2",
               url: "Index",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
