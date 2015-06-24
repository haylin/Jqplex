
/************************************************************************ 
 * 项目名称 :  Common.Logger.Pattern   
 * 项目描述 :      
 * 类 名 称 :  CustomPatternMessage 
 * 版 本 号 :  v1.0.0.0  
 * 说    明 :      
 * 作    者 :  dev 
 * 创建时间 :  2015/6/24 17:03:14 
 * 修 改 人 :  dev
 * 修改说明 :
 * 更新时间 :  2015/6/24 17:03:14 
************************************************************************ 
 * Copyright @ dev 2015. All rights reserved. 
************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class CustomPatternMessage
    {
        public CustomPatternMessage()
        {
            //
            //Todo:添加构造函数
            //
        }
        private string _eventName;
        public string EventName
        {
            get { return _eventName; }
            set { _eventName = value; }
        }

        private string _userIP;
        public string UserIP
        {
            get { return _userIP; }
            set { _userIP = value; }
        }

        private string _message;
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

    }
}