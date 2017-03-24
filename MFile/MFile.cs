using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace MFileSpace
{
    public partial class MFile : Form
    {
        public MFile()
        {
            InitializeComponent();
        }

        #region 自定义方法
        /// <summary>
        /// 窗体加载配置并显示方法
        /// </summary>
        public void LoadConfig()
        {
            try
            {
                //初始化XML配置
                cmlConfig = CMLCONFIG.CreateXmlConfig;
                //加载文档  此处应该修改 当文档为空的时候 一个样子
                cmlConfig.Load();
                AutoButton();
                //labClearConfig.Enabled = cmlConfig.EasyFilecg.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "加载配置错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /// <summary>
        /// 寻找配置初始化列表
        /// </summary>
        private void AutoButton()
        {

            flpButton.Controls.Clear();

            foreach (PathConfig cc in cmlConfig.EasyFilecg)
            {
                CopyItem copyItem = new CopyItem(cc);
                copyItem.Size = new System.Drawing.Size(278, 69);
                //TODO:遍历的时候 Button替换成新的控件 
                #region 事件
                copyItem.FileMoved += new FileEx.Moved(fe_FileMoved);
                copyItem.IsCopy += new FileEx.FgMessage(fe_MessageFg);
                copyItem.DeleteClick += new EventHandler(fe_Delete);
                

                #endregion
                flpButton.Controls.Add(copyItem);

                AutoMenu();
            }
        }

        void fe_Delete(object sender, EventArgs e)
        {
            cmlConfig.Delete(sender as PathConfig);
           LoadConfig();
        }

        private void AutoMenu()
        {
            ContextMenuFileMove.DropDownItems.Clear();
            foreach (PathConfig cc in cmlConfig.EasyFilecg)
            {
                ToolStripMenuItem ToolMenuItem = new ToolStripMenuItem(cc.Title);
                #region 样式
                ToolMenuItem.Size = new System.Drawing.Size(152, 22);
                #endregion
                #region 特性
                ToolMenuItem.Tag = cc;
                //this.ToolTipMessage.SetToolTip(ToolMenuItem, string.Format("标题:{0}\n文件:{1}\n目录:{2}\n", cc.Title, cc.FilePathSource, cc.DirectoryPath));
                #endregion
                #region 事件
                ToolMenuItem.Click += new EventHandler(MoveFile);
                #endregion
                ContextMenuFileMove.DropDownItems.Add(ToolMenuItem);
            }

        }
        /// <summary>
        /// 根据全路径获取文件或目录名称
        /// </summary>
        /// <param name="FullName">全路径</param>
        /// <returns>文件或目录名称</returns>
        public string GetName(string FullName)
        {
            if (FullName.Length > 4)
            {
                int i = FullName.LastIndexOf(@"\");
                return FullName.Substring(i, FullName.Length - i).TrimStart("\\".ToCharArray());
            }
            else
            {
                return FullName;
            }
        }
        /// <summary>
        /// 判断文件是否可移动 太大
        /// </summary>
        /// <param name="filename">文件名称</param>
        /// <returns>是否可移动</returns>
        public bool ValidateFile(string filename)
        {
            FileInfo fi = new FileInfo(filename);
            if (fi.Length > 1024 * 1024 * 10)
            {
                MessageBox.Show("砖头太大了，搬不动！");
                return false;
            }
            return true;

        }

        //判断路径
        private bool SetOK()
        {
            if (!(string.IsNullOrEmpty(pc.FilePathSource) || string.IsNullOrEmpty(pc.DirectoryPath)))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        #endregion

        #region 字段属性

        /// <summary>
        /// CML配置帮助
        /// </summary>
        CMLCONFIG cmlConfig;

        /// <summary>
        /// 路径配置对象
        /// </summary>
        PathConfig pc;

        /// <summary>
        /// 信息
        /// </summary>
        public string Message
        {
            set { labMessage.Text = value; }
        }

        #endregion

        #region 单击事件


        //关闭按钮
        private void labClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //添加到集合
        private void AddPathConfig(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(pc.FilePathSource)) throw new Exception("尚未选择复制文件");
                if (string.IsNullOrEmpty(pc.DirectoryPath)) throw new Exception("尚未选择目标文件夹");

                pc.Title = "复制:" + GetName(pc.FilePathSource);

                cmlConfig.AddSave(pc);
                pc = null;
                //创建按钮
                AutoButton();

                //显示信息
                Message = "添加配置成功!";
            }
            catch (Exception ex)
            {
                Message = "添加配置错误!" + ex.Message;
                MessageBox.Show("添加配置错误!" + ex.Message);
            }
        }
        //重置设置
        private void ClearConfig(object sender, EventArgs e)
        {

            if (MessageBox.Show("是否要清空配置", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    cmlConfig.Reset();
                    AutoButton();
                    pc = null;

                    Message = "清空配置成功!";
                    (sender as Control).Enabled = false;
                }
                catch (Exception ex)
                {
                    Message = "重置设置错误!" + ex.Message;
                }
            }
        }
        //选择文件
        private void btnFile_Click(object sender, EventArgs e)
        {
            if (pc == null)
                pc = new PathConfig();

            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //判断文件是否过大
                if (!ValidateFile(ofd.FileName)) return;

                pc.FilePathSource = ofd.FileName;

                Message = "文件选择完成" + pc.FilePathSource;
            }
        }
        //选择目录
        private void btnDir_Click(object sender, EventArgs e)
        {
            if (pc == null)
                pc = new PathConfig();

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                pc.DirectoryPath = fbd.SelectedPath;
                Message = "目录选择完成!" + pc.DirectoryPath;
            }
        }
        //复制文件
        public void MoveFile(object sender, EventArgs e)
        {
            try
            {
                FileEx fe;
                PathConfig fc;
                if (sender is ToolStripMenuItem)
                {
                    fc = (sender as ToolStripMenuItem).Tag as PathConfig;
                }
                else
                {
                    fc = (sender as Button).Tag as PathConfig;
                }
                fe = new FileEx(fc);
                fe.FileMoved += new FileEx.Moved(fe_FileMoved);
                fe.MessageFg += new FileEx.FgMessage(fe_MessageFg);
                fe.Copy();
            }
            catch (Exception ex)
            {
                Message = "复制文件错误:" + ex.Message;
                MessageBox.Show(ex.Message, "复制文件错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //图盘菜单退出
        private void ContextMenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //托盘菜单显示
        private void ContextMenuShow_Click(object sender, EventArgs e)
        {
            this.Show();
        }
        //双击托盘
        private void nficon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = !this.Visible;
        }
        //隐藏按钮
        private void labHide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        #endregion

        #region 其他事件

        //窗体加载
        private void FormLoad(object sender, EventArgs e)
        {
            LoadConfig();
            Message = "配置文件加载成功";
        }
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();//加载外部文件User32.dll中的方法 ReleaseCapture（）  
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int IParam);//加载外部文件User32.dll文件中的SendMessage方法
        public static void 移动窗体(IntPtr 当前窗体句柄)
        {
            ReleaseCapture();
            SendMessage(当前窗体句柄, 0x0112, 0xf010 + 0x0002, 0);//实现移动 未知？？
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            移动窗体(this.Handle);
        }
        #endregion

        #region 加载项事件

        /// <summary>
        /// 当文件已经存在需要覆盖的时候触发事件
        /// </summary>
        /// <param name="IsFg">是否需要覆盖</param>
        void fe_MessageFg(ref bool IsFg)
        {
            if (DialogResult.Yes == MessageBox.Show("您要复制的文件已经存在，是否需要覆盖！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                IsFg = true;
            }
            else
            {
                IsFg = false;
            }
        }

        /// <summary>
        /// 复制成功后事件
        /// </summary>
        /// <param name="TotalSecond">复制毫秒数</param>
        void fe_FileMoved(double TotalSecond)
        {
            Message = "移动成功,耗时:" + TotalSecond.ToString() + "秒";
            nficon.ShowBalloonTip(1000, "移动成功", "耗时:" + TotalSecond.ToString() + "秒", ToolTipIcon.Info);

            //TODO:在移动成功的时候是否需要启动应用程序
            //Process.Start(@"C:\Documents and Settings\Administrator\Application Data\Inspur\GSZJ\GSFramework.exe");
            //this.Hide();
        }
       
        

        #endregion

        #region 拖放操作

        //拖放文件
        private void btnFile_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] str = (string[])e.Data.GetData(DataFormats.FileDrop, true);//获取拖放文件的路径 输出的数组[0]是文件路径

                if (str.Length > 0)
                {
                    if (File.Exists(str[0]))
                    {
                        //判断文件是否过大
                        if (!ValidateFile(str[0])) return;

                        if (pc == null) pc = new PathConfig();
                        pc.FilePathSource = str[0];

                        Message = "文件选择完成!" + pc.FilePathSource;

                    }
                    else
                    {
                        throw new Exception("文件不存在!");
                    }
                }
            }
            catch (Exception ex)
            {
                Message = "文件选择失败!" + ex.Message;
            }
        }
        //拖放公共
        private void ControlDragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        //拖放目录
        private void btnDir_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                e.Effect = DragDropEffects.Copy;
                string[] str = (string[])e.Data.GetData(DataFormats.FileDrop, true);//获取拖放文件的路径 输出的数组[0]是文件路径

                if (str.Length > 0)
                {
                    if (Directory.Exists(str[0]))
                    {
                        if (pc == null) pc = new PathConfig();
                        pc.DirectoryPath = str[0];
                        Message = "目录选择完成!" + pc.DirectoryPath;
                    }
                    else
                    {
                        throw new Exception("目录不存在!");

                    }
                }
            }
            catch (Exception ex)
            {
                Message = "目录选择失败!" + ex.Message;
            }
        }

        #endregion

        #region 触发器

        private void ButtonMoveStyle(object sender, MouseEventArgs e)
        {
            (sender as Control).BackColor = Color.FromArgb(50, 255, 255, 255);
        }
        private void ButtonDownStyle(object sender, MouseEventArgs e)
        {
            (sender as Control).BackColor = Color.FromArgb(80, 255, 255, 255);
        }
        private void ButtonLeaveStyle(object sender, EventArgs e)
        {
            (sender as Control).BackColor = System.Drawing.Color.Transparent;
        }
        private void labClose_MouseMove(object sender, MouseEventArgs e)
        {
            (sender as Label).ForeColor = Color.White;
        }
        private void labClose_MouseLeave(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = Color.DarkGray;
        }

        #endregion


    }
}

/*
 *  任务目标 ： 测试菜单移动不好使， 弄好之后需要提示气泡
 *              
 * 
 * 
 *
 */