
/************************************************************************ 
 * 项目名称 :  Common   
 * 项目描述 :      
 * 类 名 称 :  LoggerHelper 
 * 版 本 号 :  v1.0.0.0  
 * 说    明 :      
 * 作    者 :  dev 
 * 创建时间 :  2015/6/24 11:44:19 
 * 修 改 人 :  dev
 * 修改说明 :
 * 更新时间 :  2015/6/24 11:44:19 
************************************************************************ 
 * Copyright @ dev 2015. All rights reserved. 
************************************************************************/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using log4net;
using log4net.Core;

namespace Common
{
    /// <summary>
    /// 使用LOG4NET记录日志的功能，在WEB.CONFIG里要配置相应的节点
    /// </summary>
    public class LoggerHelper
    {
        public LoggerHelper()
        {
            //
            //Todo:添加构造函数
            //
        }



        //log4net日志专用
        public static readonly ILog loggerInfo = LogManager.GetLogger("loginfo");

        public static readonly ILog loggerError = LogManager.GetLogger("logerror");
        public static readonly ILog loggerWarn = LogManager.GetLogger("loggerWarn");

        public static void SetConfig()
        {
            log4net.Config.XmlConfigurator.Configure();
        }

        public static void SetConfig(FileInfo configFile)
        {
            log4net.Config.XmlConfigurator.Configure(configFile);
        }

        public static ILog GetLogger()
        {
            ILog logger = LogManager.GetLogger("logerror");
            return logger;
        }


        /// <summary>
        /// 普通的文件记录日志
        /// </summary>
        /// <param name="info"></param>
        public static void WriteLog(string info)
        {
            if (loggerInfo.IsInfoEnabled)
            {
                loggerInfo.Info(info);
            }
        }

        public static void Info1(string msg, Exception ex = null)
        {
            
            ILog log = loggerError;
            if (log.IsErrorEnabled)
            {
                //WebLogger webLogger = new WebLogger
                //{
                //    RecoreTime = DateTime.Now,
                //    Message = msg
                //};
           
                //if (ex == null)
                //{
                //    log.Error(webLogger);
                //}
                //else
                //{
                //    log.Error(webLogger, ex);
                //}
                loggerError.Error(msg, ex);
            }
        }

        /// <summary>
        /// 错误日志
        /// </summary>
        /// <param name="info"></param>
        /// <param name="se"></param>
        public static void WriteLog(string info, Exception se)
        {
            if (loggerError.IsErrorEnabled)
            {
                loggerError.Error(info, se);
            }
        }
    }

}