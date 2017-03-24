﻿using System.Collections.Generic;
using System.Windows;
using BuildData.DataConfig;
using System.Text.RegularExpressions;
using System.Windows.Controls;
using System;

namespace BuildData
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            ConfigHelp = new DataConfig.DataConfigHelp();
            this.DataContext = ConfigHelp.PublicConfig;
            InitializeComponent();
            Load();
        }

        #region 数据集合

        private Dictionary<string, Flag> flags = new Dictionary<string, Flag>();

        public Dictionary<string, Flag> Flags
        {
            get { return flags; }
            set { flags = value; }
        }

        public void Load()
        {
            flags.Add("地址", Flag.Address);
            flags.Add("年龄", Flag.Age);
            flags.Add("姓名", Flag.Name);
            flags.Add("电话", Flag.Phone);
            flags.Add("生日", Flag.Birth);
            flags.Add("QQ", Flag.QQ);
            flags.Add("编号", Flag.Num);
            flags.Add("性别", Flag.Sex);
            flags.Add("密码", Flag.Pwd);
            flags.Add("用户自定义", Flag.Customer);
            flags.Add("GUID", Flag.GUID);
            flags.Add("现在时间", Flag.NowTime);
            flags.Add("今天日期", Flag.ToDay);
            //TODO:数据还应该有个自动序号
        }

        #endregion 数据集合

        #region 字段属性

        /// <summary>
        /// 帮助
        /// </summary>
        private DataConfig.DataConfigHelp ConfigHelp;

        public DataConfig.DataConfigHelp Help
        {
            get { return ConfigHelp; }
            set { ConfigHelp = value; }
        }

        /// <summary>
        /// 配置
        /// </summary>
        public DataConfig.DataConfig Config
        {
            get { return ConfigHelp.PublicConfig; }
        }

        #endregion 字段属性

        //生成预览
        private void BuildFile(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            ConfigHelp.SaveOut();
            watch.Stop();
            double result = (double)watch.ElapsedMilliseconds;
            MessageBox.Show("生成时间:" + result + "毫秒");
        }

        /// <summary>
        /// 添加标记
        /// </summary>
        private void AddFlags(object sender, RoutedEventArgs e)
        {
            KeyValuePair<string, Flag> kv = (KeyValuePair<string, Flag>)cmbType.SelectedItem;
            if (kv.Value == Flag.Customer)
            {
                Config.Flags.Add("$" + txtFlagName.Text, kv.Value);
                AutoDataHelp.customerData.Add("$" + txtFlagName.Text, customerData);
            }
            else
            {
                Config.Flags.Add("$" + txtFlagName.Text, kv.Value);
            }
            FlagsBox.ItemsSource = null;
            FlagsBox.ItemsSource = Config.Flags;

            cmbType.SelectedIndex = -1;
            txtFlagName.Text = "";
        }
        /// <summary>
        /// 利用正则表达式验证字符串
        /// </summary>
        /// <param name="psStr">字符串</param>
        /// <param name="reg">正则表达式</param>
        /// <returns></returns>
        public static bool CheckStr(string psStr, string reg)
        {
            Regex myReg = new Regex(reg);
            Match m = myReg.Match(psStr);
            return m.Success;
        }
        /// <summary>
        /// 匹配字母
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        public static bool CheckZimu(string txt)
        {
            return CheckStr(txt, "^[A-Za-z]+$");
        }
        public static bool CheckInt(string txt)
        {
            return CheckStr(txt, "^[0-9]+$");
        }

        private void txtCount_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            //屏蔽中文输入和非法字符粘贴输入
            TextBox textBox = sender as TextBox;
            NoChange(textBox, e, t => { int i = 0; return Int32.TryParse(t, out i); });
        }
        private void NoChange(TextBox textBox, TextChangedEventArgs e, Func<string, bool> result)
        {
            //获得变更
            TextChange[] change = new TextChange[e.Changes.Count];
            //拷贝变更
            e.Changes.CopyTo(change, 0);
            //获取发生变更位置
            int offset = change[0].Offset;
            //如果发生变更
            if (change[0].AddedLength > 0)
            {
                if (!result(textBox.Text))
                {
                    //取消变更
                    textBox.Text = textBox.Text.Remove(offset, change[0].AddedLength);
                    //取消变更
                    textBox.Select(offset, 0);
                }
            }
        }

        private void txtFlagName_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            NoChange(textBox, e, t => CheckStr(t, "^[A-Za-z]+$") && t.Length < 7);
        }

        private void txtPath_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            NoChange(textBox, e, t => !System.IO.File.Exists(t));
        }
        System.Windows.Forms.SaveFileDialog ofd = new System.Windows.Forms.SaveFileDialog();
        private void btnSavePath_Click(object sender, RoutedEventArgs e)
        {
            ofd.FileName = "BuildFile.txt";
            ofd.Filter = "文本文件|*.txt";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Config.SavePath = ofd.FileName;
                this.txtPath.Text = ofd.FileName;
            }
        }

        /// <summary>
        /// 临时的用户数据 添加时用
        /// </summary>
        private AutoData.CustomerData<string> customerData;

        //选择自定义数据后弹出一个窗体
        private void cmbType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbType.SelectedItem != null)
            {
                KeyValuePair<string, Flag> kv = (KeyValuePair<string, Flag>)cmbType.SelectedItem;
                if (kv.Value == Flag.Customer)
                {
                    AddCustomer add = new AddCustomer();
                    if ((bool)add.ShowDialog())
                    {
                        customerData = add.customerData;
                    }
                }
            }
        }


    }
}