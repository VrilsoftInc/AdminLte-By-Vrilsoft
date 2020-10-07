using System.Web.Mvc;

namespace AdminLte_By_Vrilsoft.Controllers
{
    [Route("[Controller]")]
    public class PagesController : Controller
    {
        public ActionResult News()
        {
            return View();
        }

        public ActionResult Articles()
        {
            return View(); //Or you can integrate your model ArticlesViewModel for getting the username of the user who posted etc. That work takes place here.
        }
        public ActionResult Pages()
        {
            return View();
        }
    }
}
