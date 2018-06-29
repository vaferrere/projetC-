using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Liste",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Produit", action = "Liste", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Ajout",
                url: "{controller}/{action}",
                defaults: new { controller = "Produit", action = "Ajout" }
            );

            routes.MapRoute(
                name: "AjoutCategorie",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Categorie", action = "Create" }
            );
        }
    }
}
