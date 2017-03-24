using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BuildData
{
    /// <summary>
    /// AddCustomer.xaml 的交互逻辑
    /// </summary>
    public partial class AddCustomer : Window
    {
        public AddCustomer()
        {
            InitializeComponent();
        }
        public AutoData.CustomerData<string> customerData;
        public void CreateCustomerData()
        {
            string[] result = TextContent.Text.Split(';');
            customerData = new AutoData.CustomerData<string>(result);
            this.DialogResult = true;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            CreateCustomerData();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
