namespace 风影浏览器
{
    partial class FengYing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FengYing));
            this.labHome = new System.Windows.Forms.ComboBox();
            this.WebHead = new System.Windows.Forms.WebBrowser();
            this.labNext = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.ils = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labBack = new System.Windows.Forms.Label();
            this.labNext.SuspendLayout();
            this.tab1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labHome
            // 
            this.labHome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labHome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.labHome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.labHome.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.labHome.FormattingEnabled = true;
            this.labHome.Location = new System.Drawing.Point(82, 2);
            this.labHome.Name = "labHome";
            this.labHome.Size = new System.Drawing.Size(747, 24);
            this.labHome.TabIndex = 1;
            this.labHome.Text = "http://www.hao123.com/";
            this.labHome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbAddress_KeyDown);
            // 
            // WebHead
            // 
            this.WebHead.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WebHead.Location = new System.Drawing.Point(0, 22);
            this.WebHead.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebHead.Name = "WebHead";
            this.WebHead.Size = new System.Drawing.Size(804, 416);
            this.WebHead.TabIndex = 0;
            this.WebHead.Url = new System.Uri("http://www.hao123.com", System.UriKind.Absolute);
            // 
            // labNext
            // 
            this.labNext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labNext.Controls.Add(this.tab1);
            this.labNext.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labNext.HotTrack = true;
            this.labNext.ImageList = this.ils;
            this.labNext.ItemSize = new System.Drawing.Size(100, 27);
            this.labNext.Location = new System.Drawing.Point(0, 1);
            this.labNext.Multiline = true;
            this.labNext.Name = "labNext";
            this.labNext.SelectedIndex = 0;
            this.labNext.Size = new System.Drawing.Size(814, 474);
            this.labNext.TabIndex = 3;
            this.labNext.SelectedIndexChanged += new System.EventHandler(this.WebPage_SelectedIndexChanged);
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.WebHead);
            this.tab1.Location = new System.Drawing.Point(4, 31);
            this.tab1.Name = "tab1";
            this.tab1.Size = new System.Drawing.Size(806, 439);
            this.tab1.TabIndex = 1;
            this.tab1.Text = "默认标签页";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labHome);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labBack);
            this.panel1.Location = new System.Drawing.Point(1, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 27);
            this.panel1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.Location = new System.Drawing.Point(808, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 25);
            this.label4.TabIndex = 6;
            // 
            // ils
            // 
            this.ils.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ils.ImageStream")));
            this.ils.TransparentColor = System.Drawing.Color.Transparent;
            this.ils.Images.SetKeyName(0, "MB_0009_loading.ico");
            this.ils.Images.SetKeyName(1, "MB_0014_net.ico");
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Image = global::风影浏览器.Properties.Resources.Home;
            this.label3.Location = new System.Drawing.Point(56, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 2;
            this.label3.Click += new System.EventHandler(this.GoHome);
            // 
            // label2
            // 
            this.label2.Image = global::风影浏览器.Properties.Resources.Next;
            this.label2.Location = new System.Drawing.Point(32, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 0;
            this.label2.Click += new System.EventHandler(this.GoNext);
            // 
            // labBack
            // 
            this.labBack.Image = global::风影浏览器.Properties.Resources.Back;
            this.labBack.Location = new System.Drawing.Point(9, 8);
            this.labBack.Name = "labBack";
            this.labBack.Size = new System.Drawing.Size(17, 12);
            this.labBack.TabIndex = 0;
            this.labBack.Click += new System.EventHandler(this.GoBack);
            // 
            // FengYing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(169)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(812, 475);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labNext);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FengYing";
            this.Text = "风影浏览器";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.labNext.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox labHome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl labNext;
        private System.Windows.Forms.WebBrowser WebHead;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.ImageList ils;
    }
}

