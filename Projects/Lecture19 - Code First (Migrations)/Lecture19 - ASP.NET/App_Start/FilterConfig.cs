﻿using System.Web;
using System.Web.Mvc;

namespace Lecture19___ASP.NET {
    public class FilterConfig {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
