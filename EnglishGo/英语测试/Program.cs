using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace 英语测试
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmMain fm;
            if (args.Length>0)
                fm = new FrmMain(args[0]);
            else
                fm = new FrmMain();
            Application.Run(fm);
        }
    }
}
