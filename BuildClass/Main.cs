using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ������
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
                            MessageBox.Show("�Ѿ����ڵ�����");
                        }
                      
                    }
                    else
                    {
                        MessageBox.Show("��������������", "��ܰ��ʾ��");
                    }
                }
                else
                {
                    MessageBox.Show("�ף���ѡ��������������", "��ܰ��ʾ��");
                }
            }
            else
            {
                MessageBox.Show("�ף�����������Ŷ��", "��ܰ��ʾ��");
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
        /// �Զ�����ʵ�������
        /// </summary>
        /// <param name="classname"> ����</param>
        /// <param name="dc">�ֵ��� key �������� value ����</param>
        /// <returns>���ɵ��ַ�������</returns>
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
                    if (DialogResult.Yes == MessageBox.Show("���ɳɹ� �Ƿ���ļ���?", "��ܰ��ʾ��", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
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
                MessageBox.Show("��ǰʵ������û�����ԣ�","��ܰ��ʾ");
            }
        }
    }
}
