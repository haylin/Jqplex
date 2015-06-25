
/************************************************************************ 
 * 项目名称 :  WebLogger   
 * 项目描述 :      
 * 类 名 称 :  LogMessage 
 * 版 本 号 :  v1.0.0.0  
 * 说    明 :      
 * 作    者 :  dev 
 * 创建时间 :  2015/6/25 10:20:11 
 * 修 改 人 :  dev
 * 修改说明 :
 * 更新时间 :  2015/6/25 10:20:11 
************************************************************************ 
 * Copyright @ dev 2015. All rights reserved. 
************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebLogger
{
    public class LogMessage
    {
        public LogMessage()
        {
            //
            //Todo:添加构造函数
            //
        }
        public DateTime RecordTime { get; set; }

        public string LevelName { get; set; }

        public string Message { get; set; }

        public string Exception { get; set; }

        public string IpAddress { get; set; }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string SenderWay { get; set; }
        public int State { get; set; }
   
    }
}