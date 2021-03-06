﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;


namespace Web.Admin
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {


            //Log4加载
           // log4net.Config.XmlConfigurator.Configure();
           
           // Logger.LogHelper.InitLogger(CustomLayout.LogConfiguration.GetConfigFile());

            WebLogger.LogHelper.InitLogger(CustomLayout.LogConfiguration.GetConfigFile());
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //
            ControllerBuilder.Current.DefaultNamespaces.Add("Web.Admin.Controllers.*");

 
        }
    }
}
