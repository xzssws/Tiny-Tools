using System;
using System.Windows;

namespace Dzmrap.Validation
{
    /// <summary>
    /// CheckWindow.xaml 的交互逻辑
    /// </summary>
    public partial class CheckWindow : Window
    {
        public CheckWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 验证方法
        /// </summary>
        /// <param name="SucessEvent">成功</param>
        public static void Check(Action SucessEvent)
        {
            CheckWindow thi = new CheckWindow();
            thi.SuccessEvent = SucessEvent;
            thi.Validate = ValidationClass.Instance;
            if (!thi.Validate.IsValidated())
            {
                thi.Show();
            }
            else if (!thi.Validate.IsExpired())
            {
                thi.Success();
            }
            else
            {
                thi.Show();
            }
        }

        public event Action SuccessEvent;

        #region 属性

        /// <summary>
        /// 验证对象
        /// </summary>
        private IValidate Validate;

        /// <summary>
        /// 表示验证是否成功
        /// </summary>
        public bool IsSuccess { get; set; }

        #endregion 属性

        private void btn_ok_Click(object sender, RoutedEventArgs e)
        {
            if (Validate.ValidateMethod(txt_number.Text))
            {
                MessageBox.Show("认证成功");
                Success();
                this.Close();
            }
            else
            {
                MessageBox.Show("认证失败");
                IsSuccess = false;
            }
        }

        private void Success()
        {
            IsSuccess = true;
            if (SuccessEvent != null) SuccessEvent();
        }

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            IsSuccess = false;
        }
    }
}