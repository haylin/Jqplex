
/************************************************************************ 
 * 项目名称 :  Entity   
 * 项目描述 :      
 * 类 名 称 :  BaseEntities 
 * 版 本 号 :  v1.0.0.0  
 * 说    明 :      
 * 作    者 :  dev 
 * 创建时间 :  2015/6/23 10:49:24 
 * 修 改 人 :  dev
 * 修改说明 :
 * 更新时间 :  2015/6/23 10:49:24 
************************************************************************ 
 * Copyright @ dev 2015. All rights reserved. 
************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{

    /// <summary>
    /// 实体基类
    /// </summary>
    public class BaseEntities
    {
        public BaseEntities()
        {
            //
            //Todo:添加构造函数
            //
        }
        public int Id { get; set; }
        public override bool Equals(object obj)
        {
            return Equals(obj as BaseEntities);
        }

        private static bool IsTransient(BaseEntities obj)
        {
            return obj != null && Equals(obj.Id, default(int));
        }

        private Type GetUnproxiedType()
        {
            return GetType();
        }

        public virtual bool Equals(BaseEntities other)
        {
            if (other == null)
                return false;

            if (ReferenceEquals(this, other))
                return true;

            if (!IsTransient(this) &&
                !IsTransient(other) &&
                Equals(Id, other.Id))
            {
                var otherType = other.GetUnproxiedType();
                var thisType = GetUnproxiedType();
                return thisType.IsAssignableFrom(otherType) ||
                        otherType.IsAssignableFrom(thisType);
            }

            return false;
        }

        public override int GetHashCode()
        {
            if (Equals(Id, default(int)))
                return base.GetHashCode();
            return Id.GetHashCode();
        }

        public static bool operator ==(BaseEntities x, BaseEntities y)
        {
            return Equals(x, y);
        }

        public static bool operator !=(BaseEntities x, BaseEntities y)
        {
            return !(x == y);
        }
    }
}