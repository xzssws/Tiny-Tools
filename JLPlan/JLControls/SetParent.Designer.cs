namespace JLControls
{
    partial class SetParent
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
            this.labTitle = new System.Windows.Forms.Label();
            this.labBz = new System.Windows.Forms.Label();
            this.TimerN = new System.Windows.Forms.Timer(this.components);
            this.TimerU = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTitle.ForeColor = System.Drawing.Color.White;
            this.labTitle.Location = new System.Drawing.Point(196, 48);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(145, 25);
            this.labTitle.TabIndex = 8;
            this.labTitle.Text = "设置保存文件夹";
            // 
            // labBz
            // 
            this.labBz.AutoSize = true;
            this.labBz.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labBz.ForeColor = System.Drawing.Color.White;
            this.labBz.Location = new System.Drawing.Point(19, 18);
            this.labBz.Name = "labBz";
            this.labBz.Size = new System.Drawing.Size(171, 62);
            this.labBz.TabIndex = 7;
            this.labBz.Text = "第一步";
            // 
            // TimerN
            // 
            this.TimerN.Interval = 14;
            this.TimerN.Tick += new System.EventHandler(this.TimerN_Tick);
            // 
            // TimerU
            // 
            this.TimerU.Interval = 14;
            this.TimerU.Tick += new System.EventHandler(this.TimerU_Tick);
            // 
            // SetParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.labBz);
            this.Name = "SetParent";
            this.Size = new System.Drawing.Size(576, 240);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label labTitle;
        protected System.Windows.Forms.Label labBz;
        private System.Windows.Forms.Timer TimerN;
        private System.Windows.Forms.Timer TimerU;

    }
}
