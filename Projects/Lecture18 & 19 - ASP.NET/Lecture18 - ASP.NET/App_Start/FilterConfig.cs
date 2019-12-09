using System.Web;
using System.Web.Mvc;

namespace Lecture18___ASP.NET {
    public class FilterConfig {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
