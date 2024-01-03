using System.Web;
using System.Web.Mvc;

namespace MinhaSolucao.MVC48
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
