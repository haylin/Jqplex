using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using log4net;
using Logger.Extensions;

namespace Logger
{
    public class LogHelper
    {
        private static bool isLoggerWatching = false;
        public static void InitLogger(FileInfo configFile)
        {
            if (!isLoggerWatching)
            {
                if (configFile != null)
                {
                    log4net.Config.XmlConfigurator.ConfigureAndWatch(configFile);

                    isLoggerWatching = true;
                }
            }
        }

        private static ILog GetLogger()
        {
            ILog logger = LogManager.GetLogger("logger");
            return logger;
        }

        /// <summary>
        /// Change the Web.config
        /// &lt;add key="logConfigFile" value="configs\log4net1.xml"/&gt;
        /// <seealso cref="http://www.npcompetesolutions.com/Blogs/?p=3"/>
        /// </summary>
        /// <param name="eventName"></param>
        /// <param name="userIP"></param>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        public static void Info1(string eventName, string userIP, string message, Exception ex = null)
        {
            ILog logger = GetLogger();
            if (logger.IsInfoEnabled)
            {
                log4net.ThreadContext.Properties["EventName"] = eventName;
                log4net.ThreadContext.Properties["UserIP"] = userIP;
                if (ex == null)
                    logger.Info(message);
                else
                    logger.Info(message, ex);
            }
        }

        /// <summary>
        /// Change the Web.config
        /// &lt;add key="logConfigFile" value="configs\log4net2.xml"/&gt;
        /// </summary>
        /// <param name="eventName"></param>
        /// <param name="userIP"></param>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        public static void Info2(string eventName, string userIP, string message, Exception ex = null)
        {
            ILog logger = GetLogger();
            if (logger.IsInfoEnabled)
            {
                CustomPatternMessage cpm = new CustomPatternMessage
                {
                    EventName = eventName,
                    UserIP = userIP,
                    Message = message
                };
                if (ex == null)
                    logger.Info(cpm);
                else
                    logger.Info(cpm, ex);
            }
        }

        /// <summary>
        /// Change the Web.config
        /// &lt;add key="logConfigFile" value="configs\log4net3.xml"/&gt;
        /// </summary>
        /// <param name="eventName"></param>
        /// <param name="userIP"></param>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        public static void Info3(string eventName, string userIP, string message, Exception ex = null)
        {
            ILog logger = GetLogger();
            if (logger.IsInfoEnabled)
            {
                CustomPatternMessage cpm = new CustomPatternMessage
                {
                    EventName = eventName,
                    UserIP = userIP,
                    Message = message,
                    RecordTime = DateTime.Now
                    
                };
                if (ex == null)
                    logger.Info(cpm);
                else
                    logger.Info(cpm, ex);
            }
        }
    }
}
