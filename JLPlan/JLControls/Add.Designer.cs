namespace JLControls
{
    partial class Add
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Time1 = new System.Windows.Forms.Timer(this.components);
            this.Time2 = new System.Windows.Forms.Timer(this.components);
            this.cmbM2 = new System.Windows.Forms.ComboBox();
            this.cmbM1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Text = new System.Windows.Forms.TextBox();
            this.cmbH2 = new System.Windows.Forms.ComboBox();
            this.cmdH1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Time1
            // 
            this.Time1.Interval = 14;
            this.Time1.Tick += new System.EventHandler(this.Time1_Tick);
            // 
            // Time2
            // 
            this.Time2.Interval = 8;
            this.Time2.Tick += new System.EventHandler(this.Time2_Tick);
            // 
            // cmbM2
            // 
            this.cmbM2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbM2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbM2.FormattingEnabled = true;
            this.cmbM2.Location = new System.Drawing.Point(237, 122);
            this.cmbM2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbM2.Name = "cmbM2";
            this.cmbM2.Size = new System.Drawing.Size(45, 25);
            this.cmbM2.TabIndex = 4;
            // 
            // cmbM1
            // 
            this.cmbM1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbM1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbM1.FormattingEnabled = true;
            this.cmbM1.Location = new System.Drawing.Point(217, 76);
            this.cmbM1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbM1.Name = "cmbM1";
            this.cmbM1.Size = new System.Drawing.Size(45, 25);
            this.cmbM1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(288, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 21);
            this.label2.TabIndex = 47;
            this.label2.Text = "分";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(268, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 21);
            this.label6.TabIndex = 46;
            this.label6.Text = "分";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(204, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 28);
            this.label7.TabIndex = 49;
            this.label7.Text = "时";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(185, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 28);
            this.label5.TabIndex = 48;
            this.label5.Text = "时";
            // 
            // cmbPriority
            // 
            this.cmbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriority.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Items.AddRange(new object[] {
            "最高级",
            "高级",
            "中级",
            "低级",
            "最低级"});
            this.cmbPriority.Location = new System.Drawing.Point(125, 22);
            this.cmbPriority.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(173, 29);
            this.cmbPriority.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 38);
            this.label4.TabIndex = 44;
            this.label4.Text = "优先级";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(304, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 80);
            this.label3.TabIndex = 43;
            this.label3.Text = "任\r\n务\r\n内\r\n容";
            // 
            // txt_Text
            // 
            this.txt_Text.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Text.Location = new System.Drawing.Point(330, 22);
            this.txt_Text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Text.Multiline = true;
            this.txt_Text.Name = "txt_Text";
            this.txt_Text.Size = new System.Drawing.Size(282, 127);
            this.txt_Text.TabIndex = 5;
            // 
            // cmbH2
            // 
            this.cmbH2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbH2.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.cmbH2.FormattingEnabled = true;
            this.cmbH2.Location = new System.Drawing.Point(157, 120);
            this.cmbH2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbH2.Name = "cmbH2";
            this.cmbH2.Size = new System.Drawing.Size(46, 28);
            this.cmbH2.TabIndex = 3;
            // 
            // cmdH1
            // 
            this.cmdH1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdH1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmdH1.FormattingEnabled = true;
            this.cmdH1.Location = new System.Drawing.Point(139, 74);
            this.cmdH1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdH1.Name = "cmdH1";
            this.cmdH1.Size = new System.Drawing.Size(46, 28);
            this.cmdH1.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(63, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 25);
            this.label9.TabIndex = 38;
            this.label9.Text = "结束时间";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 28);
            this.label1.TabIndex = 39;
            this.label1.Text = "起始时间";
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbM2);
            this.Controls.Add(this.cmbM1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbPriority);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Text);
            this.Controls.Add(this.cmbH2);
            this.Controls.Add(this.cmdH1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Name = "Add";
            this.Size = new System.Drawing.Size(639, 168);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Time1;
        private System.Windows.Forms.Timer Time2;
        private System.Windows.Forms.ComboBox cmbM2;
        private System.Windows.Forms.ComboBox cmbM1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Text;
        private System.Windows.Forms.ComboBox cmbH2;
        private System.Windows.Forms.ComboBox cmdH1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
    }
}
