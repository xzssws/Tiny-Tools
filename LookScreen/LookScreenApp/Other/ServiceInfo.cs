using System;
using System.ComponentModel;
using System.IO;

namespace LookScreenApp
{
    /// <summary>
    /// 服务信息
    /// </summary>
    public class ServiceInfo : INotifyPropertyChanged
    {
        public ServiceInfo()
        {
            BeginTime = DateTime.Now;
        }

        private DateTime _beginTime;

        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime BeginTime
        {
            get { return _beginTime; }
            set
            {
                _beginTime = value;
                if (this.PropertyChanged != null)
                    this.PropertyChanged(this, new PropertyChangedEventArgs("BeginTime"));
            }
        }

        private DateTime _openTime;

        /// <summary>
        /// 开启时间
        /// </summary>
        public DateTime OpenTime
        {
            get { return _openTime; }
            set
            {
                _openTime = value;
                if (this.PropertyChanged != null)
                    this.PropertyChanged(this, new PropertyChangedEventArgs("OpenTime"));
            }
        }

        private string _path;

        /// <summary>
        /// 资源集路径
        /// </summary>
        public string Path
        {
            get { return _path; }
            set
            {
                _path = value;
                if (this.PropertyChanged != null)
                    this.PropertyChanged(this, new PropertyChangedEventArgs("Path"));
            }
        }

        private int _resourceSize;

        /// <summary>
        /// 单个资源大小
        /// </summary>
        public int ResourceSize
        {
            get { return _resourceSize; }
            set
            {
                _resourceSize = value;
                if (this.PropertyChanged != null)
                    this.PropertyChanged(this, new PropertyChangedEventArgs("ResourceSize"));
            }
        }

        private int _resourceSpaceSize;

        /// <summary>
        /// 资源空间大小
        /// </summary>
        public int ResourceSpaceSize
        {
            get { return _resourceSpaceSize; }
            set
            {
                _resourceSpaceSize = value;
                if (this.PropertyChanged != null)
                    this.PropertyChanged(this, new PropertyChangedEventArgs("ResourceSpaceSize"));
            }
        }

        /// <summary>
        ///
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        public static long GetDirectoryLength(string dirPath)
        {
            //判断给定的路径是否存在,如果不存在则退出
            if (!Directory.Exists(dirPath))
                return 0;
            long len = 0;

            //定义一个DirectoryInfo对象
            DirectoryInfo di = new DirectoryInfo(dirPath);

            //通过GetFiles方法,获取di目录中的所有文件的大小
            foreach (FileInfo fi in di.GetFiles())
            {
                len += fi.Length;
            }

            //获取di中所有的文件夹,并存到一个新的对象数组中,以进行递归
            DirectoryInfo[] dis = di.GetDirectories();
            if (dis.Length > 0)
            {
                for (int i = 0; i < dis.Length; i++)
                {
                    len += GetDirectoryLength(dis[i].FullName);
                }
            }
            return len;
        }
    }
}