
/************************************************************************ 
 * 项目名称 :  WebLogger   
 * 项目描述 :      
 * 类 名 称 :  IpAddress 
 * 版 本 号 :  v1.0.0.0  
 * 说    明 :      
 * 作    者 :  dev 
 * 创建时间 :  2015/6/29 11:00:01 
 * 修 改 人 :  dev
 * 修改说明 :
 * 更新时间 :  2015/6/29 11:00:01 
************************************************************************ 
 * Copyright @ dev 2015. All rights reserved. 
************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;

namespace WebLogger
{
    public class IpAddressHelper
    {
        public IpAddressHelper()
        {
            //
            //Todo:添加构造函数
            //
        }

        /// <summary>
        /// 服务器端获取客户端请求IP和客户端机器名称
        /// </summary>
        public static void GetClientInfo()
        {
            OperationContext context = OperationContext.Current;
            MessageProperties messageProperties = context.IncomingMessageProperties;
            RemoteEndpointMessageProperty endpointProperty =
                messageProperties[RemoteEndpointMessageProperty.Name] as RemoteEndpointMessageProperty;
            HttpRequestMessageProperty requestProperty =
                messageProperties[HttpRequestMessageProperty.Name] as HttpRequestMessageProperty;
            string clientIp = !string.IsNullOrEmpty(requestProperty.Headers["X-Real-IP"])
                ? requestProperty.Headers["X-Real-IP"]
                : endpointProperty.Address;
            string clientName = Environment.MachineName;
            Console.WriteLine("ClientIp: " + clientIp + "clientName:" + clientName);
        }

        /// <summary>
        /// 服务器端获取客户端请求的IP
        /// </summary>
        /// <returns></returns>
        public static string GetClientIpAddress()
        {
            OperationContext context = OperationContext.Current;
            MessageProperties messageProperties = context.IncomingMessageProperties;
            RemoteEndpointMessageProperty endpointProperty =
                messageProperties[RemoteEndpointMessageProperty.Name] as RemoteEndpointMessageProperty;
            HttpRequestMessageProperty requestProperty =
                messageProperties[HttpRequestMessageProperty.Name] as HttpRequestMessageProperty;
            string clientIp = !string.IsNullOrEmpty(requestProperty.Headers["X-Real-IP"])
                ? requestProperty.Headers["X-Real-IP"]
                : endpointProperty.Address;
            return clientIp;
        }

        /// <summary>
        /// 获取客户端Ip
        /// </summary>
        /// <returns></returns>
        public static String GetClientIp()
        {
            String clientIP = "";
            if (System.Web.HttpContext.Current != null)
            {
                clientIP = System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
                if (string.IsNullOrEmpty(clientIP) || (clientIP.ToLower() == "unknown"))
                {
                    clientIP = System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_REAL_IP"];
                    if (string.IsNullOrEmpty(clientIP))
                    {
                        clientIP = System.Web.HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
                    }
                }
                else
                {
                    clientIP = clientIP.Split(',')[0];
                }
            }
            return clientIP;
        }
    }
}