using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dzmrap.Validation
{
    public interface IValidate
    {
        /// <summary>
        /// 是否已经认证过
        /// </summary>
        /// <returns></returns>
        bool IsValidated();
        /// <summary>
        /// 是否过期
        /// </summary>
        /// <returns></returns>
        bool IsExpired();
        /// <summary>
        /// 进行验证
        /// </summary>
        /// <param name="str">认证码</param>
        /// <returns></returns>
        bool ValidateMethod(string str);
    }
}
