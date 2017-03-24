using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JLControls
{
    public partial class SetParent : UserControl
    {
        public SetParent()
        {
            InitializeComponent();
        }
        private int aleft;
        public int Speed { get; set; }
        private bool isNext = true;
        public void GoNext()
        {
            if (isNext)
            {
                aleft = this.Left;
                TimerN.Start();
            }
        }
        public void GoUp()
        {
            if (!isNext)
            {
                TimerU.Start();
            }
        }
        private void TimerN_Tick(object sender, EventArgs e)
        {
            if (this.Left + this.Width > 0)
                this.Left -= Speed;
            else
            {
                TimerN.Stop();
                isNext = false;
            }
        }

        private void TimerU_Tick(object sender, EventArgs e)
        {
            if (this.Left < aleft)
                this.Left += Speed;
            else
            {
                TimerU.Stop();
                isNext = true;
            }
        }
    }
}
