using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace 英语测试
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        public FrmMain(string src)
        {
            InitializeComponent();
            try
            {
                this.wordList = EnglishList.GetEnglishList(src);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #region 属性信息
        private Dictionary<string, string> wordList = null;//单词表
        private List<string> tempWordList = null;//临时集合打包单词表键值
        private int rightNum;//正确数量
        private int Sumed;//已答数量
        private Dictionary<string, string> wordAnnal = null;//记录表 
        #endregion


        private void labGo_Click(object sender, EventArgs e)
        {
            if (wordList != null)//若单词表不是空
            {
                pnlD.Visible = false;//消失
                tempWordList = wordList.Keys.ToList<string>(); //初始化考单词集合
                labCount.Text = (tempWordList.Count).ToString();//初始化单词表词数
                rightNum = 0;//初始化正确值
                Sumed = 0;//初始化已答数量
                wordAnnal = new Dictionary<string, string>();//创建记录
                UpdateWord();//更新单词 
            }
            else { MessageBox.Show("请选择单词表","亲亲小管家"); }
        }

        private void labClose_Click(object sender, EventArgs e)
        {
            Application.Exit();//关闭程序
        }

        private void txtInner_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (tempWordList.Count>0)//如果
                {
                    if (e.KeyValue == 13)
                    {
                        Sumed++;//答题数量增加
                        wordAnnal.Add(labC.Text, txtInner.Text == "" ? "NULL" : txtInner.Text.ToLower());//增加记录
                        rightNum+=txtInner.Text.ToLower() == wordList[labC.Text].ToLower()?1:0;//经过简化 判断单词是否正确并更新至变量
                        UpdateWord();//更新词汇 
                    }
                }
                else if (tempWordList.Count==0)
                {
                    if (e.KeyValue == 13)
                    {
                        Sumed++;//答题数量增加
                        wordAnnal.Add(labC.Text, txtInner.Text == "" ? "NULL" : txtInner.Text.ToLower());//增加记录
                        rightNum += txtInner.Text.ToLower() == wordList[labC.Text].ToLower() ? 1 : 0;//经过简化 判断单词是否正确并更新至变量
                        labS.Text = Sumed.ToString();//已答数量
                        labTrue.Text = rightNum.ToString();//正确数量
                        labError.Text = (int.Parse(labS.Text) - rightNum).ToString();//错误数量
                        Table t = new Table(wordAnnal, wordList);//创建成绩单对象
                        t.ShowDialog();//模式化打开成绩单窗口
                        labCount.Text = labTrue.Text = labError.Text = labS.Text = "";
                        pnlD.Visible = true;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"亲亲小管家：",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 记录当前成绩 更新单词
        /// </summary>
        private void UpdateWord()
        {
            //BUG出现处
            labS.Text = Sumed.ToString();//已答数量
            labTrue.Text = rightNum.ToString();//正确数量
            labError.Text = (int.Parse(labS.Text) - rightNum).ToString();//错误数量
            int da = new Random().Next(0, tempWordList.Count);//随机数
            labC.Text = tempWordList[da];//取出随机值
            tempWordList.RemoveAt(da);//删除选定值 
            txtInner.Text = "";
        }

        #region 移动窗体
        [DllImport("user32.dll")]
        static extern bool ReleaseCapture();//加载外部文件User32.dll中的方法 ReleaseCapture（）  
        [DllImport("user32.dll")]
        static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int IParam);//加载外部文件User32.dll文件中的SendMessage方法
        public static void 移动窗体(IntPtr 当前窗体句柄)
        {
            ReleaseCapture();//调用方法 未知？？
            SendMessage(当前窗体句柄, 0x0112, 0xf010 + 0x0002, 0);//实现移动 未知？？
        }

        private void FrmMain_MouseDown(object sender, MouseEventArgs e)
        {
            移动窗体(this.Handle);
        } 
        #endregion

        private void btnOption_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "单词表文件.wrd|*.wrd";
            if (ofd.ShowDialog()==DialogResult.OK)
            {
                wordList=EnglishList.GetEnglishList(ofd.FileName);
            }
        }

    }
}
