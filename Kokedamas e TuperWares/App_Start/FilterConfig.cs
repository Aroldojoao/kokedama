using System.Web;
using System.Web.Mvc;

namespace Kokedamas_e_TuperWares
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
