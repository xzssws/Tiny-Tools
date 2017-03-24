using System;
using System.IO;

namespace MFileSpace
{
    /// <summary>
    /// �ļ���
    /// </summary>
    public class FileEx
    {
        /// <summary>
        /// �ƶ���ί��
        /// </summary>
        public delegate void Moved(double TotalSecond);

        /// <summary>
        /// �ƶ����¼�
        /// </summary>
        public event Moved FileMoved;

        public delegate void FgMessage(ref bool IsFg);

        /// <summary>
        /// ����ʱ�������¼�
        /// </summary>
        public event FgMessage MessageFg;

        #region ����

        public string FilePathSource;

        public string DirectoryPath;

        public string Title = "�ƶ�";

        #endregion ����

        public FileEx(PathConfig config)
        {
            this.FilePathSource = config.FilePathSource;
            this.DirectoryPath = config.DirectoryPath;

            if (string.IsNullOrEmpty(FilePathSource)) throw new Exception("�ļ�Ϊ��");
            if (string.IsNullOrEmpty(DirectoryPath)) throw new Exception("Ŀ¼Ϊ��");
            if (!File.Exists(FilePathSource)) throw new Exception("�ļ�������");
            if (!Directory.Exists(DirectoryPath)) throw new Exception("Ŀ¼������");

            if (config.Title != null)
            {
                this.Title = config.Title;
            }
        }

        /// <summary>
        /// ��ʼ�����ļ�
        /// </summary>
        /// <returns></returns>
        public void Copy()
        {
            try
            {
                int i = FilePathSource.LastIndexOf(@"\");
                string fileName = FilePathSource.Substring(i, FilePathSource.Length - i);
                //��ʱ
                TimeSpan ts = new TimeSpan(DateTime.Now.Ticks);
                //�Ƿ񸲸�
                bool isFg = true;
                if (File.Exists(DirectoryPath + fileName))
                {
                    if (this.MessageFg != null)
                    {
                        this.MessageFg(ref isFg);
                    }
                    if (isFg == false) return;
                }
                File.Copy(FilePathSource, DirectoryPath + fileName, isFg);

                double time = new TimeSpan(DateTime.Now.Ticks).Subtract(ts).TotalSeconds;

                if (FileMoved != null)
                {
                    FileMoved(time);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}