using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace MFileSpace
{
    public partial class CopyItem : UserControl
    {
        private readonly Color MDCOLOR = Color.FromArgb(100, 255, 255, 255);
        private readonly Color MLCOLOR = Color.FromArgb(50, 255, 255, 255);
        private readonly Color MMCOLOR = Color.FromArgb(80, 255, 255, 255);


        public CopyItem() { InitializeComponent(); }

        public CopyItem(PathConfig pconfig)
        {
            InitializeComponent();
            if (pconfig != null)
            {
                this.pathconfig = pconfig;
                this.O = new FileEx(pconfig);
                O.FileMoved += new FileEx.Moved(O_FileMoved);
                O.MessageFg += new FileEx.FgMessage(O_MessageFg);

                this.labDir.Text = O.DirectoryPath;
                this.labFile.Text = O.FilePathSource;
                labTitle.Text = O.Title;
            }
            else
            {
                throw new Exception("PathConfig������Ϊ��");
            }
        }

        /// <summary>
        /// �ƶ�����
        /// </summary>
        private FileEx O;
        /// <summary>
        /// ���ö���
        /// </summary>
        private PathConfig pathconfig;

        #region �¼�
        [Description("ɾ����ť�¼�")]
        public event EventHandler DeleteClick;
        [Description("���°�ť�¼�")]
        public event EventHandler UpdateClick;
        [Description("��������¼�")]
        public event FileEx.Moved FileMoved;
        [Description("���������¼�")]
        public event FileEx.FgMessage IsCopy;
        #endregion

        #region �¼�����

        private void btnCopy_Click(object sender, EventArgs e)
        {
            O.Copy();
        }

        public void O_MessageFg(ref bool IsFg)
        {
            if (IsCopy != null)
            {
                IsCopy(ref IsFg);
            }

        }

        public void O_FileMoved(double TotalSecond)
        {
            if (FileMoved != null)
            {
                FileMoved(TotalSecond);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DeleteClick != null)
            {
                DeleteClick(this.pathconfig, e);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (UpdateClick != null)
            {
                UpdateClick(this.pathconfig, e);
            }
        }

        private void ButtonMoveStyle(object sender, MouseEventArgs e)
        {
            (sender as Control).BackColor = MMCOLOR;
       
        }
        private void ButtonDownStyle(object sender, MouseEventArgs e)
        {
            (sender as Control).BackColor = MDCOLOR;
       
        }
        private void ButtonLeaveStyle(object sender, EventArgs e)
        {
            (sender as Control).BackColor = MLCOLOR;
    
        }
        #endregion
        
    }
}
