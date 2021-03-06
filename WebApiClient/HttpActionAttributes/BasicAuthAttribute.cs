﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiClient.Contexts;

namespace WebApiClient.Attributes
{
    /// <summary>
    /// 表示请求的基本授权
    /// </summary>
    public class BasicAuthAttribute : ApiActionAttribute
    {
        /// <summary>
        /// BasicAuth
        /// </summary>
        private readonly IApiParameterable baiscAuth;

        /// <summary>
        /// 基本授权
        /// </summary>
        /// <param name="userName">账号</param>
        /// <param name="password">密码</param>
        /// <exception cref="ArgumentNullException"></exception>
        public BasicAuthAttribute(string userName, string password)
        {
            this.baiscAuth = new BasicAuth(userName, password);
        }

        /// <summary>
        /// 执行前
        /// </summary>
        /// <param name="context">上下文</param>
        /// <returns></returns>
        public override Task BeforeRequestAsync(ApiActionContext context)
        {
            return this.baiscAuth.BeforeRequestAsync(context, null);
        }

        /// <summary>
        /// 转换为字符串
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.baiscAuth.ToString();
        }
    }
}
