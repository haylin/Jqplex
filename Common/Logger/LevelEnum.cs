
/************************************************************************ 
 * 项目名称 :  Common   
 * 项目描述 :      
 * 类 名 称 :  LevelEnum 
 * 版 本 号 :  v1.0.0.0  
 * 说    明 :      
 * 作    者 :  dev 
 * 创建时间 :  2015/6/23 16:42:26 
 * 修 改 人 :  dev
 * 修改说明 :
 * 更新时间 :  2015/6/23 16:42:26 
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
    public enum LevelEnum
    {
        [Description("全部")]
        All = 0,
        [Description("调试")]
        DeBug = 1,
        [Description("信息")]
        Info = 2,
        [Description("警告")]
        Eror = 3,
        [Description("错误")]
        Level = 4,
        [Description("异常")]
        Fatal = 9,
        [Description("关闭")]
        Off = -1

    }
}