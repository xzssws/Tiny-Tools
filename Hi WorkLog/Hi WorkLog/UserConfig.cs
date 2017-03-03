using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi_WorkLog
{
    /// <summary>
    /// 用户配置类
    /// </summary>
    [Serializable]
    public class UserConfig
    {
        /// <summary>
        /// 获取或设置父工作项ID
        /// </summary>
        public int ParentID { get; set; }
        /// <summary>
        /// 获取或设置 URL
        /// </summary>
        public string URL { get; set; }
        /// <summary>
        /// 获取或设置用户名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 获取或设置密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 获取或设置项目名称
        /// </summary>
        public string ProjectName { get; set; }
    }
}
