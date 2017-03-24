using Dzmrap.Core.Models;
using Dzmrap.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Dzmrap
{
    /// <summary>
    /// MAScriptView.xaml 的交互逻辑
    /// </summary>
    public partial class MAScriptView : Window, System.ComponentModel.INotifyPropertyChanged
    {
        KeyMonitoringService kms;
        public MAScriptView()
        {
            InitializeComponent();

            Dictionary<string, Action> dic = new Dictionary<string, Action>();
            dic.Add("F5", delegate()
            {
                btn_Execute_Click(null, null);
            });
            dic.Add("F8", delegate()
            {
                btn_Stop_Click(null, null);
            });
            kms = new KeyMonitoringService(dic);
        }

        /// <summary>
        /// 动作列表 属性字段
        /// <para>关联属性: Actions</para>
        /// </summary>
        private ActionList _actions;
        /// <summary>
        /// 动作列表
        /// </summary>
        public ActionList Actions
        {
            get { return _actions; }
            set { _actions = value; if (PropertyChanged != null)PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs("Actions")); }
        }

        /// <summary>
        /// 显示动作脚本
        /// </summary>
        /// <param name="al">动作列表对象</param>
        public static void ShowScript(ActionList al)
        {
            MAScriptView view = new MAScriptView();
            view.Actions = al.CloneEx();
            view.ShowDialog();
        }
     
        /// <summary>
        /// 执行
        /// </summary>
        /// <param name="sender">事件源</param>
        /// <param name="e"><see cref="RoutedEventArgs"/> 事件参数</param>
        private void btn_Execute_Click(object sender, RoutedEventArgs e)
        {
            Actions.Play();
        }

        /// <summary>
        ///  导出
        /// </summary>
        /// <param name="sender">事件源</param>
        /// <param name="e"><see cref="RoutedEventArgs"/> 事件参数</param>
        private void btn_Export_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.SaveFileDialog sfd = new System.Windows.Forms.SaveFileDialog();
            sfd.Title = "导出动作脚本文件";
            sfd.DefaultExt = ".mas";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Actions.Save(sfd.FileName);
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        private void btn_WhileExecute_Click(object sender, RoutedEventArgs e)
        {
            Actions.PlayLoop();
        }

        private void btn_Stop_Click(object sender, RoutedEventArgs e)
        {
            Actions.Stop();
        }

        private void window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            kms.UnInit();
        }
    }
}
