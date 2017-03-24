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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labMessage = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDir = new System.Windows.Forms.Label();
            this.btnFile = new System.Windows.Forms.Label();
            this.panelEx2 = new MFileSpace.PanelEx();
            this.labDir = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labLength = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labType = new System.Windows.Forms.Label();
            this.panelEx3 = new MFileSpace.PanelEx();
            this.label9 = new System.Windows.Forms.Label();
            this.labClearConfig = new System.Windows.Forms.Label();
            this.panelEx5 = new MFileSpace.PanelEx();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSet = new System.Windows.Forms.Label();
            this.panelEx1 = new MFileSpace.PanelEx();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelEx2.SuspendLayout();
            this.panelEx3.SuspendLayout();
            this.panelEx5.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel2.Location = new System.Drawing.Point(7, 215);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(224, 155);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(201)))), ((int)(((byte)(215)))));
            this.panel1.Controls.Add(this.labMessage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 376);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 25);
            this.panel1.TabIndex = 10;
            // 
            // labMessage
            // 
            this.labMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labMessage.AutoEllipsis = true;
            this.labMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(201)))), ((int)(((byte)(215)))));
            this.labMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labMessage.Location = new System.Drawing.Point(3, 7);
            this.labMessage.Name = "labMessage";
            this.labMessage.Size = new System.Drawing.Size(491, 12);
            this.labMessage.TabIndex = 0;
            this.labMessage.Text = "当前状态";
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(211)))), ((int)(((byte)(225)))));
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnDir);
            this.panel2.Controls.Add(this.btnFile);
            this.panel2.Location = new System.Drawing.Point(237, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 306);
            this.panel2.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 18;
            this.label8.Text = "回退";
            this.label8.Click += new System.EventHandler(this.SetHelp);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(57, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 28);
            this.label13.TabIndex = 21;
            this.label13.Text = "搬砖机器人";
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.label1.Image = global::MFile.Properties.Resources.plus;
            this.label1.Location = new System.Drawing.Point(18, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 38);
            this.label1.TabIndex = 17;
            this.toolTip1.SetToolTip(this.label1, "添加配置");
            this.label1.MouseLeave += new System.EventHandler(this.ButtonLeaveStyle);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonMoveStyle);
            this.label1.Click += new System.EventHandler(this.AddPathConfig);
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonDownStyle);
            // 
            // btnDir
            // 
            this.btnDir.AllowDrop = true;
            this.btnDir.AutoEllipsis = true;
            this.btnDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(211)))), ((int)(((byte)(225)))));
            this.btnDir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDir.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.btnDir.Image = global::MFile.Properties.Resources.Folder;
            this.btnDir.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDir.Location = new System.Drawing.Point(119, 144);
            this.btnDir.Name = "btnDir";
            this.btnDir.Size = new System.Drawing.Size(126, 126);
            this.btnDir.TabIndex = 16;
            this.btnDir.Text = "目标文件夹";
            this.btnDir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnDir, "可以把目录拖放到此处");
            this.btnDir.MouseLeave += new System.EventHandler(this.ButtonLeaveStyle);
            this.btnDir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonMoveStyle);
            this.btnDir.Click += new System.EventHandler(this.btnDir_Click);
            this.btnDir.DragDrop += new System.Windows.Forms.DragEventHandler(this.btnDir_DragDrop);
            this.btnDir.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonDownStyle);
            this.btnDir.DragEnter += new System.Windows.Forms.DragEventHandler(this.ControlDragEnter);
            // 
            // btnFile
            // 
            this.btnFile.AllowDrop = true;
            this.btnFile.AutoEllipsis = true;
            this.btnFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(211)))), ((int)(((byte)(225)))));
            this.btnFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFile.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.btnFile.Image = global::MFile.Properties.Resources.folderclosed;
            this.btnFile.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnFile.Location = new System.Drawing.Point(3, 9);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(126, 126);
            this.btnFile.TabIndex = 16;
            this.btnFile.Text = "选择文件";
            this.btnFile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnFile, "可以把文件拖放到此处");
            this.btnFile.MouseLeave += new System.EventHandler(this.ButtonLeaveStyle);
            this.btnFile.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonMoveStyle);
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            this.btnFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.btnFile_DragDrop);
            this.btnFile.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonDownStyle);
            this.btnFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.ControlDragEnter);
            // 
            // panelEx2
            // 
            this.panelEx2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(216)))), ((int)(((byte)(221)))));
            this.panelEx2.ColorDown = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(201)))), ((int)(((byte)(215)))));
            this.panelEx2.ColorUp = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(201)))), ((int)(((byte)(215)))));
            this.panelEx2.Controls.Add(this.labDir);
            this.panelEx2.Controls.Add(this.label3);
            this.panelEx2.Controls.Add(this.label4);
            this.panelEx2.Controls.Add(this.label5);
            this.panelEx2.Controls.Add(this.labLength);
            this.panelEx2.Controls.Add(this.label6);
            this.panelEx2.Controls.Add(this.labName);
            this.panelEx2.Controls.Add(this.label11);
            this.panelEx2.Controls.Add(this.label10);
            this.panelEx2.Controls.Add(this.label7);
            this.panelEx2.Controls.Add(this.labType);
            this.panelEx2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.panelEx2.IsLinear = false;
            this.panelEx2.Location = new System.Drawing.Point(7, 67);
            this.panelEx2.Mode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(224, 118);
            this.panelEx2.TabIndex = 20;
            // 
            // labDir
            // 
            this.labDir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labDir.AutoEllipsis = true;
            this.labDir.Location = new System.Drawing.Point(57, 95);
            this.labDir.Name = "labDir";
            this.labDir.Size = new System.Drawing.Size(153, 12);
            this.labDir.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "文件类型";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "文件名称";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "文件大小";
            // 
            // labLength
            // 
            this.labLength.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labLength.AutoEllipsis = true;
            this.labLength.Location = new System.Drawing.Point(57, 67);
            this.labLength.Name = "labLength";
            this.labLength.Size = new System.Drawing.Size(153, 12);
            this.labLength.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "父级目录";
            // 
            // labName
            // 
            this.labName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labName.AutoEllipsis = true;
            this.labName.Location = new System.Drawing.Point(57, 39);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(153, 12);
            this.labName.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(205)))), ((int)(((byte)(218)))));
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(1, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(222, 3);
            this.label11.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(205)))), ((int)(((byte)(218)))));
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(1, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(222, 3);
            this.label10.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(205)))), ((int)(((byte)(218)))));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(1, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 3);
            this.label7.TabIndex = 7;
            // 
            // labType
            // 
            this.labType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labType.AutoEllipsis = true;
            this.labType.Location = new System.Drawing.Point(57, 11);
            this.labType.Name = "labType";
            this.labType.Size = new System.Drawing.Size(153, 12);
            this.labType.TabIndex = 19;
            // 
            // panelEx3
            // 
            this.panelEx3.ColorDown = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(176)))), ((int)(((byte)(187)))));
            this.panelEx3.ColorUp = System.Drawing.Color.White;
            this.panelEx3.Controls.Add(this.label9);
            this.panelEx3.Controls.Add(this.labClearConfig);
            this.panelEx3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.panelEx3.IsLinear = true;
            this.panelEx3.Location = new System.Drawing.Point(237, 38);
            this.panelEx3.Mode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(248, 27);
            this.panelEx3.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(92, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "详细配置";
            // 
            // labClearConfig
            // 
            this.labClearConfig.AutoSize = true;
            this.labClearConfig.BackColor = System.Drawing.Color.Transparent;
            this.labClearConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labClearConfig.ForeColor = System.Drawing.Color.Gray;
            this.labClearConfig.Location = new System.Drawing.Point(190, 7);
            this.labClearConfig.Name = "labClearConfig";
            this.labClearConfig.Size = new System.Drawing.Size(53, 12);
            this.labClearConfig.TabIndex = 18;
            this.labClearConfig.Text = "清空配置";
            this.labClearConfig.MouseLeave += new System.EventHandler(this.ButtonLeaveStyle);
            this.labClearConfig.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonMoveStyle);
            this.labClearConfig.Click += new System.EventHandler(this.ClearConfig);
            this.labClearConfig.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonDownStyle);
            // 
            // panelEx5
            // 
            this.panelEx5.ColorDown = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(176)))), ((int)(((byte)(187)))));
            this.panelEx5.ColorUp = System.Drawing.Color.White;
            this.panelEx5.Controls.Add(this.label12);
            this.panelEx5.Controls.Add(this.btnSet);
            this.panelEx5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.panelEx5.IsLinear = true;
            this.panelEx5.Location = new System.Drawing.Point(6, 186);
            this.panelEx5.Mode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelEx5.Name = "panelEx5";
            this.panelEx5.Size = new System.Drawing.Size(225, 28);
            this.panelEx5.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(73, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "移动按钮组";
            // 
            // btnSet
            // 
            this.btnSet.AutoSize = true;
            this.btnSet.BackColor = System.Drawing.Color.Transparent;
            this.btnSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSet.ForeColor = System.Drawing.Color.Gray;
            this.btnSet.Location = new System.Drawing.Point(169, 9);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(53, 12);
            this.btnSet.TabIndex = 9;
            this.btnSet.Text = "开始设置";
            this.btnSet.MouseLeave += new System.EventHandler(this.ButtonLeaveStyle);
            this.btnSet.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonMoveStyle);
            this.btnSet.Click += new System.EventHandler(this.SetHelp);
            this.btnSet.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonDownStyle);
            // 
            // panelEx1
            // 
            this.panelEx1.ColorDown = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(176)))), ((int)(((byte)(187)))));
            this.panelEx1.ColorUp = System.Drawing.Color.White;
            this.panelEx1.Controls.Add(this.label2);
            this.panelEx1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.panelEx1.IsLinear = true;
            this.panelEx1.Location = new System.Drawing.Point(7, 39);
            this.panelEx1.Mode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(224, 27);
            this.panelEx1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(66, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "文件详细信息";
            // 
            // MFile
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(201)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(497, 401);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panelEx2);
            this.Controls.Add(this.panelEx3);
            this.Controls.Add(this.panelEx5);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(75)))), ((int)(((byte)(157)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "搬砖机器人";
            this.Load += new System.EventHandler(this.FormLoad);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelEx2.ResumeLayout(false);
            this.panelEx2.PerformLayout();
            this.panelEx3.ResumeLayout(false);
            this.panelEx3.PerformLayout();
            this.panelEx5.ResumeLayout(false);
            this.panelEx5.PerformLayout();
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label btnSet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label btnFile;
        private System.Windows.Forms.Label btnDir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labClearConfig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labType;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labLength;
        private System.Windows.Forms.Label labDir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private PanelEx panelEx2;
        private PanelEx panelEx1;
        private PanelEx panelEx3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private PanelEx panelEx5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

