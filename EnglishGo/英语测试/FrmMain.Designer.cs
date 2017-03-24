namespace 英语测试
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labC = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInner = new System.Windows.Forms.TextBox();
            this.labGo = new System.Windows.Forms.Label();
            this.labCount = new System.Windows.Forms.Label();
            this.labTrue = new System.Windows.Forms.Label();
            this.labError = new System.Windows.Forms.Label();
            this.labClose = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labS = new System.Windows.Forms.Label();
            this.pnlD = new System.Windows.Forms.Panel();
            this.btnOption = new System.Windows.Forms.Button();
            this.pnlD.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 46F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-4, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "英语测评";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 294);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "单词总数";
            // 
            // labC
            // 
            this.labC.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labC.ForeColor = System.Drawing.Color.DimGray;
            this.labC.Location = new System.Drawing.Point(165, 86);
            this.labC.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labC.Name = "labC";
            this.labC.Size = new System.Drawing.Size(403, 67);
            this.labC.TabIndex = 0;
            this.labC.Text = "单词";
            this.labC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 294);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "正确数量";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(401, 294);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "错误数量";
            // 
            // txtInner
            // 
            this.txtInner.BackColor = System.Drawing.Color.Coral;
            this.txtInner.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInner.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInner.Location = new System.Drawing.Point(165, 187);
            this.txtInner.Name = "txtInner";
            this.txtInner.Size = new System.Drawing.Size(403, 55);
            this.txtInner.TabIndex = 1;
            this.txtInner.Text = "在这里输入";
            this.txtInner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInner.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInner_KeyDown);
            // 
            // labGo
            // 
            this.labGo.AutoSize = true;
            this.labGo.Font = new System.Drawing.Font("微软雅黑", 38F);
            this.labGo.ForeColor = System.Drawing.Color.White;
            this.labGo.Location = new System.Drawing.Point(199, 73);
            this.labGo.Name = "labGo";
            this.labGo.Size = new System.Drawing.Size(130, 66);
            this.labGo.TabIndex = 3;
            this.labGo.Text = "开始";
            this.labGo.Click += new System.EventHandler(this.labGo_Click);
            // 
            // labCount
            // 
            this.labCount.AutoSize = true;
            this.labCount.ForeColor = System.Drawing.Color.White;
            this.labCount.Location = new System.Drawing.Point(104, 295);
            this.labCount.Name = "labCount";
            this.labCount.Size = new System.Drawing.Size(0, 21);
            this.labCount.TabIndex = 4;
            // 
            // labTrue
            // 
            this.labTrue.AutoSize = true;
            this.labTrue.ForeColor = System.Drawing.Color.White;
            this.labTrue.Location = new System.Drawing.Point(280, 294);
            this.labTrue.Name = "labTrue";
            this.labTrue.Size = new System.Drawing.Size(0, 21);
            this.labTrue.TabIndex = 5;
            // 
            // labError
            // 
            this.labError.AutoSize = true;
            this.labError.ForeColor = System.Drawing.Color.White;
            this.labError.Location = new System.Drawing.Point(480, 294);
            this.labError.Name = "labError";
            this.labError.Size = new System.Drawing.Size(0, 21);
            this.labError.TabIndex = 6;
            // 
            // labClose
            // 
            this.labClose.AutoSize = true;
            this.labClose.ForeColor = System.Drawing.Color.White;
            this.labClose.Location = new System.Drawing.Point(654, 2);
            this.labClose.Name = "labClose";
            this.labClose.Size = new System.Drawing.Size(42, 21);
            this.labClose.TabIndex = 8;
            this.labClose.Text = "关闭";
            this.labClose.Click += new System.EventHandler(this.labClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(598, 294);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "已答数量";
            // 
            // labS
            // 
            this.labS.AutoSize = true;
            this.labS.ForeColor = System.Drawing.Color.White;
            this.labS.Location = new System.Drawing.Point(677, 294);
            this.labS.Name = "labS";
            this.labS.Size = new System.Drawing.Size(0, 21);
            this.labS.TabIndex = 7;
            // 
            // pnlD
            // 
            this.pnlD.Controls.Add(this.labGo);
            this.pnlD.Location = new System.Drawing.Point(102, 82);
            this.pnlD.Name = "pnlD";
            this.pnlD.Size = new System.Drawing.Size(511, 199);
            this.pnlD.TabIndex = 9;
            // 
            // btnOption
            // 
            this.btnOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOption.ForeColor = System.Drawing.Color.White;
            this.btnOption.Location = new System.Drawing.Point(540, 5);
            this.btnOption.Name = "btnOption";
            this.btnOption.Size = new System.Drawing.Size(101, 35);
            this.btnOption.TabIndex = 10;
            this.btnOption.Text = "选择单词表";
            this.btnOption.UseVisualStyleBackColor = true;
            this.btnOption.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(157)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(702, 333);
            this.Controls.Add(this.btnOption);
            this.Controls.Add(this.pnlD);
            this.Controls.Add(this.labClose);
            this.Controls.Add(this.labS);
            this.Controls.Add(this.labError);
            this.Controls.Add(this.labTrue);
            this.Controls.Add(this.labCount);
            this.Controls.Add(this.txtInner);
            this.Controls.Add(this.labC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmMain";
            this.Text = "英语测评";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseDown);
            this.pnlD.ResumeLayout(false);
            this.pnlD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtInner;
        private System.Windows.Forms.Label labGo;
        private System.Windows.Forms.Label labCount;
        private System.Windows.Forms.Label labTrue;
        private System.Windows.Forms.Label labError;
        private System.Windows.Forms.Label labClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labS;
        private System.Windows.Forms.Panel pnlD;
        private System.Windows.Forms.Button btnOption;
    }
}

