using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Entity;
using log4net.Repository.Hierarchy;
using Logger;
using WebLogger;
using Logger = log4net.Repository.Hierarchy.Logger;
using LogHelper = WebLogger.LogHelper;

namespace Web.Admin.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/
        public ActionResult Index()
        {
            return View();
        }


        public JsonResult Abc()
        {
            int i = 0;
            string msg = "";

            try
            {
                if (i != 0)
                {
                    msg = "ok";
                }

                SqlConnection conf = new SqlConnection();
                conf.Open();

            }
            catch (Exception ex)
            {
                msg = "fild";
              // LogHelper.Info3("你好","127.0.0.1","一般性问题",ex);
               //LoggerHelper.Info1("一般性错误12133",ex);
               // LoggerHelper.WriteLog("ddd",ex);
                var logMessage=new LogMessage();
                logMessage.RecordTime = DateTime.Now;
                logMessage.UserId = 123456;
                logMessage.Message = "你操作了";
              WebLogger.LogHelper.SaveMessage(logMessage, LogHelper.LevelEnum.Eror);
           
            }

            return Json(msg);
        }
    }
}