using System.Collections.ObjectModel;
using System.Windows;

namespace LookScreenApp
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        #region 基本属性

        /// <summary>
        /// 计划计划
        /// </summary>
        public PlanCollection planCollection { get; set; }

        /// <summary>
        /// 配置
        /// </summary>

        private LookSrceenConfig _lookScreenConfig;

        public LookSrceenConfig LookScreenConfig
        {
            get
            {
                _lookScreenConfig = new LookSrceenConfig();
                return _lookScreenConfig;
            }
            set { _lookScreenConfig = value; }
        }

        /// <summary>
        /// 服务信息
        /// </summary>
        public ServiceInfo serviceInfo { get; set; }

        private ObservableCollection<ImageType> imagetypes;

        /// <summary>
        /// 图片格式
        /// </summary>
        ///
        public ObservableCollection<ImageType> ImageTypeCollection
        {
            get
            {
                if (imagetypes == null) imagetypes = new ObservableCollection<ImageType>();
                return imagetypes;
            }
            set { imagetypes = value; }
        }

        private ObservableCollection<PathType> pathtypes;

        /// <summary>
        /// 路径格式
        /// </summary>
        public ObservableCollection<PathType> PathTypeCollection
        {
            get
            {
                if (pathtypes == null) pathtypes = new ObservableCollection<PathType>();
                return pathtypes;
            }
            set { pathtypes = value; }
        }

        private LookSrceen lookscreenService;

        /// <summary>
        /// 监控服务
        /// </summary>
        public LookSrceen LookScreenService
        {
            get
            {
                //如果为空则创建一个新的
                if (lookscreenService == null) lookscreenService = new LookSrceen(LookScreenConfig);
                return lookscreenService;
            }
            set { lookscreenService = value; }
        }

        #endregion 基本属性

        #region 加载周期

        /// <summary>
        /// 加载数据
        /// </summary>
        private void LoadData()
        {
            ImageTypeCollection.Add(new ImageType { CODE = ".bmp", Value = "BMP" });
            ImageTypeCollection.Add(new ImageType { CODE = ".jpg", Value = "JPEG" });
            ImageTypeCollection.Add(new ImageType { CODE = ".gif", Value = "GIF" });
            ImageTypeCollection.Add(new ImageType { CODE = ".png", Value = "PNG" });

            PathTypeCollection.Add(new PathType { CODE = "M+D|H", Value = @"月+日\时\" });
            PathTypeCollection.Add(new PathType { CODE = "M|D|H", Value = @"月\日\时\" });
            PathTypeCollection.Add(new PathType { CODE = "M+D+H", Value = @"月+日+时\" });
            PathTypeCollection.Add(new PathType { CODE = "M+D+W|H", Value = @"月+日+星期\时\" });
            PathTypeCollection.Add(new PathType { CODE = "M|D+W|H", Value = @"月\日+星期\时\" });
            PathTypeCollection.Add(new PathType { CODE = "J|M|D|H", Value = @"季度+月\日\时\" });
            PathTypeCollection.Add(new PathType { CODE = "J|M+D|H", Value = @"季度\月+日\时\" });
        }

        //初始化对象
        private void LoadCreateObj()
        {
            planCollection = new PlanCollection();
            serviceInfo = new ServiceInfo();
        }

        //加载绑定
        private void LoadControlBinding()
        {
            gridinfo.DataContext = serviceInfo;
            gridSystemConfig.DataContext = LookScreenConfig;
        }

        //读取配置
        private void ReadConfig()
        {
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //读取配置
            ReadConfig();
            //加载对象
            LoadCreateObj();
            //加载数据
            LoadData();
            //加载绑定
            LoadControlBinding();
        }

        #endregion 加载周期

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog ofd = new System.Windows.Forms.FolderBrowserDialog();
            if (System.Windows.Forms.DialogResult.OK == ofd.ShowDialog())
            {
                pathsrc.Text = ofd.SelectedPath;
                LookScreenConfig.FilePath = pathsrc.Text;
                serviceInfo.Path = LookScreenConfig.FilePath;
            }
        }

        #region 控制命令

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            this.LookScreenService.OnStart();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            this.lookscreenService.OnStop();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        #endregion 控制命令
    }
}

//没有绑定上去