﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiClient.Contexts
{
    /// <summary>
    /// 表示请求Api的返回描述
    /// </summary>
    public class ApiReturnDescriptor
    {
        /// <summary>
        /// 获取关联的ApiReturnAttribute
        /// </summary>
        public IApiReturnAttribute Attribute { get; internal set; }

        /// <summary>
        /// 获取Api返回的TaskOf(T)类型
        /// </summary>
        public Type TaskType { get; internal set; }

        /// <summary>
        /// 获取Api返回的TaskOf(T)的T类型
        /// </summary>
        public Type DataType { get; internal set; }
    }
}
