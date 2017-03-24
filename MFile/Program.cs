using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Reflection;

namespace MFileSpace
{
    public static class Program
    {
        /// <summary>
        /// 需要定义为类变量，而非局部变量
        /// </summary>
        static System.Threading.Mutex _mutex;

        /// <summary>
        /// 当前启动目录
        /// </summary>
        public static string cur = Environment.CurrentDirectory;
        /// <summary>
        /// 配置文件名称
        /// </summary>
        public static readonly string XMLPATH = @"\config.cml";
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //是否可以打开新进程
            bool createNew;

            //获取程序集Guid作为唯一标识
            Attribute guid_attr = Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(GuidAttribute));

            string guid = ((GuidAttribute)guid_attr).Value;

            _mutex = new System.Threading.Mutex(true, guid, out createNew);

            if (!createNew)
            {
                _mutex.ReleaseMutex();
            }
            
            if (!File.Exists(cur+XMLPATH))
            {
                CMLCONFIG.Init();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MFile());
        }
       
    }
   
}