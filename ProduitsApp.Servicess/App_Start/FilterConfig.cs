using System.Web;
using System.Web.Mvc;

namespace ProduitsApp.Servicess
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
