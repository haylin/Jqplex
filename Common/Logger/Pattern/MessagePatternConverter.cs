﻿
/************************************************************************ 
 * 项目名称 :  Common.Logger.Pattern   
 * 项目描述 :      
 * 类 名 称 :  MessagePatternConverter 
 * 版 本 号 :  v1.0.0.0  
 * 说    明 :      
 * 作    者 :  dev 
 * 创建时间 :  2015/6/24 16:52:50 
 * 修 改 人 :  dev
 * 修改说明 :
 * 更新时间 :  2015/6/24 16:52:50 
************************************************************************ 
 * Copyright @ dev 2015. All rights reserved. 
************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net.Layout.Pattern;

namespace Common
{
    internal class MessagePatternConverter : PatternLayoutConverter
    {
        protected override void Convert(System.IO.TextWriter writer, log4net.Core.LoggingEvent loggingEvent)
        {
            if (loggingEvent.MessageObject is CustomPatternMessage)
            {
                CustomPatternMessage cpm = loggingEvent.MessageObject as CustomPatternMessage;
                writer.Write(cpm.Message);
            }
        }
    }
}