using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DAIHOI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.LowercaseUrls = true;
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
//            routes.MapRoute(
//name: "LanguageHome",
//url: "{lang}/he-thong/{action}/{id}",
//defaults: new { controller = "Home", action = "thong-tin", id = UrlParameter.Optional },
//constraints: new { lang = @"en|vi" }
//);
//            routes.MapRoute(
//                name: "Home",
//                url: "he-thong/{action}/{id}",
//                defaults: new { controller = "Home", action = "thong-tin", id = UrlParameter.Optional, lang = "en" }
//            );
            routes.MapRoute(
        name: "Default",
        url: "home/{action}/{id}",
        defaults: new { controller = "Hoadonview", action = "Index", id = UrlParameter.Optional }
    );
         //   routes.MapRoute(
         //    name: "Language",
         //    url: "{lang}/{action}/{id}",
         //    defaults: new { controller = "Login", action = "dang-nhap", id = UrlParameter.Optional },
         //    constraints: new { lang = @"en|vi" }
         //);
         //   routes.MapRoute(
         //    name: "Default",
         //    url: "{action}/{id}",
         //    defaults: new { controller = "Login", action = "dang-nhap", id = UrlParameter.Optional, lang = "en" }
         //);
        }
    }
}
