
/************************************************************************ 
 * 项目名称 :  Entity   
 * 项目描述 :      
 * 类 名 称 :  WebLoggerEx 
 * 版 本 号 :  v1.0.0.0  
 * 说    明 :      
 * 作    者 :  dev 
 * 创建时间 :  2015/6/24 14:58:57 
 * 修 改 人 :  dev
 * 修改说明 :
 * 更新时间 :  2015/6/24 14:58:57 
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
using log4net.Layout;
using log4net.Layout.Pattern;

namespace Common
{
    public class CustomPatternLayout : PatternLayout
    {
        public CustomPatternLayout()
        {
            this.AddConverter("property", typeof(XPatternLayoutConverter));
        }
    }


}