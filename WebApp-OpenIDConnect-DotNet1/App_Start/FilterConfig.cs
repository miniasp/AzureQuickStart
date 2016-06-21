using System.Web;
using System.Web.Mvc;

namespace WebApp_OpenIDConnect_DotNet1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
