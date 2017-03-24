using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Xml;
using System.Runtime.InteropServices;

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
                if (cmlConfig.EasyFilecg.Count != 0)
                {
                    btnSet.Text = "添加配置";
                }
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
            flowLayoutPanel2.Controls.Clear();
            foreach (PathConfig cc in cmlConfig.EasyFilecg)
            {
                Button bt = new Button();
                bt.Width = 200;
                bt.Text = cc.Title;
                bt.Click += new EventHandler(MoveFile);
                bt.Tag = cc;

                bt.FlatAppearance.BorderColor = System.Drawing.Color.White;
                bt.FlatAppearance.BorderSize = 2;
                bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(65, 146, 176);
                bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(179, 225, 228);
                bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                bt.ForeColor = System.Drawing.Color.DimGray;
                bt.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
                bt.Size = new System.Drawing.Size(131, 45);
                bt.MouseMove += new MouseEventHandler(bt_MouseMove);
                this.toolTip1.SetToolTip(bt, string.Format("标题:{0}\n文件:{1}\n目录:{2}\n", cc.Title, cc.FilePathSource, cc.DirectoryPath));
                flowLayoutPanel2.Controls.Add(bt);
            }
        }

        //用于判断当前配置是否展开
        bool configExand;

        /// <summary>
        /// 设置配置页面
        /// </summary>
        private void ResetConfig()
        {
            if (!configExand)
            {
                this.Width = 494;
                pc = new PathConfig();
                configExand = !configExand;
                btnSet.Text = "取消配置";
            }
            else
            {
                pc = null;
                this.Width = 242;
                configExand = !configExand;
                btnSet.Text = "添加配置";
                Reset();
            }
        }

        /// <summary>
        /// 重置页面名称
        /// </summary>
        public void Reset()
        {
            btnFile.Text = "选择文件";
            btnDir.Text = "目标文件夹";
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



        //展开设置按钮
        private void SetHelp(object sender, EventArgs e)
        {
            ResetConfig();
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

                AutoButton();

                //手气配置页面
                ResetConfig();
                //显示信息
                Message = "添加配置成功!";

                Reset();

                //防止重复按重新配置
                if (labClearConfig.Enabled == false)
                {
                    labClearConfig.Enabled = true;
                }
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

                    labLength.ResetText();
                    labName.ResetText();
                    labType.ResetText();
                    labDir.ResetText();

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


                //选择完成后显示选择文件的名称
                btnFile.Text = GetName(pc.FilePathSource);
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

                //选择完成后显示选择目录的名称
                btnDir.Text = GetName(pc.DirectoryPath);
            }
        }

        //复制文件
        public void MoveFile(object sender, EventArgs e)
        {
            try
            {
                FileEx fe = new FileEx((sender as Button).Tag as PathConfig);
                fe.FileMoved += new FileEx.Moved(fe_FileMoved);
                fe.MessageFg += new FileEx.FgMessage(fe_MessageFg);
                fe.Copy();
            }
            catch (Exception ex)
            {
                Message = "复制文件错误:" + ex.Message;
            }
        }


        #endregion

        #region 其他事件

        //窗体加载
        private void FormLoad(object sender, EventArgs e)
        {
            LoadConfig();
            Message = "配置文件加载成功";
        }

        #region 加载项事件

        /// <summary>
        /// 当鼠标移动到按钮上
        /// </summary>
        void bt_MouseMove(object sender, MouseEventArgs e)
        {
            FileInfo fi = new FileInfo(((sender as Control).Tag as PathConfig).FilePathSource);

            if (fi.Exists)
            {
                //文件类型
                labType.Text = fi.Extension.TrimStart('.').ToUpper() + "文件";
                //文件名称
                labName.Text = fi.Name;
                //文件父级目录
                labDir.Text = fi.Directory.Name;
                //文件大小
                long size = fi.Length / 1024;

                if (size < 1)
                {
                    labLength.Text = "<1KB";
                }
                else if (size > 1024)
                {
                    size = size / 1024;

                    if (size > 1024)
                    {
                        size = size / 1024;
                        labLength.Text = size + "GB";
                    }
                    labLength.Text = size + "MB";
                }
            }

        }

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

                        btnFile.Text = GetName(pc.FilePathSource);
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
                        btnDir.Text = GetName(pc.DirectoryPath);
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

        #endregion

        #endregion

    }
}