using System.Web.Mvc;

namespace AdminLte_By_Vrilsoft.Controllers
{
    [HandleError]
    public class ContentController : Controller
    {
        [Route("Index")]
        [Route("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}