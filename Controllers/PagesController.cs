using System.Web.Mvc;

namespace AdminLte_By_Vrilsoft.Controllers
{
    [Route("[Controller]")]
    public class PagesController : Controller
    {
        [Route("NewsNow")]
        public ActionResult News()
        {
            return View();
        }

        public ActionResult Articles()
        {
            return View();
        }
        public ActionResult Pages()
        {
            return View();
        }
    }
}
