using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace 风影浏览器
{
    public partial class FengYing : Form
    {
        /// <summary>
        /// 构造方法
        /// </summary>
        public FengYing()
        {
            InitializeComponent();
            init();

        }
        /// <summary>
        /// 浏览器历史记录
        /// </summary>
        List<string> lsAddress = new List<string>();
        /// <summary>
        /// 当前操作浏览器
        /// </summary>
        WebBrowser wb;

        #region 浏览器主功能
        /// <summary>
        /// 浏览器上一页
        /// </summary>
        /// <param name="wb"></param>
        public void GoBack(WebBrowser wb)
        {
            wb.GoBack();
        }
        /// <summary>
        /// 浏览器下一页
        /// </summary>
        /// <param name="wb"></param>
        public void GoNext(WebBrowser wb)
        {
            wb.GoForward();
        }
        /// <summary>
        /// 浏览器转到特定页
        /// </summary>
        /// <param name="wb">浏览器对象</param>
        /// <param name="URL">地址</param>
        /// <returns>打开的地址</returns>
        public string GoUrl(WebBrowser wb, string URL)
        {
            string uri = "";//网页地址
            if (URL.Length>8&&URL.Contains("http://")||URL.Contains("www.") && URL.Contains(".com"))
            {
                uri = URL.Substring(0, 7).Contains("http://") ? URL : "http://" + URL;//判断是否手动输入网页如果不是则加上协议头  可更新！ 还有FTP协议。。
            }
            else
            {
                uri = "http://www.baidu.com/s?wd=" + URL;
            }
            wb.Navigate(uri);//打开新窗口方式
            return uri;
        }

        /// <summary>
        /// 返回主页
        /// </summary>
        /// <param name="wb">控件对象</param>
        public void GoHome(WebBrowser wb)
        {
            wb.GoHome();
        }
        #endregion

        #region 浏览器主功能激活事件
        /// <summary>
        /// 返回上一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void GoBack(object sender, EventArgs e)
        {
            GoBack(wb);
        }
        /// <summary>
        /// 前进
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void GoNext(object sender, EventArgs e)
        {
            GoNext(wb);
        }
        /// <summary>
        /// 返回主页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void GoHome(object sender, EventArgs e)
        {
            GoHome(wb);
        }
        /// <summary>
        /// 打开网址
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)//如果敲了回车
            {
                string url = GoUrl(wb, labHome.Text);//跳到敲入页面
                labHome.Text = url;//显示在地址栏
                labHome.Items.Add(url);//在下拉项中数组添加输入地址 用于自动完成
                lsAddress.Add(url);
            }
        }
        #endregion

        /// <summary>
        /// 当标签容器更换标签时发生 将网页标题显示在标签上 网页的地址显示在地址栏上
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WebPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            wb = labNext.SelectedTab.Controls.OfType<WebBrowser>().First();//当选择标签页的时候当前页等于标签页
            wb.Parent.Text = wb.DocumentTitle.Length > 8 ? wb.DocumentTitle.Substring(0, 8) + "..." : wb.DocumentTitle;
            labHome.Text = wb.Url.ToString();
        }

        /// <summary>
        /// 初始化工作窗体
        /// </summary>
        public void init()
        {
            wb = this.WebHead;
            wb.NewWindow += Wb_NewWindow;
        }
        /// <summary>
        /// 创建新标签网页代码
        /// </summary>
        private void CreateTabPage4W()
        {
            TabPage t = new TabPage("页面加载中...");//一个新的标签页
            t.ImageIndex = 0;
            WebBrowser w = new WebBrowser();//一个新的浏览页面对象
            t.Controls.Add(w);//把浏览器添加到新的标签页
            w.ScrollBarsEnabled = true;//显示轮动条
            w.Dock = DockStyle.None;//不设置停靠 WebBrowser默认为Fill
            w.Location = new System.Drawing.Point(0, 22);//设置位置
            w.ScriptErrorsSuppressed = false;//设置不提示javascript脚本错误
            w.Size = new System.Drawing.Size(w.Parent.Width, w.Parent.Height - 30);//设置控件大小
            w.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)| System.Windows.Forms.AnchorStyles.Left)| System.Windows.Forms.AnchorStyles.Right)));//设置控件绑定边
            w.DocumentCompleted += Wb_DocumentCompleted;//添加加载完成事件
            w.NewWindow += Wb_NewWindow;//添加新窗口事件
            labNext.Controls.Add(t);//添加到标签区域
            GoUrl(w, wb.StatusText);//更新网址
            wb = w;//转换当前网址
            
        }
        /// <summary>
        /// 设置新的WebBrowser控件的加载完成方法~  更改父容器的Text属性为当前页面的Title
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            (wb.Parent as TabPage).ImageIndex = 1;
            wb.Parent.Text = wb.DocumentTitle.Length > 8 ? wb.DocumentTitle.Substring(0, 8) + "..." : wb.DocumentTitle;//标签显示网址 如果网址标题超过8位则隐藏
            labNext.SelectedTab = (wb.Parent as TabPage);//设置标签容器选择新建标签页
        }
        public void Wb_NewWindow(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            if (wb.StatusText != "")
            {
                CreateTabPage4W();
            }
        }

    }
}
