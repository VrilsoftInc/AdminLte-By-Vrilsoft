using System.Web.Mvc;
using System.Web.Routing;

namespace AdminLte_By_Vrilsoft
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            /* Error routes */
            routes.MapRoute("Error", "{controller}/E/", new { controller = "ErrorPage", action = "Error" });
            routes.MapRoute("404Error", "{controller}/404Error/", new { controller = "ErrorPage", action = "PageNotFound" });
            routes.MapRoute("500Error", "{controller}/500Error/", new { controller = "ErrorPage", action = "InternalServerError" });
            routes.MapRoute("403Error", "{controller}/403Error/", new { controller = "ErrorPage", action = "Forbidden" });
            /* Pages, News, Articles routes */
            routes.MapRoute("News", "{controller}/News/", new { controller = "Pages", action = "News" });
            routes.MapRoute("Articles", "{controller}/Articles/", new { controller = "Pages", action = "Articles" });
            routes.MapRoute("Pages", "{controller}/P/", new { controller = "Pages", action = "Pages" });
            routes.MapRoute("About", "S/About/", new { controller = "Site", action = "About" });
            routes.MapRoute("Contact", "S/Contact/", new { controller = "Site", action = "Contact" });
            routes.MapRoute("Team", "S/Team/", new { controller = "Site", action = "Team" });
            routes.MapRoute("EmailUs", "S/EmailUs/", new { controller = "Site", action = "EmailUs" });
            routes.MapRoute("PrivacyPolicy", "S/Privacy/", new { controller = "Site", action = "Privacy" });

            /* Default route */
            routes.MapRoute(name: "Content", url: "{controller}/{action}/{id}", defaults: new { controller = "Content", action = "Index", id = UrlParameter.Optional });
        }
    }
}
