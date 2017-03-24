using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dzmrap.Validation
{
    public interface ICommon
    {
        /// <summary>
        /// 输入认证号验证
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        bool Validate(string str);
        /// <summary>
        /// 输入认证号获得使用时长
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        int GetTimespan(string str);
        /// <summary>
        /// 获得服务器时间
        /// </summary>
        /// <returns></returns>
        DateTime GetServerTime();
    }
}
