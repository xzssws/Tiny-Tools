using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace LookScreenApp
{
    /// <summary>观察图像
    /// </summary>
    public class LookSrceen
    {
        #region -_-我是构造部分

        public LookSrceen()
        {
            try
            {
                threadimage = new System.Threading.Thread(SaveImage);
            }
            catch (System.ArgumentNullException ex)
            {
                WriteLog("构造出错：空指针异常" + ex.Message);
            }
            catch (Exception ex)
            {
                WriteLog("启动出错：未知异常" + ex.Message);
            }
        }

        public LookSrceen(int time)
            : this()
        {
            this.SPLITTIME = time;
        }

        public LookSrceen(LookSrceenConfig config)
        {
            if (config != null)
            {
                this.Config = config;
            }
        }

        #endregion -_-我是构造部分

        #region 0-0我是属性字段

        private LookSrceenConfig config;

        public LookSrceenConfig Config
        {
            get { return config; }
            set
            {
                config = value;
                this.SPLITTIME = config.Time * 1000;
                this.DirName = config.FilePath;
            }
        }

        /// <summary>
        /// 间隔时间设为5分钟
        /// </summary>
        private int SPLITTIME;

        /// <summary>
        /// 文件名称
        /// </summary>
        private string FileName;

        /// <summary>
        /// 目录名称
        /// </summary>
        private string dirName = "C:\\Images";

        /// <summary>
        /// 目录名称
        /// </summary>
        public string DirName
        {
            get
            {
                return dirName;
            }
            set
            {
                this.dirName = value;
            }
        }

        /// <summary>
        /// 线程
        /// </summary>
        private System.Threading.Thread threadimage;

        #endregion 0-0我是属性字段

        #region -=-我是开放功能

        /// <summary>
        /// 开启监视
        /// </summary>
        public void OnStart()
        {
            try
            {
                if (threadimage == null)
                    threadimage = new System.Threading.Thread(SaveImage);

                threadimage.Start();
                // WriteLog("开启服务");
            }
            catch (System.ArgumentNullException ex)
            {
                WriteLog("构造出错：空指针异常" + ex.Message);
            }
            catch (System.Threading.ThreadStateException ex)
            {
                WriteLog("启动出错：线程状态异常" + ex.Message);
            }
            catch (System.OutOfMemoryException ex)
            {
                WriteLog("启动出错：内存不足" + ex.Message);
            }
            catch (System.Security.SecurityException ex)
            {
                WriteLog("启动出错：安全性异常" + ex.Message);
            }
            catch (Exception ex)
            {
                WriteLog("启动出错：未知异常" + ex.Message);
            }
        }

        /// <summary>
        /// 停止监视
        /// </summary>
        public void OnStop()
        {
            try
            {
                threadimage.Abort();
            }
            catch (System.Threading.ThreadStateException ex)
            {
                WriteLog("启动出错：线程状态异常" + ex.Message);
            }
            catch (System.Security.SecurityException ex)
            {
                WriteLog("启动出错：安全性异常" + ex.Message);
            }
            catch (Exception ex)
            {
                WriteLog("启动出错：未知异常" + ex.Message);
            }
        }

        #endregion -=-我是开放功能

        #region 0=0我是内部功能

        /// <summary>
        /// 保存图片
        /// </summary>
        private void SaveImage()
        {
            while (true)
            {
                //格式化文本
                string code = Config.SaveType.CODE;
                string expstr = Config.ImageType.CODE;
                string DirSon;
                Format(code, out DirSon, out FileName);//获得临时目录
                FileName += expstr;//添加后缀

                string DirNameX = DirName + DirSon;
                if (!Directory.Exists(DirNameX))
                {
                    Directory.CreateDirectory(DirNameX);
                }

                Bitmap image = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                //创建画布
                Graphics imgGraphics = Graphics.FromImage(image);
                //设置截屏区域
                imgGraphics.CopyFromScreen(0, 0, 0, 0, new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height));
                //保存
                image.Save(DirNameX + FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                //间隔时间
                GC.Collect();
                System.Threading.Thread.Sleep(SPLITTIME);
            }
        }

        /// <summary>
        /// 输出日志
        /// </summary>
        /// <param name="log">字符串</param>
        private void WriteLog(string log)
        {
            File.AppendAllText("C:\\Log.log", DateTime.Now.ToLongTimeString() + Environment.NewLine + log + Environment.NewLine, UTF8Encoding.UTF8);
        }

        #region 帮助功能 要被去除

        public void Format(string Code, out string DirStr, out string FilePath)
        {
            DateTime dateNow = DateTime.Now;
            FilePath = dateNow.Minute + "分";
            string Jidu = GetJiDu(dateNow);
            string month = dateNow.Month.ToString() + "月";
            string day = dateNow.Day.ToString() + "日";
            string week = dateNow.DayOfWeek.ToString();
            string hour = dateNow.Hour.ToString() + "时";
            DirStr = "Error\\";
            switch (Code)
            {
                case "M+D|H":
                    DirStr = string.Format("\\{0}{1}\\{2}\\", month, day, hour);
                    break;

                case "M|D|H":
                    DirStr = string.Format("\\{0}\\{1}\\{2}\\", month, day, hour);

                    break;

                case "M+D+H":
                    DirStr = string.Format("\\{0}{1}{2}\\", month, day, hour);

                    break;

                case "M+D+W|H":
                    DirStr = string.Format("\\{0}{1}{2}\\{3}\\", month, day, week, hour);
                    break;

                case "M|D+W|H":
                    DirStr = string.Format("\\{0}\\{1}{2}\\{3}\\", month, day, week, hour);
                    break;

                case "J|M|D|H":
                    DirStr = string.Format("\\{0}\\{1}\\{2}\\{3}\\", Jidu, month, day, hour);
                    break;

                case "J|M+D|H":
                    DirStr = string.Format("\\{0}\\{1}{2}\\{3}\\", Jidu, month, day, hour);
                    break;

                default:
                    break;
            }
        }

        private string GetJiDu(DateTime dt)
        {
            int month = dt.Month;
            if (month > 0 && month < 4) return "第一季度";
            else if (month >= 4 && month < 7) return "第二季度";
            else if (month >= 7 && month <= 9) return "第三季度";
            else if (month > 9 && month <= 12) return "第四季度";
            else throw new Exception("错误!");
        }

        #endregion 帮助功能 要被去除

        #endregion 0=0我是内部功能
    }
}