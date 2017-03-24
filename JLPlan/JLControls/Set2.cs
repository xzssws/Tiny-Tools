using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JLControls
{
    public partial class Set2 : JLControls.SetParent
    {
        public Set2()
        {
            InitializeComponent();
        }
        private string fName;
        private string Format;
        public string FileName { get;private set; }
        private void txt_Text_TextChanged(object sender, EventArgs e)
        {
            fName = txt_Text.Text;
            Set();
        }
        private void cmbFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbFormat.Text)
            {
                case "日期":
                    Format = DateTime.Now.Year + "年" + DateTime.Now.Month + "月" + DateTime.Now.Day + "日";
                    break;
                case "日期+时间":
                    Format = DateTime.Now.Year + "年" + DateTime.Now.Month + "月" + DateTime.Now.Day + "日 " + DateTime.Now.Hour + "时" + DateTime.Now.Minute + "分";
                    break;
                case "序号":
                    break;
            }
            Set();
        }
        public void Set()
        {
            FileName = rabFormatQ.Checked ? Format + fName : fName + Format;
            labFileName.Text = FileName;
        }
        private void rabFormatH_CheckedChanged_1(object sender, EventArgs e)
        {
             Set();
        }
    }
}
