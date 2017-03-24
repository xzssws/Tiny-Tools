using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace MFileSpace
{
    public partial class MFile : Form
    {
        public MFile()
        {
            InitializeComponent();
        }

        #region �Զ��巽��
        /// <summary>
        /// ����������ò���ʾ����
        /// </summary>
        public void LoadConfig()
        {
            try
            {
                //��ʼ��XML����
                cmlConfig = CMLCONFIG.CreateXmlConfig;
                //�����ĵ�  �˴�Ӧ���޸� ���ĵ�Ϊ�յ�ʱ�� һ������
                cmlConfig.Load();
                AutoButton();
                //labClearConfig.Enabled = cmlConfig.EasyFilecg.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "�������ô���", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /// <summary>
        /// Ѱ�����ó�ʼ���б�
        /// </summary>
        private void AutoButton()
        {

            flpButton.Controls.Clear();

            foreach (PathConfig cc in cmlConfig.EasyFilecg)
            {
                CopyItem copyItem = new CopyItem(cc);
                copyItem.Size = new System.Drawing.Size(278, 69);
                //TODO:������ʱ�� Button�滻���µĿؼ� 
                #region �¼�
                copyItem.FileMoved += new FileEx.Moved(fe_FileMoved);
                copyItem.IsCopy += new FileEx.FgMessage(fe_MessageFg);
                copyItem.DeleteClick += new EventHandler(fe_Delete);
                

                #endregion
                flpButton.Controls.Add(copyItem);

                AutoMenu();
            }
        }

        void fe_Delete(object sender, EventArgs e)
        {
            cmlConfig.Delete(sender as PathConfig);
           LoadConfig();
        }

        private void AutoMenu()
        {
            ContextMenuFileMove.DropDownItems.Clear();
            foreach (PathConfig cc in cmlConfig.EasyFilecg)
            {
                ToolStripMenuItem ToolMenuItem = new ToolStripMenuItem(cc.Title);
                #region ��ʽ
                ToolMenuItem.Size = new System.Drawing.Size(152, 22);
                #endregion
                #region ����
                ToolMenuItem.Tag = cc;
                //this.ToolTipMessage.SetToolTip(ToolMenuItem, string.Format("����:{0}\n�ļ�:{1}\nĿ¼:{2}\n", cc.Title, cc.FilePathSource, cc.DirectoryPath));
                #endregion
                #region �¼�
                ToolMenuItem.Click += new EventHandler(MoveFile);
                #endregion
                ContextMenuFileMove.DropDownItems.Add(ToolMenuItem);
            }

        }
        /// <summary>
        /// ����ȫ·����ȡ�ļ���Ŀ¼����
        /// </summary>
        /// <param name="FullName">ȫ·��</param>
        /// <returns>�ļ���Ŀ¼����</returns>
        public string GetName(string FullName)
        {
            if (FullName.Length > 4)
            {
                int i = FullName.LastIndexOf(@"\");
                return FullName.Substring(i, FullName.Length - i).TrimStart("\\".ToCharArray());
            }
            else
            {
                return FullName;
            }
        }
        /// <summary>
        /// �ж��ļ��Ƿ���ƶ� ̫��
        /// </summary>
        /// <param name="filename">�ļ�����</param>
        /// <returns>�Ƿ���ƶ�</returns>
        public bool ValidateFile(string filename)
        {
            FileInfo fi = new FileInfo(filename);
            if (fi.Length > 1024 * 1024 * 10)
            {
                MessageBox.Show("שͷ̫���ˣ��᲻����");
                return false;
            }
            return true;

        }

        //�ж�·��
        private bool SetOK()
        {
            if (!(string.IsNullOrEmpty(pc.FilePathSource) || string.IsNullOrEmpty(pc.DirectoryPath)))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        #endregion

        #region �ֶ�����

        /// <summary>
        /// CML���ð���
        /// </summary>
        CMLCONFIG cmlConfig;

        /// <summary>
        /// ·�����ö���
        /// </summary>
        PathConfig pc;

        /// <summary>
        /// ��Ϣ
        /// </summary>
        public string Message
        {
            set { labMessage.Text = value; }
        }

        #endregion

        #region �����¼�


        //�رհ�ť
        private void labClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //��ӵ�����
        private void AddPathConfig(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(pc.FilePathSource)) throw new Exception("��δѡ�����ļ�");
                if (string.IsNullOrEmpty(pc.DirectoryPath)) throw new Exception("��δѡ��Ŀ���ļ���");

                pc.Title = "����:" + GetName(pc.FilePathSource);

                cmlConfig.AddSave(pc);
                pc = null;
                //������ť
                AutoButton();

                //��ʾ��Ϣ
                Message = "������óɹ�!";
            }
            catch (Exception ex)
            {
                Message = "������ô���!" + ex.Message;
                MessageBox.Show("������ô���!" + ex.Message);
            }
        }
        //��������
        private void ClearConfig(object sender, EventArgs e)
        {

            if (MessageBox.Show("�Ƿ�Ҫ�������", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    cmlConfig.Reset();
                    AutoButton();
                    pc = null;

                    Message = "������óɹ�!";
                    (sender as Control).Enabled = false;
                }
                catch (Exception ex)
                {
                    Message = "�������ô���!" + ex.Message;
                }
            }
        }
        //ѡ���ļ�
        private void btnFile_Click(object sender, EventArgs e)
        {
            if (pc == null)
                pc = new PathConfig();

            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //�ж��ļ��Ƿ����
                if (!ValidateFile(ofd.FileName)) return;

                pc.FilePathSource = ofd.FileName;

                Message = "�ļ�ѡ�����" + pc.FilePathSource;
            }
        }
        //ѡ��Ŀ¼
        private void btnDir_Click(object sender, EventArgs e)
        {
            if (pc == null)
                pc = new PathConfig();

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                pc.DirectoryPath = fbd.SelectedPath;
                Message = "Ŀ¼ѡ�����!" + pc.DirectoryPath;
            }
        }
        //�����ļ�
        public void MoveFile(object sender, EventArgs e)
        {
            try
            {
                FileEx fe;
                PathConfig fc;
                if (sender is ToolStripMenuItem)
                {
                    fc = (sender as ToolStripMenuItem).Tag as PathConfig;
                }
                else
                {
                    fc = (sender as Button).Tag as PathConfig;
                }
                fe = new FileEx(fc);
                fe.FileMoved += new FileEx.Moved(fe_FileMoved);
                fe.MessageFg += new FileEx.FgMessage(fe_MessageFg);
                fe.Copy();
            }
            catch (Exception ex)
            {
                Message = "�����ļ�����:" + ex.Message;
                MessageBox.Show(ex.Message, "�����ļ�����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //ͼ�̲˵��˳�
        private void ContextMenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //���̲˵���ʾ
        private void ContextMenuShow_Click(object sender, EventArgs e)
        {
            this.Show();
        }
        //˫������
        private void nficon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = !this.Visible;
        }
        //���ذ�ť
        private void labHide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        #endregion

        #region �����¼�

        //�������
        private void FormLoad(object sender, EventArgs e)
        {
            LoadConfig();
            Message = "�����ļ����سɹ�";
        }
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();//�����ⲿ�ļ�User32.dll�еķ��� ReleaseCapture����  
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int IParam);//�����ⲿ�ļ�User32.dll�ļ��е�SendMessage����
        public static void �ƶ�����(IntPtr ��ǰ������)
        {
            ReleaseCapture();
            SendMessage(��ǰ������, 0x0112, 0xf010 + 0x0002, 0);//ʵ���ƶ� δ֪����
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            �ƶ�����(this.Handle);
        }
        #endregion

        #region �������¼�

        /// <summary>
        /// ���ļ��Ѿ�������Ҫ���ǵ�ʱ�򴥷��¼�
        /// </summary>
        /// <param name="IsFg">�Ƿ���Ҫ����</param>
        void fe_MessageFg(ref bool IsFg)
        {
            if (DialogResult.Yes == MessageBox.Show("��Ҫ���Ƶ��ļ��Ѿ����ڣ��Ƿ���Ҫ���ǣ�", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                IsFg = true;
            }
            else
            {
                IsFg = false;
            }
        }

        /// <summary>
        /// ���Ƴɹ����¼�
        /// </summary>
        /// <param name="TotalSecond">���ƺ�����</param>
        void fe_FileMoved(double TotalSecond)
        {
            Message = "�ƶ��ɹ�,��ʱ:" + TotalSecond.ToString() + "��";
            nficon.ShowBalloonTip(1000, "�ƶ��ɹ�", "��ʱ:" + TotalSecond.ToString() + "��", ToolTipIcon.Info);

            //TODO:���ƶ��ɹ���ʱ���Ƿ���Ҫ����Ӧ�ó���
            //Process.Start(@"C:\Documents and Settings\Administrator\Application Data\Inspur\GSZJ\GSFramework.exe");
            //this.Hide();
        }
       
        

        #endregion

        #region �ϷŲ���

        //�Ϸ��ļ�
        private void btnFile_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] str = (string[])e.Data.GetData(DataFormats.FileDrop, true);//��ȡ�Ϸ��ļ���·�� ���������[0]���ļ�·��

                if (str.Length > 0)
                {
                    if (File.Exists(str[0]))
                    {
                        //�ж��ļ��Ƿ����
                        if (!ValidateFile(str[0])) return;

                        if (pc == null) pc = new PathConfig();
                        pc.FilePathSource = str[0];

                        Message = "�ļ�ѡ�����!" + pc.FilePathSource;

                    }
                    else
                    {
                        throw new Exception("�ļ�������!");
                    }
                }
            }
            catch (Exception ex)
            {
                Message = "�ļ�ѡ��ʧ��!" + ex.Message;
            }
        }
        //�ϷŹ���
        private void ControlDragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        //�Ϸ�Ŀ¼
        private void btnDir_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                e.Effect = DragDropEffects.Copy;
                string[] str = (string[])e.Data.GetData(DataFormats.FileDrop, true);//��ȡ�Ϸ��ļ���·�� ���������[0]���ļ�·��

                if (str.Length > 0)
                {
                    if (Directory.Exists(str[0]))
                    {
                        if (pc == null) pc = new PathConfig();
                        pc.DirectoryPath = str[0];
                        Message = "Ŀ¼ѡ�����!" + pc.DirectoryPath;
                    }
                    else
                    {
                        throw new Exception("Ŀ¼������!");

                    }
                }
            }
            catch (Exception ex)
            {
                Message = "Ŀ¼ѡ��ʧ��!" + ex.Message;
            }
        }

        #endregion

        #region ������

        private void ButtonMoveStyle(object sender, MouseEventArgs e)
        {
            (sender as Control).BackColor = Color.FromArgb(50, 255, 255, 255);
        }
        private void ButtonDownStyle(object sender, MouseEventArgs e)
        {
            (sender as Control).BackColor = Color.FromArgb(80, 255, 255, 255);
        }
        private void ButtonLeaveStyle(object sender, EventArgs e)
        {
            (sender as Control).BackColor = System.Drawing.Color.Transparent;
        }
        private void labClose_MouseMove(object sender, MouseEventArgs e)
        {
            (sender as Label).ForeColor = Color.White;
        }
        private void labClose_MouseLeave(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = Color.DarkGray;
        }

        #endregion


    }
}

/*
 *  ����Ŀ�� �� ���Բ˵��ƶ�����ʹ�� Ū��֮����Ҫ��ʾ����
 *              
 * 
 * 
 *
 */