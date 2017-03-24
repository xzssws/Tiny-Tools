using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace JL计划书
{
    class Helper
    {
        /// <summary>
        /// 获取INI文件的节点值
        /// </summary>
        /// <param name="lpAppName">文件节点名称</param>
        /// <param name="lpKeyName">项名称</param>
        /// <param name="lpDefault">没有找到指定项时返回的默认值</param>
        /// <param name="lpReturnedString">字符缓冲区接收数据</param>
        /// <param name="nSize">输入缓冲区最大数值</param>
        /// <param name="lpFileName">文件路径</param>
        /// <returns>复制到字符缓冲区的字节数量</returns>
        [DllImport("kernel32")]
        internal static extern int GetPrivateProfileString(string lpAppName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString, int nSize, string lpFileName);
        /// <summary>
        /// 重写INI内容
        /// </summary>
        /// <param name="lpAppName">选定节点名册很难</param>
        /// <param name="lpKeyName">选定项</param>
        /// <param name="lpString">写入值</param>
        /// <param name="lpFileName">文件名称</param>
        /// <returns>0失败 非0成功</returns>
        [DllImport("kernel32")]
        internal static extern long WritePrivateProfileString(string lpAppName, string lpKeyName, string lpString, string lpFileName);
    }
}
