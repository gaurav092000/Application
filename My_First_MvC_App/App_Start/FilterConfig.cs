﻿using System.Web;
using System.Web.Mvc;

namespace My_First_MvC_App
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
