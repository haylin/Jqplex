
/************************************************************************ 
 * 项目名称 :  WebLogger   
 * 项目描述 :      
 * 类 名 称 :  CustomLayout 
 * 版 本 号 :  v1.0.0.0  
 * 说    明 :      
 * 作    者 :  dev 
 * 创建时间 :  2015/6/25 10:20:58 
 * 修 改 人 :  dev
 * 修改说明 :
 * 更新时间 :  2015/6/25 10:20:58 
************************************************************************ 
 * Copyright @ dev 2015. All rights reserved. 
************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebLogger
{
    public class CustomLayout : log4net.Layout.PatternLayout
    {
        public CustomLayout()
        {
            this.AddConverter("RecordTime", typeof(RecordTimePatternConverter));
            this.AddConverter("LevelName", typeof(LevelNamePatternConverter));
            this.AddConverter("Message", typeof(MessagePatternConverter));
            this.AddConverter("Exception", typeof(ExceptionPatternConverter));
            this.AddConverter("IpAddress", typeof(IpAddressPatternConverter));
            this.AddConverter("UserID", typeof(UserIdPatternConverter));
            this.AddConverter("UserName", typeof(UserNamePatternConverter));
            this.AddConverter("SenderWay", typeof(SenderWayPatternConverter));
            this.AddConverter("State", typeof(StatePatternConverter));
        }
    }
}