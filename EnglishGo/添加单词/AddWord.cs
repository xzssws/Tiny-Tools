using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.InteropServices;

namespace 添加单词
{
    public partial class AddWord : Form
    {
        public AddWord()
        {
            InitializeComponent();
        }
        private Dictionary<string, string> dic = new Dictionary<string, string>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //先判断不能为空 再判断不能有相同值
            if (txtUnpuzzle.Text != "" && txtWord.Text != "")
            {
                if (Tong(txtUnpuzzle.Text, txtWord.Text))
                {
                    dic.Add(txtUnpuzzle.Text.ToLower().Trim(), txtWord.Text.ToLower().Trim());//添加进集合
                    txtUnpuzzle.Text = txtWord.Text = "";
                    BindLv(dic);//绑定
                }
                else { labInfo.Text = "单词表中不允许出现相同的单词以及解释"; }
            }
            else { labInfo.Text = "亲，请把单词以及解释填写完整"; }
        }

        /// <summary>
        /// 判断集合中过是否有相同项
        /// </summary>
        /// <param name="Unpuzzle">解释</param>
        /// <param name="key">单词</param>
        /// <returns>布尔</returns>
        public bool Tong(string Unpuzzle, string key)
        {
            foreach (var item in dic)
            {
                if (Unpuzzle == item.Key || key == item.Value)
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// 绑定集合到列表
        /// </summary>
        /// <param name="dc">将绑定的集合</param>
        public void BindLv(Dictionary<string, string> dc)
        {
            lvShow.Items.Clear();//清空
            foreach (var item in dc)
            {
                ListViewItem lvi = new ListViewItem(item.Value);
                lvi.SubItems.Add(item.Key);
                lvShow.Items.Add(lvi);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dic.Count != 0)
            {
                /*二进制保存*/
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.FileName = "新单词表";
                sfd.Filter = "单词表文件|*.wrd";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(sfd.FileName, FileMode.Create))
                    {
                        new BinaryFormatter().Serialize(fs, dic);
                    }
                }
            }
            else
            {
                labInfo.Text = "亲，不要偷懒哦，最少添加一个单词记录,才能导出";
            }
        }
        #region 移动窗体代码
        [DllImport("user32.dll")]
        static extern bool ReleaseCapture();//加载外部文件User32.dll中的方法 ReleaseCapture（）  
        [DllImport("user32.dll")]
        static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int IParam);//加载外部文件User32.dll文件中的SendMessage方法
        public static void 移动窗体(IntPtr 当前窗体句柄)
        {
            ReleaseCapture();//调用方法 未知？？
            SendMessage(当前窗体句柄, 0x0112, 0xf010 + 0x0002, 0);//实现移动 未知？？
        }

        private void YMove(object sender, MouseEventArgs e)
        {
            移动窗体(this.Handle);
        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
