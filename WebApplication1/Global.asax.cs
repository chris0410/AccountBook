using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WebApplication1.Models;

namespace WebApplication1
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Repository.VMPrository = new List<Models.ViewModels.MoneyViewModel>()
            {
                //    new Models.ViewModels.MoneyViewModel() { category = "output", money=500, date= "2017-08-08 12:00:00.000", memo  = "" },
                //    new Models.ViewModels.MoneyViewModel() { category = "input", money=300, date= "2017-08-08 12:30:00.000", memo  = "AAA" },
                //    new Models.ViewModels.MoneyViewModel() { category = "output", money=200, date= "2017-08-08 13:00:00.000", memo  = "" }
            };
        }
    }
}
