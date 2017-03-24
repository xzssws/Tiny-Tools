namespace MFileSpace
{
    partial class MFile
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MFile));
            this.ToolTipMessage = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextMenuFileMove = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuShow = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.nficon = new System.Windows.Forms.NotifyIcon(this.components);
            this.panelEx1 = new MFileSpace.PanelEx();
            this.flpButton = new System.Windows.Forms.FlowLayoutPanel();
            this.panelEx7 = new MFileSpace.PanelEx();
            this.labMessage = new System.Windows.Forms.Label();
            this.panelEx3 = new MFileSpace.PanelEx();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.panelEx7.SuspendLayout();
            this.panelEx3.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMenuFileMove,
            this.ContextMenuShow,
            this.ContextMenuExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 70);
            // 
            // ContextMenuFileMove
            // 
            this.ContextMenuFileMove.Name = "ContextMenuFileMove";
            this.ContextMenuFileMove.Size = new System.Drawing.Size(122, 22);
            this.ContextMenuFileMove.Text = "移动文件";
            // 
            // ContextMenuShow
            // 
            this.ContextMenuShow.Name = "ContextMenuShow";
            this.ContextMenuShow.Size = new System.Drawing.Size(122, 22);
            this.ContextMenuShow.Text = "显示程序";
            this.ContextMenuShow.Click += new System.EventHandler(this.ContextMenuShow_Click);
            // 
            // ContextMenuExit
            // 
            this.ContextMenuExit.Name = "ContextMenuExit";
            this.ContextMenuExit.Size = new System.Drawing.Size(122, 22);
            this.ContextMenuExit.Text = "退出程序";
            this.ContextMenuExit.Click += new System.EventHandler(this.ContextMenuExit_Click);
            // 
            // nficon
            // 
            this.nficon.ContextMenuStrip = this.contextMenuStrip1;
            this.nficon.Icon = ((System.Drawing.Icon)(resources.GetObject("nficon.Icon")));
            this.nficon.Visible = true;
            this.nficon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.nficon_MouseDoubleClick);
            // 
            // panelEx1
            // 
            this.panelEx1.AutoSize = true;
            this.panelEx1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(69)))), ((int)(((byte)(87)))));
            this.panelEx1.ColorDown = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(73)))), ((int)(((byte)(84)))));
            this.panelEx1.ColorUp = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(23)))));
            this.panelEx1.Controls.Add(this.flpButton);
            this.panelEx1.Controls.Add(this.panelEx7);
            this.panelEx1.Controls.Add(this.panelEx3);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.IsLinear = false;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Mode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(299, 451);
            this.panelEx1.TabIndex = 0;
            // 
            // flpButton
            // 
            this.flpButton.AutoScroll = true;
            this.flpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(121)))), ((int)(((byte)(54)))));
            this.flpButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpButton.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpButton.Location = new System.Drawing.Point(0, 49);
            this.flpButton.Name = "flpButton";
            this.flpButton.Size = new System.Drawing.Size(299, 378);
            this.flpButton.TabIndex = 6;
            this.flpButton.WrapContents = false;
            // 
            // panelEx7
            // 
            this.panelEx7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(121)))), ((int)(((byte)(54)))));
            this.panelEx7.ColorDown = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(174)))), ((int)(((byte)(188)))));
            this.panelEx7.ColorUp = System.Drawing.Color.White;
            this.panelEx7.Controls.Add(this.labMessage);
            this.panelEx7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx7.IsLinear = false;
            this.panelEx7.Location = new System.Drawing.Point(0, 427);
            this.panelEx7.Mode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.panelEx7.Name = "panelEx7";
            this.panelEx7.Size = new System.Drawing.Size(299, 24);
            this.panelEx7.TabIndex = 4;
            // 
            // labMessage
            // 
            this.labMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labMessage.AutoEllipsis = true;
            this.labMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(121)))), ((int)(((byte)(54)))));
            this.labMessage.ForeColor = System.Drawing.Color.Silver;
            this.labMessage.Location = new System.Drawing.Point(11, 6);
            this.labMessage.Name = "labMessage";
            this.labMessage.Size = new System.Drawing.Size(281, 12);
            this.labMessage.TabIndex = 0;
            // 
            // panelEx3
            // 
            this.panelEx3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(121)))), ((int)(((byte)(54)))));
            this.panelEx3.ColorDown = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(174)))), ((int)(((byte)(188)))));
            this.panelEx3.ColorUp = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(71)))), ((int)(((byte)(84)))));
            this.panelEx3.Controls.Add(this.label1);
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx3.IsLinear = false;
            this.panelEx3.Location = new System.Drawing.Point(0, 0);
            this.panelEx3.Mode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(299, 49);
            this.panelEx3.TabIndex = 1;
            this.panelEx3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(121)))), ((int)(((byte)(54)))));
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(93, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "搬砖机器人";
            // 
            // MFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(299, 451);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MFile";
            this.Text = "搬砖机器人";
            this.Load += new System.EventHandler(this.FormLoad);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            this.panelEx7.ResumeLayout(false);
            this.panelEx3.ResumeLayout(false);
            this.panelEx3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MFileSpace.PanelEx panelEx1;
        private MFileSpace.PanelEx panelEx3;
        private System.Windows.Forms.Label label1;
        private MFileSpace.PanelEx panelEx7;
        private System.Windows.Forms.Label labMessage;
        private System.Windows.Forms.ToolTip ToolTipMessage;
        private System.Windows.Forms.FlowLayoutPanel flpButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuFileMove;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuShow;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuExit;
        private System.Windows.Forms.NotifyIcon nficon;
        


    }
}