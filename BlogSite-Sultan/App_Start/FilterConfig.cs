﻿using System.Web;
using System.Web.Mvc;

namespace BlogSite_Sultan
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
