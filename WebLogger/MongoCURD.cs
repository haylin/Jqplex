
/************************************************************************ 
 * 项目名称 :  WebLogger   
 * 项目描述 :      
 * 类 名 称 :  MongoCURD 
 * 版 本 号 :  v1.0.0.0  
 * 说    明 :      
 * 作    者 :  dev 
 * 创建时间 :  2015/6/25 14:34:29 
 * 修 改 人 :  dev
 * 修改说明 :
 * 更新时间 :  2015/6/25 14:34:29 
************************************************************************ 
 * Copyright @ dev 2015. All rights reserved. 
************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebLogger
{
    public class MongoCurd<T> where T : class
    {
        public MongoCurd()
        {
            //
            //Todo:添加构造函数
            //
        }

        /// <summary>
        /// 添加对象
        /// </summary>
        /// <param name="entity"></param>
        public void Insert(T entity)
        {
            using (MongoDb mm = new MongoDb())
            {
                mm.GetCollection<T>().Insert(entity);
            }
        }

        /// <summary>
        /// 删除对象
        /// </summary>
        /// <param name="customerId"></param>
        public void Delete(string customerId)
        {
            using (MongoDb mm = new MongoDb())
            {
                mm.GetCollection<T>().Remove(customerId);
            }
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="obj"></param>
        public void Update(T obj)
        {
            using (MongoDb mm = new MongoDb())
            {
                mm.GetCollection<T>().Update(obj);
            }
        }

        /// <summary>
        /// 查询数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T GetById(string id)
        {
            using (MongoDb mm = new MongoDb())
            {
              return  mm.GetCollection<T>().FindOne(id);
               
            }
        }
    }
}