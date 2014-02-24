using System.Web;
using System.Web.Mvc;

namespace Del2.Oppg1.ToSider
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}