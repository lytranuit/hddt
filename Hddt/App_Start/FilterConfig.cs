﻿using System.Web;
using System.Web.Mvc;

namespace DAIHOI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new LocalizationAttribute("vn"), 0);
        }

    }
}
