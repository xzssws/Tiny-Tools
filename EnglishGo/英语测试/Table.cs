using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace 英语测试
{
    public partial class Table : Form
    {
        private int i = 0;
        private Dictionary<string, string> dc;
        private Dictionary<string, string> dl;
        public Table(Dictionary<string, string> d1, Dictionary<string, string> d2)
        {
            InitializeComponent();
            dc = d1; dl = d2;
            foreach (var item in dc)
            {
                ListViewItem dd = new ListViewItem(i.ToString());
                dd.SubItems.Add(item.Key.ToLower());//添加题目
                dd.SubItems.Add(item.Value);//添加输入
                dd.SubItems.Add(d2[item.Key] == item.Value ? "√" : "×");//判断对错
                dd.SubItems.Add(d2[item.Key].ToLower());//添加正确答案
                listView1.Items.Add(dd);//在列表中添加项
                i++;
            }
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void Table_MouseDown(object sender, MouseEventArgs e)
        {
            FrmMain.移动窗体(this.Handle);
        }

        private void btnExp_Click(object sender, System.EventArgs e)
        {
            i = 0;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "成绩单";
            sfd.Filter = "记事本文件|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(sfd.FileName, FileMode.Create))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("序号\t题目\t输入\t结果\t答案");
                    sb.AppendLine("------------------------------------------");
                    foreach (var item in dc)
                    {
                        sb.AppendLine(i.ToString() + "\t" + item.Key.ToLower() + "\t" + item.Value + "\t" + (dl[item.Key] == item.Value ? "√" : "×") + "\t" + dl[item.Key].ToLower());
                        i++;
                    }
                    byte[] b = new byte[1024];
                    b = Encoding.Default.GetBytes(sb.ToString());
                    fs.Write(b, 0, b.Length);
                }
            }
            this.Close();
        }

    }
}
