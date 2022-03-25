using System.Web;
using System.Web.Mvc;

namespace Bigschool_1911060177_TranCongMinh
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
