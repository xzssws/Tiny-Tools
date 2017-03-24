namespace MFileSpace
{
    partial class CopyItem
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
            this.labTitle = new System.Windows.Forms.Label();
            this.labDir = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labFile = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labTitle
            // 
            this.labTitle.AutoEllipsis = true;
            this.labTitle.BackColor = System.Drawing.Color.Transparent;
            this.labTitle.ForeColor = System.Drawing.Color.Wheat;
            this.labTitle.Location = new System.Drawing.Point(44, 6);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(77, 12);
            this.labTitle.TabIndex = 9;
            // 
            // labDir
            // 
            this.labDir.AutoEllipsis = true;
            this.labDir.BackColor = System.Drawing.Color.Transparent;
            this.labDir.ForeColor = System.Drawing.Color.Wheat;
            this.labDir.Location = new System.Drawing.Point(30, 43);
            this.labDir.Name = "labDir";
            this.labDir.Size = new System.Drawing.Size(127, 12);
            this.labDir.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Wheat;
            this.label4.Location = new System.Drawing.Point(8, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "到";
            // 
            // labFile
            // 
            this.labFile.AutoEllipsis = true;
            this.labFile.BackColor = System.Drawing.Color.Transparent;
            this.labFile.ForeColor = System.Drawing.Color.Wheat;
            this.labFile.Location = new System.Drawing.Point(30, 23);
            this.labFile.Name = "labFile";
            this.labFile.Size = new System.Drawing.Size(127, 12);
            this.labFile.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Wheat;
            this.label3.Location = new System.Drawing.Point(8, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "从";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(233, 37);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(41, 27);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "更改";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdate.MouseLeave += new System.EventHandler(this.ButtonLeaveStyle);
            this.btnUpdate.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonMoveStyle);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnUpdate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonDownStyle);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(233, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(41, 32);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "删除";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.MouseLeave += new System.EventHandler(this.ButtonLeaveStyle);
            this.btnDelete.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonMoveStyle);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonDownStyle);
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCopy.ForeColor = System.Drawing.Color.White;
            this.btnCopy.Location = new System.Drawing.Point(163, 4);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(69, 60);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "复制";
            this.btnCopy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCopy.MouseLeave += new System.EventHandler(this.ButtonLeaveStyle);
            this.btnCopy.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonMoveStyle);
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            this.btnCopy.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonDownStyle);
            // 
            // CopyItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(121)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.labDir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCopy);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "CopyItem";
            this.Size = new System.Drawing.Size(278, 69);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Label labDir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label btnUpdate;
        private System.Windows.Forms.Label btnDelete;
        private System.Windows.Forms.Label btnCopy;
    }
}
