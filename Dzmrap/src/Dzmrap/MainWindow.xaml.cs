using Dzmrap.Core.Models;
using Dzmrap.Core.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows;
using System.Windows.Forms;

namespace Dzmrap
{
    /// <summary>
    /// CheckWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// 初始化 <see cref="MainWindow"/>类的新实例。
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            Dictionary<string, Action> dic = new Dictionary<string, Action>();
            dic.Add("F9", delegate()
            {
                Record(null, null);
            });
            dic.Add("F10", delegate()
            {
                Stop(null, null);
            });
            KeyMonitoringService kms = new KeyMonitoringService(dic);
            InitNotifyIcon();
        }

        /// <summary>
        /// 托盘图标对象
        /// </summary>
        private NotifyIcon notifyIcon;

        /// <summary>
        /// 鼠标录制服务
        /// </summary>
        private MouseMonitoringService mms = new MouseMonitoringService();

        Icon ico_default = new Icon(@"Icos\default.ico");
        Icon ico_start = new Icon(@"Icos\start.ico");
        Icon ico_stop = new Icon(@"Icos\stop.ico");

        /// <summary>
        /// 初始化托盘图标
        /// </summary>
        public void InitNotifyIcon()
        {
            this.notifyIcon = new NotifyIcon();
            this.notifyIcon.Text = "Dzmrap";
            this.notifyIcon.Icon = ico_default;
            this.notifyIcon.Visible = true;
            //打开菜单项
            System.Windows.Forms.ContextMenu cm = new System.Windows.Forms.ContextMenu();
            cm.MenuItems.Add("录制(F9)", Record);
            cm.MenuItems.Add("停止(F10)", Stop);
            cm.MenuItems.Add("加载脚本", Import);
            cm.MenuItems.Add("帮助", Help);
            cm.MenuItems.Add("退出", Exit);
            notifyIcon.ContextMenu = cm;
            this.Hide();
        }

        #region 托盘图标选项

        /// <summary>
        /// 托盘图标 - 退出选项
        /// </summary>
        /// <param name="sender">事件源</param>
        /// <param name="e"><see cref="EventArgs"/> 事件参数</param>
        public void Exit(object sender, EventArgs e)
        {
            App.Current.Shutdown();
        }

        /// <summary>
        /// 托盘图标 - 录制选项
        /// </summary>
        /// <param name="sender">事件源</param>
        /// <param name="e"><see cref="EventArgs"/> 事件参数</param>
        public void Record(object sender, EventArgs e)
        {
            if (!mms.IsRun)
            {
                mms.Run();
                this.notifyIcon.Text = "录制中...";
                this.notifyIcon.Icon = ico_start;
            }
        }

        /// <summary>
        /// 托盘图标 - 停止选项
        /// </summary>
        /// <param name="sender">事件源</param>
        /// <param name="e"><see cref="EventArgs"/> 事件参数</param>
        public void Stop(object sender, EventArgs e)
        {
            if (mms.IsRun)
            {
                mms.Stop();
                this.notifyIcon.Text = "脚本预览...";
                this.notifyIcon.Icon = ico_stop;
                MAScriptView.ShowScript(mms.ActionList);
                this.notifyIcon.Icon = ico_default;
                this.notifyIcon.Text = "Dzmrap";
            }
        }

        /// <summary>
        /// 托盘图标 - 导入选项
        /// </summary>
        /// <param name="sender">事件源</param>
        /// <param name="e"><see cref="EventArgs"/> 事件参数</param>
        public void Import(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ActionList actions = ActionList.Load(ofd.FileName);
                MAScriptView.ShowScript(actions);
            }
        }

        /// <summary>
        /// 托盘图标 - 帮助选项
        /// </summary>
        /// <param name="sender">事件源</param>
        /// <param name="e"><see cref="EventArgs"/> 事件参数</param>
        public void Help(object sender, EventArgs e)
        {
            About ab = new About();
            ab.ShowDialog();
        }
        #endregion 托盘图标选项
    }
}