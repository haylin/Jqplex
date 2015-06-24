
/************************************************************************ 
 * 项目名称 :  Entity   
 * 项目描述 :      
 * 类 名 称 :  WebLogger 
 * 版 本 号 :  v1.0.0.0  
 * 说    明 :      
 * 作    者 :  dev 
 * 创建时间 :  2015/6/24 14:10:05 
 * 修 改 人 :  dev
 * 修改说明 :
 * 更新时间 :  2015/6/24 14:10:05 
************************************************************************ 
 * Copyright @ dev 2015. All rights reserved. 
************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class WebLogger
    {
        private DateTime _recordTime;

        public WebLogger()
        {
          
            //
            //Todo:添加构造函数
            //
        }

    

        public string Id { get; set; }

        public DateTime RecoreTime
        {
            get { return _recordTime; }
            set { _recordTime = value; }
        }

        public int LevelName { get; set; }

        public string Message { get; set; }
        public string Exceptions { get; set; }
        public string IpAddress { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string SenderWay { get; set; }
        public int State { get; set; }
    }
}