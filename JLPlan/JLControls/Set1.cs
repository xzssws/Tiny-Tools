using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JLControls
{
    public partial class Set1 : JLControls.SetParent
    {
        public Set1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 获得选择的地址
        /// </summary>
        public string FilePath { get; private set; }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                FilePath = fbd.SelectedPath;
                labSrc.Text = fbd.SelectedPath;
            }
        }
    }
}
