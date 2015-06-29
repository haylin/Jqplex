
/************************************************************************ 
 * 项目名称 :  WebLogger   
 * 项目描述 :      
 * 类 名 称 :  UserIDPatternConverter 
 * 版 本 号 :  v1.0.0.0  
 * 说    明 :      
 * 作    者 :  dev 
 * 创建时间 :  2015/6/25 10:21:40 
 * 修 改 人 :  dev
 * 修改说明 :
 * 更新时间 :  2015/6/25 10:21:40 
************************************************************************ 
 * Copyright @ dev 2015. All rights reserved. 
************************************************************************/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using log4net.Core;
using log4net.Layout.Pattern;

namespace WebLogger
{


    /// <summary>
    /// 记录时间
    /// </summary>
    internal sealed class RecordTimePatternConverter : PatternLayoutConverter
    {
        override protected void Convert(TextWriter writer, LoggingEvent loggingEvent)
        {
            LogMessage logMessage = loggingEvent.MessageObject as LogMessage;

            if (logMessage != null)
                writer.Write(logMessage.RecordTime);
        }
    }

    /// <summary>
    /// 日志级别名称
    /// </summary>
    internal sealed class LevelNamePatternConverter : PatternLayoutConverter
    {
        override protected void Convert(TextWriter writer, LoggingEvent loggingEvent)
        {
            LogMessage logMessage = loggingEvent.MessageObject as LogMessage;

            if (logMessage != null)
                writer.Write(logMessage.LevelName);
        }
    }

    /// <summary>
    /// 消息内容
    /// </summary>
    internal sealed class MessagePatternConverter : PatternLayoutConverter
    {
        override protected void Convert(TextWriter writer, LoggingEvent loggingEvent)
        {
            LogMessage logMessage = loggingEvent.MessageObject as LogMessage;

            if (logMessage != null)
                writer.Write(logMessage.Message);
        }
    }

    /// <summary>
    /// 异常信息
    /// </summary>
    internal sealed class ExceptionPatternConverter : PatternLayoutConverter
    {
        override protected void Convert(TextWriter writer, LoggingEvent loggingEvent)
        {
            LogMessage logMessage = loggingEvent.MessageObject as LogMessage;

            if (logMessage != null)
                writer.Write(logMessage.Exception);
        }
    }

    /// <summary>
    /// IP地址
    /// </summary>
    internal sealed class IpAddressPatternConverter : PatternLayoutConverter
    {
        override protected void Convert(TextWriter writer, LoggingEvent loggingEvent)
        {
            LogMessage logMessage = loggingEvent.MessageObject as LogMessage;

            if (logMessage != null)
                writer.Write(logMessage.IpAddress);
        }
    }


    /// <summary>
    /// 用户ID
    /// </summary>
    internal sealed class UserIdPatternConverter : PatternLayoutConverter
    {
        override protected void Convert(TextWriter writer, LoggingEvent loggingEvent)
        {
            LogMessage logMessage = loggingEvent.MessageObject as LogMessage;

            if (logMessage != null)
                writer.Write(logMessage.UserId);
        }
    }

    /// <summary>
    /// 用户名称
    /// </summary>
    internal sealed class UserNamePatternConverter : PatternLayoutConverter
    {
        override protected void Convert(TextWriter writer, LoggingEvent loggingEvent)
        {
            LogMessage logMessage = loggingEvent.MessageObject as LogMessage;

            if (logMessage != null)
                writer.Write(logMessage.UserName);
        }
    }

    /// <summary>
    /// 发送方式
    /// </summary>
    internal sealed class SenderWayPatternConverter : PatternLayoutConverter
    {
        override protected void Convert(TextWriter writer, LoggingEvent loggingEvent)
        {
            LogMessage logMessage = loggingEvent.MessageObject as LogMessage;

            if (logMessage != null)
                writer.Write(logMessage.UserName);
        }
    }

    /// <summary>
    /// 状态
    /// </summary>
    internal sealed class StatePatternConverter : PatternLayoutConverter
    {
        override protected void Convert(TextWriter writer, LoggingEvent loggingEvent)
        {
            LogMessage logMessage = loggingEvent.MessageObject as LogMessage;

            if (logMessage != null)
                writer.Write(logMessage.State);
        }
    }


}