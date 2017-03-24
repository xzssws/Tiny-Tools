using System;
using System.IO;

namespace MFileSpace
{
    /// <summary>
    /// 文件类
    /// </summary>
    public class FileEx
    {
        /// <summary>
        /// 移动到委托
        /// </summary>
        public delegate void Moved(double TotalSecond);

        /// <summary>
        /// 移动到事件
        /// </summary>
        public event Moved FileMoved;

        public delegate void FgMessage(ref bool IsFg);

        /// <summary>
        /// 覆盖时发生的事件
        /// </summary>
        public event FgMessage MessageFg;

        #region 属性

        public string FilePathSource;

        public string DirectoryPath;

        public string Title = "移动";

        #endregion 属性

        public FileEx(PathConfig config)
        {
            this.FilePathSource = config.FilePathSource;
            this.DirectoryPath = config.DirectoryPath;

            if (string.IsNullOrEmpty(FilePathSource)) throw new Exception("文件为空");
            if (string.IsNullOrEmpty(DirectoryPath)) throw new Exception("目录为空");
            if (!File.Exists(FilePathSource)) throw new Exception("文件不存在");
            if (!Directory.Exists(DirectoryPath)) throw new Exception("目录不存在");

            if (config.Title != null)
            {
                this.Title = config.Title;
            }
        }

        /// <summary>
        /// 开始复制文件
        /// </summary>
        /// <returns></returns>
        public void Copy()
        {
            try
            {
                int i = FilePathSource.LastIndexOf(@"\");
                string fileName = FilePathSource.Substring(i, FilePathSource.Length - i);
                //计时
                TimeSpan ts = new TimeSpan(DateTime.Now.Ticks);
                //是否覆盖
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