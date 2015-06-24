
/************************************************************************ 
 * 项目名称 :  Common   
 * 项目描述 :      
 * 类 名 称 :  LogerEnum 
 * 版 本 号 :  v1.0.0.0  
 * 说    明 :      
 * 作    者 :  dev 
 * 创建时间 :  2015/6/24 9:52:58 
 * 修 改 人 :  dev
 * 修改说明 :
 * 更新时间 :  2015/6/24 9:52:58 
************************************************************************ 
 * Copyright @ dev 2015. All rights reserved. 
************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Common
{
    public enum LogerEnum
    {
        [Description("正常")]
        Normal = 0,
        [Description("发送")]
        Sender = 1,
        [Description("废弃")]
        Scrap = 2
    }

}