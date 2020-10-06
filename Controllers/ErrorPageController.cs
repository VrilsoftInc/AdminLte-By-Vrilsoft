using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminLte_By_Vrilsoft.Controllers
{
    public class ErrorPageController : Controller
    {
        public ActionResult Error()
        {
            return View();
        }
        public ActionResult PageNotFound()
        {
            return View();
        }
        public ActionResult InternalServerError()
        {
            return View();
        }
        public ActionResult Forbidden()
        {
            return View();
        }
    }
}