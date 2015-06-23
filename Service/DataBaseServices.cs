
/************************************************************************ 
 * 项目名称 :  Service   
 * 项目描述 :      
 * 类 名 称 :  DataBaseServices 
 * 版 本 号 :  v1.0.0.0  
 * 说    明 :      
 * 作    者 :  dev 
 * 创建时间 :  2015/6/23 9:40:45 
 * 修 改 人 :  dev
 * 修改说明 :
 * 更新时间 :  2015/6/23 9:40:45 
************************************************************************ 
 * Copyright @ dev 2015. All rights reserved. 
************************************************************************/

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace Service
{
    public class DataBaseServices
    {
        public DataBaseServices()
        {
            //
            //Todo:添加构造函数
            //
        }

        // 得到web.config里配置项的数据库连接字符串。  
        private static readonly string ConnectionString =
            ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        // 得到工厂提供器类型
        private static readonly string ProviderFactoryString = ConfigurationManager.AppSettings["DBProvider"].ToString();

        private static DbProviderFactory df = null;

        /// <summary>  
        /// 创建工厂提供器并且  
        /// </summary> 
        public static IDbConnection DbService()
        {
            if (df == null)
                df = DbProviderFactories.GetFactory(ProviderFactoryString);
            var connection = df.CreateConnection();
            if (connection != null)
            {
                connection.ConnectionString = ConnectionString;
                connection.Open();
                return connection;
            }
            return null;
        }

       
       
    }

}