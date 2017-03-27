using a_little_ant.model;
using System;
using System.Collections.Generic;
using System.Windows;

namespace a_little_ant
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ant_core = new Core();
        }

        /// <summary>
        /// 开始
        /// </summary>
        public void Start()
        {
            ant_core.First_Configuration();
            ant_core.Second_Ready();
            ant_core.Third_Start(txt_input.Text);
            App.Current.Dispatcher.Invoke(new Action(delegate() { (App.Current.MainWindow as MainWindow).webctl.NavigateToString(Outputer.oldweb); }));
        }

        /// <summary>
        /// 获取或设置 核心
        /// </summary>
        public Core ant_core { get; set; }

        /// <summary>
        /// 开始抓取
        /// </summary>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Start();
        }
    }

    public static class Outputer
    {
        public static Action<object> action = p_Output;
        public static void Output(object d)
        {
            App.Current.Dispatcher.BeginInvoke(action, d);
        }
        public static string oldweb;
        public static void ToWeb(string web)
        {
            oldweb += Environment.NewLine + web;
        }
        private static void p_Output(object d)
        {
            (App.Current.MainWindow as MainWindow).txt_output.AppendText(d + Environment.NewLine);
        }
        private static List<NoteInfo> list = new List<NoteInfo>();
        internal static void Add(NoteInfo ni)
        {
            list.Add(ni);
        }
    }
}