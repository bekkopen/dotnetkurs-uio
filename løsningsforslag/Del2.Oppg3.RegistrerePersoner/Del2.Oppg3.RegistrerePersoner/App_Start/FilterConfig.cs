using System.Web.Mvc;

namespace Del2.Oppg3.RegistrerePersoner.App_Start
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}