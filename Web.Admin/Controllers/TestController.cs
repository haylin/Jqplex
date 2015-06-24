using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Common;
using Entity;

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
               LoggerHelper.Info1("一般性错误12133",ex);
                LoggerHelper.WriteLog("ddd",ex);
               
           
            }

            return Json(msg);
        }
    }
}