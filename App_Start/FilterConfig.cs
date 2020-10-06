using System.Web;
using System.Web.Mvc;

namespace AdminLte_By_Vrilsoft
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
