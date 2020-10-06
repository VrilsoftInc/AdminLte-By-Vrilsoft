using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminLte_By_Vrilsoft.Controllers
{
    public class SiteController : Controller
    {
        [Route("About")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [Route("Contact")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
        [Route("Team")]
        public ActionResult Team()
        {
            return View();
        }
        [Route("Email-us")]
        public ActionResult EmailUs()
        {
            return View();
        }
        [Route("Privacy")]
        public ActionResult Privacy()
        {
            return View();
        }
    }
}