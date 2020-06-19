using System.Web;
using System.Web.Mvc;

namespace BigSchool_1711060452
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
