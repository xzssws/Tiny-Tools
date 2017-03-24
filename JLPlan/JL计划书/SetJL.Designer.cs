namespace JL计划书
{
    partial class SetJL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.timerN = new System.Windows.Forms.Timer(this.components);
            this.timerU = new System.Windows.Forms.Timer(this.components);
            this.set11 = new JLControls.Set1();
            this.set21 = new JLControls.Set2();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(143)))), ((int)(((byte)(207)))));
            this.btnNext.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(492, 223);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(67, 35);
            this.btnNext.TabIndex = 12;
            this.btnNext.Text = "下一步";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(143)))), ((int)(((byte)(207)))));
            this.btnUp.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUp.ForeColor = System.Drawing.Color.White;
            this.btnUp.Location = new System.Drawing.Point(419, 223);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(67, 35);
            this.btnUp.TabIndex = 12;
            this.btnUp.Text = "上一步";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // set11
            // 
            this.set11.Location = new System.Drawing.Point(3, 12);
            this.set11.Name = "set11";
            this.set11.Size = new System.Drawing.Size(576, 205);
            this.set11.Speed = 30;
            this.set11.TabIndex = 13;
            // 
            // set21
            // 
            this.set21.Location = new System.Drawing.Point(3, 12);
            this.set21.Name = "set21";
            this.set21.Size = new System.Drawing.Size(576, 205);
            this.set21.Speed = 0;
            this.set21.TabIndex = 14;
            // 
            // SetJL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(143)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(580, 264);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.set11);
            this.Controls.Add(this.set21);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SetJL";
            this.Text = "快速设置";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private JLControls.Set1 set11;
        private JLControls.Set2 set21;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Timer timerN;
        private System.Windows.Forms.Timer timerU;

    }
}