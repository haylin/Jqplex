
/************************************************************************ 
 * 项目名称 :  WebLogger   
 * 项目描述 :      
 * 类 名 称 :  LogHelper 
 * 版 本 号 :  v1.0.0.0  
 * 说    明 :      
 * 作    者 :  dev 
 * 创建时间 :  2015/6/25 10:22:27 
 * 修 改 人 :  dev
 * 修改说明 :
 * 更新时间 :  2015/6/25 10:22:27 
************************************************************************ 
 * Copyright @ dev 2015. All rights reserved. 
************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using log4net;
using log4net.Core;


namespace WebLogger
{
    public class LogHelper
    {
        public LogHelper()
        {

        }

       // public  static string LoggerName = ConfigurationManager.AppSettings["ClientName"];
        public static string LoggerName = "MisTxtLogger";

        private static LogMessage _message = null;

        private static ILog _log;

        public static ILog log
        {
            get
            {
                //string path = @"E:\PC_H5\Web.Admin\Config\Log4.config";
                //log4net.Config.XmlConfigurator.Configure(new FileInfo(path));

                if (_log == null)
                {
                    //从配置文件中读取Logger对象  
                    //WebLogger 里面的配置信息是用来将日志录入到数据库的
                    //做为扩展 做判断来确定日志的记录形式，数据库也好，txt文档也好，控制台程序也好。
                    _log = log4net.LogManager.GetLogger(LoggerName); //log4net.LogManager.GetLogger("WebLogger");
                }
                else
                {
                    if (_log.Logger.Name != LoggerName)
                    {
                        _log = log4net.LogManager.GetLogger(LoggerName);
                        _log.Logger.Repository.Threshold = Level.All;
                    }

                }

                return _log;
            }
        }





        private static bool _isLoggerWatching = false;
        public static void InitLogger(FileInfo configFile)
        {
            if (!_isLoggerWatching)
            {
                if (configFile != null)
                {
                    log4net.Config.XmlConfigurator.ConfigureAndWatch(configFile);

                    _isLoggerWatching = true;
                }
            }
        }


        /// <summary>
        /// 日志级别
        /// </summary>
        public enum LevelEnum
        {
            [Description("全部")]
            All = 0,
            [Description("调试")]
            DeBug = 1,
            [Description("信息")]
            Info = 2,
            [Description("警告")]
            Warn = 3,
            [Description("错误")]
            Eror = 4,
            [Description("异常")]
            Fatal = 9,
            [Description("关闭")]
            Off = -1
        }

        /// <summary>
        /// 日志状态
        /// </summary>
        public enum LogerEnum
        {
            [Description("正常")]
            Normal = 0,
            [Description("发送")]
            Sender = 1,
            [Description("废弃")]
            Scrap = 2
        }
        /// <summary>
        /// 发送方式
        /// </summary>
        public enum SenderEnum
        {
            [Description("邮件")]
            EMail = 0,
            [Description("短信")]
            Message = 1,
            [Description("微信")]
            Weixin = 2
        }



        /// <summary>
        /// 调试
        /// </summary>
        public static void DebugLog4()
        {
            if (log.IsDebugEnabled)
            {
                log.Debug(_message);
            }
        }


        /// <summary>
        /// 错误
        /// </summary>
        public static void ErrorLog4()
        {
            if (log.IsErrorEnabled)
            {

                log.Error(_message);
                //保存数据
                var mongo = new MongoCurd<LogMessage>();
                mongo.Insert(_message);
                //MongoHelper.InsertOne(message);
            }
        }

        /// <summary>
        /// 严重错误
        /// </summary>
        public static void FatalLog4()
        {
            if (log.IsFatalEnabled)
            {
                log.Fatal(_message);
            }
        }

        /// <summary>
        /// 记录一般日志
        /// </summary>
        public static void InfoLog4()
        {
            if (log.IsInfoEnabled)
            {
                //log.Info("Jerry");
                log.Info(_message);
            }
        }


        /// <summary>
        /// 记录警告
        /// </summary>
        public static void WarnLog4()
        {
            if (log.IsWarnEnabled)
            {
                log.Warn(_message);
            }
        }


        /// <summary>  
        /// 需要写日志的地方调用此方法  
        /// </summary>
        /// <param name="logMessage">日志内容</param>
        /// <param name="userName"></param>
        /// <param name="level">自定义级别</param>
        /// <param name="msg"></param>
        /// <param name="ex"></param>
        /// <param name="userId"></param>  
        public static void SaveMessage(string msg, string ex, int userId, string userName, LevelEnum level)
        {
            _message = LogMessage(msg, ex, userId, userName);

            switch (level)
            {
                case LevelEnum.Info:
                    InfoLog4();
                    break;

                case LevelEnum.Warn:
                    WarnLog4();
                    break;

                case LevelEnum.Eror:
                    ErrorLog4();
                    break;

                case LevelEnum.Fatal:
                    FatalLog4();
                    break;

                default: break;
            }
        }


        public static LogMessage LogMessage(string message, string ex, int userId, string userName)
        {
            var obj = new LogMessage
            {
                LevelName = LogHelper.LevelEnum.Eror.ToString(),
                Message = message,
                Exception = ex,
                SenderWay = LogHelper.SenderEnum.EMail.ToString(),
                State = (int)LogHelper.LogerEnum.Normal,
                UserId = userId,
                UserName = userName,
                IpAddress = IpAddressHelper.GetClientIp(),
                RecordTime = DateTime.Now,//) DateTime.UtcNow.ToLocalTime(),
            };
            return obj;
        }

    }


}