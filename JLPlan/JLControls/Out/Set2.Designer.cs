namespace JLControls
{
    partial class Set2
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labFileName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rabFormatQ = new System.Windows.Forms.RadioButton();
            this.rabFormatH = new System.Windows.Forms.RadioButton();
            this.txt_Text = new System.Windows.Forms.TextBox();
            this.cmbFormat = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labTitle
            // 
            this.labTitle.Size = new System.Drawing.Size(164, 25);
            this.labTitle.Text = "设置保存文件名称";
            // 
            // labBz
            // 
            this.labBz.Text = "第二步";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labFileName);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(260, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 42);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "文件名称预览";
            // 
            // labFileName
            // 
            this.labFileName.AutoEllipsis = true;
            this.labFileName.Location = new System.Drawing.Point(32, 14);
            this.labFileName.Name = "labFileName";
            this.labFileName.Size = new System.Drawing.Size(187, 23);
            this.labFileName.TabIndex = 21;
            this.labFileName.Text = "文件名";
            this.labFileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(230, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 27);
            this.label4.TabIndex = 26;
            this.label4.Text = "文件名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(64, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 27);
            this.label3.TabIndex = 27;
            this.label3.Text = "格式";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rabFormatQ);
            this.groupBox1.Controls.Add(this.rabFormatH);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(69, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 42);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选项";
            // 
            // rabFormatQ
            // 
            this.rabFormatQ.AutoSize = true;
            this.rabFormatQ.Checked = true;
            this.rabFormatQ.Location = new System.Drawing.Point(10, 16);
            this.rabFormatQ.Name = "rabFormatQ";
            this.rabFormatQ.Size = new System.Drawing.Size(74, 21);
            this.rabFormatQ.TabIndex = 16;
            this.rabFormatQ.TabStop = true;
            this.rabFormatQ.Text = "格式在前";
            this.rabFormatQ.UseVisualStyleBackColor = true;
            // 
            // rabFormatH
            // 
            this.rabFormatH.AutoSize = true;
            this.rabFormatH.Location = new System.Drawing.Point(105, 16);
            this.rabFormatH.Name = "rabFormatH";
            this.rabFormatH.Size = new System.Drawing.Size(74, 21);
            this.rabFormatH.TabIndex = 16;
            this.rabFormatH.Text = "格式在后";
            this.rabFormatH.UseVisualStyleBackColor = true;
            this.rabFormatH.CheckedChanged += new System.EventHandler(this.rabFormatH_CheckedChanged_1);
            // 
            // txt_Text
            // 
            this.txt_Text.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Text.Location = new System.Drawing.Point(323, 104);
            this.txt_Text.Name = "txt_Text";
            this.txt_Text.Size = new System.Drawing.Size(182, 26);
            this.txt_Text.TabIndex = 24;
            this.txt_Text.TextChanged += new System.EventHandler(this.txt_Text_TextChanged);
            // 
            // cmbFormat
            // 
            this.cmbFormat.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbFormat.FormattingEnabled = true;
            this.cmbFormat.Items.AddRange(new object[] {
            "序号",
            "日期",
            "日期+时间"});
            this.cmbFormat.Location = new System.Drawing.Point(131, 101);
            this.cmbFormat.Name = "cmbFormat";
            this.cmbFormat.Size = new System.Drawing.Size(78, 28);
            this.cmbFormat.TabIndex = 23;
            this.cmbFormat.SelectedIndexChanged += new System.EventHandler(this.cmbFormat_SelectedIndexChanged);
            // 
            // Set2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_Text);
            this.Controls.Add(this.cmbFormat);
            this.Name = "Set2";
            this.Controls.SetChildIndex(this.labBz, 0);
            this.Controls.SetChildIndex(this.labTitle, 0);
            this.Controls.SetChildIndex(this.cmbFormat, 0);
            this.Controls.SetChildIndex(this.txt_Text, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labFileName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rabFormatQ;
        private System.Windows.Forms.RadioButton rabFormatH;
        private System.Windows.Forms.TextBox txt_Text;
        private System.Windows.Forms.ComboBox cmbFormat;
    }
}
