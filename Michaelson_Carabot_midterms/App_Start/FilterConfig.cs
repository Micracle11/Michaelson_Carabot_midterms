using System.Web;
using System.Web.Mvc;

namespace Michaelson_Carabot_midterms
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
