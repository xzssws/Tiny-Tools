using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace Dzmrap
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Validation.CheckWindow.Check(successmethod);
        }
        private void successmethod()
        {
            Dzmrap.MainWindow v = new MainWindow();
            this.MainWindow = v;
            v.Hide();
        }
    }
}
