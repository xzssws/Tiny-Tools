using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace 生成类
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public Dictionary<string, string> Mem = new Dictionary<string, string>();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtclass.Text != string.Empty)
            {
                if (cmbType.SelectedIndex != -1)
                {
                    if (txtMem.Text != string.Empty)
                    {
                        try
                        {
                            Mem.Add(txtMem.Text, cmbType.Text);
                            BangDing();
                            cmbType.SelectedIndex = 0;
                            txtMem.Text = "";
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("已经存在的属性");
                        }
                      
                    }
                    else
                    {
                        MessageBox.Show("请填入属性名称", "温馨提示：");
                    }
                }
                else
                {
                    MessageBox.Show("亲，请选择您的属性类型", "温馨提示：");
                }
            }
            else
            {
                MessageBox.Show("亲，请输入类名哦！", "温馨提示：");
            }
        }
        public void BangDing()
        {
            lvShow.Items.Clear();
            foreach (var item in Mem)
            {
                ListViewItem lvi = new ListViewItem(item.Key);
                lvi.ImageIndex = 0;
                lvi.SubItems.Add(item.Value);
                lvShow.Items.Add(lvi);
            }
        }

        /// <summary>
        /// 自动生成实体类代码
        /// </summary>
        /// <param name="classname"> 类名</param>
        /// <param name="dc">字典型 key 属性名称 value 类型</param>
        /// <returns>生成的字符串代码</returns>
        public string AutoClass (string classname, Dictionary<string, string> dc)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("public class " + classname + Environment.NewLine + "{" +Environment.NewLine);
            foreach (var item in dc)
            {
                sb.AppendLine("    private " + item.Value + " _" + item.Key + " ;" +Environment.NewLine);
                sb.AppendLine("    public " + item.Value + " " + item.Key + Environment.NewLine + "    {" + Environment.NewLine + "        get { return " + "_" + item.Key + "; }" + Environment.NewLine + "        set { " + item.Key + " = value; }" + Environment.NewLine + "    }");
            }
            sb.AppendLine(Environment.NewLine + "}");
            return sb.ToString();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (Mem.Count>0)
            {
                using (FileStream fs = new FileStream(txtclass.Text + ".cs", FileMode.Create))
                {
                    string str = AutoClass(txtclass.Text, Mem);
                    byte[] by = Encoding.Default.GetBytes(str.ToCharArray(), 0, str.Length);
                    fs.Write(by, 0, by.Length);
                    if (DialogResult.Yes == MessageBox.Show("生成成功 是否打开文件夹?", "温馨提示：", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                    {
                        Process.Start("explorer", Environment.CurrentDirectory);
                    }
                    txtclass.Text = "";
                    txtMem.Text = "";
                    cmbType.SelectedIndex = -1;
                    Mem.Clear();
                    lvShow.Items.Clear();
                }
            }
            else
            {
                MessageBox.Show("当前实体类中没有属性？","温馨提示");
            }
        }
    }
}
