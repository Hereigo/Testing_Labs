﻿using System.Web;
using System.Web.Mvc;

namespace Angular_Net462
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
