
/************************************************************************ 
 * 项目名称 :  Common   
 * 项目描述 :      
 * 类 名 称 :  XPatternLayoutConverter 
 * 版 本 号 :  v1.0.0.0  
 * 说    明 :      
 * 作    者 :  dev 
 * 创建时间 :  2015/6/24 16:58:08 
 * 修 改 人 :  dev
 * 修改说明 :
 * 更新时间 :  2015/6/24 16:58:08 
************************************************************************ 
 * Copyright @ dev 2015. All rights reserved. 
************************************************************************/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using log4net.Core;
using log4net.Layout.Pattern;

namespace Common
{
    public class XPatternLayoutConverter : PatternLayoutConverter
    {
        public XPatternLayoutConverter()
        {
            //
            //Todo:添加构造函数
            //
        }

        protected override void Convert(TextWriter writer, LoggingEvent loggingEvent)
        {
            if (this.Option != null)
            {
                // Write the value for the specified key
                WriteObject(writer, loggingEvent.Repository, LookupProperty(Option, loggingEvent));
            }
            else
            {
                // Write all the key value pairs
                WriteDictionary(writer, loggingEvent.Repository, loggingEvent.GetProperties());
            }
        }

        /// <summary>
        /// 通过反射获取传入的日志对象的某个属性的值
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        private Object LookupProperty(String property, log4net.Core.LoggingEvent loggingEvent)
        {
            Object propertyValue = String.Empty;
            PropertyInfo propertyInfo;

            propertyInfo = loggingEvent.MessageObject.GetType().GetProperty(property);
            if (propertyInfo != null)
            {
                propertyValue = propertyInfo.GetValue(loggingEvent.MessageObject, null);
            }
            return propertyValue;
        }
    }
}