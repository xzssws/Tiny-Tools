using System;
using System.ComponentModel;

namespace LookScreenApp
{
    /// <summary>
    /// 配置类
    /// </summary>
    [Serializable]
    public class LookSrceenConfig : INotifyPropertyChanged
    {
        private string _filePath = @"E:\Document\ScreenDB";

        /// <summary>
        /// 文档路径
        /// </summary>
        public string FilePath
        {
            get { return _filePath; }
            set
            {
                _filePath = value;
                if (this.PropertyChanged != null)
                    this.PropertyChanged(this, new PropertyChangedEventArgs("FilePath"));
            }
        }

        private int _time = 60;

        /// <summary>
        /// 监视时间
        /// </summary>
        public int Time
        {
            get { return _time; }
            set
            {
                _time = value;
                if (this.PropertyChanged != null)
                    this.PropertyChanged(this, new PropertyChangedEventArgs("Time"));
            }
        }

        private ImageType _imagetype;

        /// <summary>
        /// 图片类型
        /// </summary>
        public ImageType ImageType
        {
            get
            {
                if (_imagetype == null)
                {
                    _imagetype = new ImageType { CODE = ".jpg", Value = "JPEG" };
                }
                return _imagetype;
            }
            set
            {
                _imagetype = value;
                if (this.PropertyChanged != null)
                    this.PropertyChanged(this, new PropertyChangedEventArgs("ImageType"));
            }
        }

        private PathType _saveType;

        /// <summary>
        /// 保存格式
        /// </summary>
        public PathType SaveType
        {
            get
            {
                if (_saveType == null)
                {
                    _saveType = new PathType { CODE = "M+D|H", Value = @"月\日\时\" };
                }

                return _saveType;
            }
            set
            {
                _saveType = value;
                if (this.PropertyChanged != null)
                    this.PropertyChanged(this, new PropertyChangedEventArgs("SaveType"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}