using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JLControls;

namespace JL计划书
{
    public partial class SetJL : Form
    {
        public SetJL()
        {
            InitializeComponent();
            sp[0] = set11;
            sp[1] = set21;
        }
        private int index=0;
        private string DicSrc;
        private string FileName;
        private SetParent[] sp = new SetParent[2];

        private void btnNext_Click(object sender, EventArgs e)
        {
            switch (index)
            {
                case 0:
                    DicSrc = (sp[0] as Set1).FilePath;
                    break;
                case 1:
                    FileName =(sp[1] as Set2).FileName ;
                    break;
            }
            if (index<sp.Length&&index>=0)
            {
                sp[index].GoNext();
                index++;
            }
           
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                sp[index].GoUp();
            }
            index--;
            
        }
        
       //动画有毛病 配置没完成 尚不能保存
    }
}
