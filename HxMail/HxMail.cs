using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Windows.Forms;

namespace HXMail
{
    public partial class HxMail : Form
    {
        public HxMail()
        {
            InitializeComponent();
            //  server = "pop.126.com";
        }
        private POP pop3;//POP3操作类
        private NetworkStream ns;//网络流
        private int OldCount;//现有邮件数量
        private int NowCout;//更新后邮件数量
        private string server;//服务器地址
        private string App;//运行程序地址
        private string FromMail;
        private string FromTitle;
        #region 控件操作
        bool O = false;//开关
        const int S = 2;//Label动画移动尺寸
        private void ChangeBig(object sender, MouseEventArgs e)
        {
            if (!O)
            {
                (sender as Control).Left -= S;
                (sender as Control).Top += S;
                O = true;
            }
        }
        private void ChangeSmall(object sender, EventArgs e)
        {
            if (O)
            {
                (sender as Control).Left += S;
                (sender as Control).Top -= S;
                O = false;
            }
        }
        private void MailChange(object sender, EventArgs e)
        {
            string name = (sender as Control).Name;
            labMail.Text = "@" + name.Substring(name.IndexOf("rab") + 3) + ".com";
        }
        private void LabNext_Click(object sender, EventArgs e)
        {
            foreach (Control item in panSetA.Controls)
            {
                if (item is RadioButton&&(item as RadioButton).Checked)
                {
                    server = string.Format("pop.{0}.com", item.Name.Substring(item.Name.IndexOf("rab") + 3));
                }
            }
            if (Conn(server, txtMail.Text + labMail.Text, txtPass.Text))
            {
                Sucess(panSetA);
            }
            else MessageBox.Show("网络连接错误，或用户名密码错误", "亲");

        }
        #endregion

        private bool Conn(string Server, string user, string pass)
        {
            try
            {
                pop3 = new POP(Server, user, pass, 110);
                ns = pop3.Connect();
                if (pop3.GetNumberOfNewMessages() == "Unable")//如果登录错误
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            catch { return false; }
        }
        private void Sucess(Panel p)
        {
            p.Visible = false;
            p.Enabled = false;
        }
        //文本框全选效果
        private void TxtEnter(object sender, EventArgs e)
        {
            (sender as TextBox).SelectAll();
        }
        //选择程序
        private void labApp_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "执行程序.exe|*.exe|批程序文件.bat|*.bat";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                App = ofd.FileName;
                labApp.Text = ofd.SafeFileName;
            }
        }
        //开始检测以及验证
        private void labRun_Click(object sender, EventArgs e)
        {
            if (txtFromMail.Text == "")
                MessageBox.Show("请输入发件人", "亲");
            else if (txtTitle.Text == "")
                MessageBox.Show("请输入邮件主题", "亲");
            else if (App == "")
                MessageBox.Show("请选择执行的程序", "亲");
            else if (nudTimer.Value.ToString() == "0")
                MessageBox.Show("亲，扫描时间不可以低于0秒哦", "亲");
            else
            {
                FromMail = txtFromMail.Text;//保存发件人
                FromTitle = txtTitle.Text;//保存标题
                timerS.Interval = (int)nudTimer.Value * 1000;
                timerS.Start();
                panSetB.Visible = false;
                panSetB.Enabled = false;
            }
        }
        //间隔检测
        private void timerS_Tick(object sender, EventArgs e)
        {
            NowCout = int.Parse(pop3.GetNumberOfNewMessages());//获取当前邮件数量
            //逻辑思维： 获取当前邮件数量 ，如果当前邮件数量大于从前的邮件数量 将逐个检查邮件的内容 检测到符合标准的邮件则执行方法
            if (NowCout > OldCount)
            {
                nico.ShowBalloonTip(2000,"Qin亲", "亲，有新邮件，请查收", ToolTipIcon.Info);
                for (int i = OldCount + 1; i <= NowCout; i++)
                {
                    pop3.readMailInfo(i);
                    string[] temp = pop3.readMailInfo(i);
                    if ((temp[1] == "<" + FromMail + ">" && temp[3].Trim() == FromTitle) || temp[3].Trim()==FromTitle&&txtFromMail.Text=="All")
                    {
                        Console.WriteLine("运行进入");
                        AppRun();
                        timerS.Stop();
                        End();
                    }
                }
                OldCount = NowCout;//更新完成
            }
        }
        //运行程序代码
        private void AppRun()
        {
            Process.Start(App);
        }
        //检测后程序结束
        private void End()
        {
            Application.Exit();
        }

        private void labH_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
            this.Hide();
        }

        private void nico_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.ShowInTaskbar = true;
            this.Show();
        }

    }
}
