namespace HXMail
{
    partial class HxMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HxMail));
            this.panSetA = new System.Windows.Forms.Panel();
            this.LabNext = new System.Windows.Forms.Label();
            this.rabsina = new System.Windows.Forms.RadioButton();
            this.rab139 = new System.Windows.Forms.RadioButton();
            this.rabqq = new System.Windows.Forms.RadioButton();
            this.rab163 = new System.Windows.Forms.RadioButton();
            this.rab126 = new System.Windows.Forms.RadioButton();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.labMail = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panSetB = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labRun = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudTimer = new System.Windows.Forms.NumericUpDown();
            this.labApp = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtFromMail = new System.Windows.Forms.TextBox();
            this.timerS = new System.Windows.Forms.Timer(this.components);
            this.panH = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.labH = new System.Windows.Forms.Label();
            this.nico = new System.Windows.Forms.NotifyIcon(this.components);
            this.panSetA.SuspendLayout();
            this.panSetB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimer)).BeginInit();
            this.panH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panSetA
            // 
            this.panSetA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.panSetA.Controls.Add(this.LabNext);
            this.panSetA.Controls.Add(this.rabsina);
            this.panSetA.Controls.Add(this.rab139);
            this.panSetA.Controls.Add(this.rabqq);
            this.panSetA.Controls.Add(this.rab163);
            this.panSetA.Controls.Add(this.rab126);
            this.panSetA.Controls.Add(this.txtPass);
            this.panSetA.Controls.Add(this.txtMail);
            this.panSetA.Controls.Add(this.labMail);
            this.panSetA.Controls.Add(this.label4);
            this.panSetA.Controls.Add(this.label3);
            this.panSetA.Controls.Add(this.label1);
            this.panSetA.Location = new System.Drawing.Point(0, 0);
            this.panSetA.Name = "panSetA";
            this.panSetA.Size = new System.Drawing.Size(355, 441);
            this.panSetA.TabIndex = 0;
            // 
            // LabNext
            // 
            this.LabNext.AutoSize = true;
            this.LabNext.Font = new System.Drawing.Font("微软雅黑", 26F);
            this.LabNext.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LabNext.Location = new System.Drawing.Point(218, 377);
            this.LabNext.Name = "LabNext";
            this.LabNext.Size = new System.Drawing.Size(125, 46);
            this.LabNext.TabIndex = 0;
            this.LabNext.Text = "下一步";
            this.LabNext.Click += new System.EventHandler(this.LabNext_Click);
            this.LabNext.MouseLeave += new System.EventHandler(this.ChangeSmall);
            this.LabNext.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChangeBig);
            // 
            // rabsina
            // 
            this.rabsina.AutoSize = true;
            this.rabsina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rabsina.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rabsina.ForeColor = System.Drawing.Color.White;
            this.rabsina.Location = new System.Drawing.Point(76, 182);
            this.rabsina.Name = "rabsina";
            this.rabsina.Size = new System.Drawing.Size(127, 35);
            this.rabsina.TabIndex = 4;
            this.rabsina.TabStop = true;
            this.rabsina.Text = "新浪邮箱";
            this.rabsina.UseVisualStyleBackColor = true;
            this.rabsina.CheckedChanged += new System.EventHandler(this.MailChange);
            this.rabsina.MouseLeave += new System.EventHandler(this.ChangeSmall);
            this.rabsina.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChangeBig);
            // 
            // rab139
            // 
            this.rab139.AutoSize = true;
            this.rab139.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rab139.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rab139.ForeColor = System.Drawing.Color.White;
            this.rab139.Location = new System.Drawing.Point(76, 141);
            this.rab139.Name = "rab139";
            this.rab139.Size = new System.Drawing.Size(121, 35);
            this.rab139.TabIndex = 2;
            this.rab139.TabStop = true;
            this.rab139.Text = "139邮箱";
            this.rab139.UseVisualStyleBackColor = true;
            this.rab139.CheckedChanged += new System.EventHandler(this.MailChange);
            this.rab139.MouseLeave += new System.EventHandler(this.ChangeSmall);
            this.rab139.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChangeBig);
            // 
            // rabqq
            // 
            this.rabqq.AutoSize = true;
            this.rabqq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rabqq.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rabqq.ForeColor = System.Drawing.Color.White;
            this.rabqq.Location = new System.Drawing.Point(222, 141);
            this.rabqq.Name = "rabqq";
            this.rabqq.Size = new System.Drawing.Size(119, 35);
            this.rabqq.TabIndex = 3;
            this.rabqq.TabStop = true;
            this.rabqq.Text = "QQ邮箱";
            this.rabqq.UseVisualStyleBackColor = true;
            this.rabqq.Visible = false;
            this.rabqq.CheckedChanged += new System.EventHandler(this.MailChange);
            this.rabqq.MouseLeave += new System.EventHandler(this.ChangeSmall);
            this.rabqq.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChangeBig);
            // 
            // rab163
            // 
            this.rab163.AutoSize = true;
            this.rab163.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rab163.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rab163.ForeColor = System.Drawing.Color.White;
            this.rab163.Location = new System.Drawing.Point(222, 100);
            this.rab163.Name = "rab163";
            this.rab163.Size = new System.Drawing.Size(121, 35);
            this.rab163.TabIndex = 1;
            this.rab163.TabStop = true;
            this.rab163.Text = "163邮箱";
            this.rab163.UseVisualStyleBackColor = true;
            this.rab163.CheckedChanged += new System.EventHandler(this.MailChange);
            this.rab163.MouseLeave += new System.EventHandler(this.ChangeSmall);
            this.rab163.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChangeBig);
            // 
            // rab126
            // 
            this.rab126.AutoSize = true;
            this.rab126.Checked = true;
            this.rab126.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rab126.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rab126.ForeColor = System.Drawing.Color.White;
            this.rab126.Location = new System.Drawing.Point(76, 100);
            this.rab126.Name = "rab126";
            this.rab126.Size = new System.Drawing.Size(121, 35);
            this.rab126.TabIndex = 0;
            this.rab126.TabStop = true;
            this.rab126.Text = "126邮箱";
            this.rab126.UseVisualStyleBackColor = true;
            this.rab126.CheckedChanged += new System.EventHandler(this.MailChange);
            this.rab126.MouseLeave += new System.EventHandler(this.ChangeSmall);
            this.rab126.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChangeBig);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.txtPass.ForeColor = System.Drawing.Color.White;
            this.txtPass.Location = new System.Drawing.Point(13, 389);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(191, 32);
            this.txtPass.TabIndex = 6;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPass.Enter += new System.EventHandler(this.TxtEnter);
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMail.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.txtMail.ForeColor = System.Drawing.Color.White;
            this.txtMail.Location = new System.Drawing.Point(13, 295);
            this.txtMail.MaxLength = 16;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(191, 32);
            this.txtMail.TabIndex = 5;
            this.txtMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMail.Enter += new System.EventHandler(this.TxtEnter);
            // 
            // labMail
            // 
            this.labMail.AutoSize = true;
            this.labMail.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labMail.ForeColor = System.Drawing.Color.White;
            this.labMail.Location = new System.Drawing.Point(201, 295);
            this.labMail.Name = "labMail";
            this.labMail.Size = new System.Drawing.Size(136, 31);
            this.labMail.TabIndex = 0;
            this.labMail.Text = "@126.com";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 23F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 40);
            this.label4.TabIndex = 0;
            this.label4.Text = "密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 45);
            this.label3.TabIndex = 6;
            this.label3.Text = "用户名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 40F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 72);
            this.label1.TabIndex = 6;
            this.label1.Text = "服务器配置";
            // 
            // panSetB
            // 
            this.panSetB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.panSetB.Controls.Add(this.panel3);
            this.panSetB.Controls.Add(this.labRun);
            this.panSetB.Controls.Add(this.label7);
            this.panSetB.Controls.Add(this.nudTimer);
            this.panSetB.Controls.Add(this.labApp);
            this.panSetB.Controls.Add(this.label6);
            this.panSetB.Controls.Add(this.label5);
            this.panSetB.Controls.Add(this.label2);
            this.panSetB.Controls.Add(this.label8);
            this.panSetB.Controls.Add(this.txtTitle);
            this.panSetB.Controls.Add(this.txtFromMail);
            this.panSetB.Location = new System.Drawing.Point(0, 0);
            this.panSetB.Name = "panSetB";
            this.panSetB.Size = new System.Drawing.Size(355, 441);
            this.panSetB.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(361, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(315, 438);
            this.panel3.TabIndex = 2;
            // 
            // labRun
            // 
            this.labRun.AutoSize = true;
            this.labRun.Font = new System.Drawing.Font("微软雅黑", 26F);
            this.labRun.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labRun.Location = new System.Drawing.Point(176, 377);
            this.labRun.Name = "labRun";
            this.labRun.Size = new System.Drawing.Size(160, 46);
            this.labRun.TabIndex = 6;
            this.labRun.Text = "开始检测";
            this.labRun.Click += new System.EventHandler(this.labRun_Click);
            this.labRun.MouseLeave += new System.EventHandler(this.ChangeSmall);
            this.labRun.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChangeBig);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(17, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 31);
            this.label7.TabIndex = 3;
            this.label7.Text = "监测间隔（秒）";
            // 
            // nudTimer
            // 
            this.nudTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.nudTimer.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.nudTimer.ForeColor = System.Drawing.Color.White;
            this.nudTimer.Location = new System.Drawing.Point(205, 337);
            this.nudTimer.Name = "nudTimer";
            this.nudTimer.Size = new System.Drawing.Size(75, 30);
            this.nudTimer.TabIndex = 3;
            // 
            // labApp
            // 
            this.labApp.AutoSize = true;
            this.labApp.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.labApp.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labApp.Location = new System.Drawing.Point(133, 285);
            this.labApp.Name = "labApp";
            this.labApp.Size = new System.Drawing.Size(110, 31);
            this.labApp.TabIndex = 2;
            this.labApp.Text = "选择程序";
            this.labApp.Click += new System.EventHandler(this.labApp_Click);
            this.labApp.MouseLeave += new System.EventHandler(this.ChangeSmall);
            this.labApp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChangeBig);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(17, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "程序配置";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "验证主题";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "验证发件人";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 40F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(90, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(246, 72);
            this.label8.TabIndex = 6;
            this.label8.Text = "扫描设置";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.txtTitle.ForeColor = System.Drawing.Color.White;
            this.txtTitle.Location = new System.Drawing.Point(46, 235);
            this.txtTitle.MaxLength = 16;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(270, 32);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTitle.Enter += new System.EventHandler(this.TxtEnter);
            // 
            // txtFromMail
            // 
            this.txtFromMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.txtFromMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFromMail.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.txtFromMail.ForeColor = System.Drawing.Color.White;
            this.txtFromMail.Location = new System.Drawing.Point(46, 144);
            this.txtFromMail.MaxLength = 30;
            this.txtFromMail.Name = "txtFromMail";
            this.txtFromMail.Size = new System.Drawing.Size(270, 32);
            this.txtFromMail.TabIndex = 0;
            this.txtFromMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFromMail.Enter += new System.EventHandler(this.TxtEnter);
            // 
            // timerS
            // 
            this.timerS.Tick += new System.EventHandler(this.timerS_Tick);
            // 
            // panH
            // 
            this.panH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.panH.Controls.Add(this.labH);
            this.panH.Controls.Add(this.pictureBox1);
            this.panH.Controls.Add(this.label10);
            this.panH.Location = new System.Drawing.Point(0, 0);
            this.panH.Name = "panH";
            this.panH.Size = new System.Drawing.Size(355, 441);
            this.panH.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::HXMail.Properties.Resources.等待;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(58, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 337);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 40F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(142, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(192, 72);
            this.label10.TabIndex = 6;
            this.label10.Text = "监测中";
            // 
            // labH
            // 
            this.labH.AutoSize = true;
            this.labH.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labH.ForeColor = System.Drawing.Color.White;
            this.labH.Location = new System.Drawing.Point(12, 9);
            this.labH.Name = "labH";
            this.labH.Size = new System.Drawing.Size(74, 21);
            this.labH.TabIndex = 7;
            this.labH.Text = "后台运行";
            this.labH.Click += new System.EventHandler(this.labH_Click);
            // 
            // nico
            // 
            this.nico.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.nico.Icon = ((System.Drawing.Icon)(resources.GetObject("nico.Icon")));
            this.nico.Text = "HxMail";
            this.nico.Visible = true;
            this.nico.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.nico_MouseDoubleClick);
            // 
            // HxMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(355, 441);
            this.Controls.Add(this.panSetA);
            this.Controls.Add(this.panSetB);
            this.Controls.Add(this.panH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HxMail";
            this.Text = "HxMail";
            this.panSetA.ResumeLayout(false);
            this.panSetA.PerformLayout();
            this.panSetB.ResumeLayout(false);
            this.panSetB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimer)).EndInit();
            this.panH.ResumeLayout(false);
            this.panH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panSetA;
        private System.Windows.Forms.RadioButton rab126;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rabqq;
        private System.Windows.Forms.RadioButton rab163;
        private System.Windows.Forms.Label labMail;
        private System.Windows.Forms.Label LabNext;
        private System.Windows.Forms.Panel panSetB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudTimer;
        private System.Windows.Forms.Timer timerS;
        private System.Windows.Forms.RadioButton rabsina;
        private System.Windows.Forms.RadioButton rab139;
        private System.Windows.Forms.Label labRun;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtFromMail;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panH;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labApp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labH;
        private System.Windows.Forms.NotifyIcon nico;

    }
}

