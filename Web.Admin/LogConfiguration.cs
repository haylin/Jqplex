using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CustomLayout
{
    public class LogConfiguration
    {
        public static FileInfo GetConfigFile()
        {
            string filePath = "Config/log4.config";//System.Configuration.ConfigurationManager.AppSettings["logConfigFile"];
            //if (string.IsNullOrEmpty(filePath))
            //{
            //    filePath = "Web.config";
            //}
            filePath = System.Web.HttpContext.Current.Server.MapPath(filePath);

            if (File.Exists(filePath))
            {
                return new FileInfo(filePath);
            }
            return null;
        }



    }
}
