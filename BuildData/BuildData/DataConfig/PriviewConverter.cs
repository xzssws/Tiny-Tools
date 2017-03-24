using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using BuildData.AutoData;

namespace BuildData.DataConfig
{
    class PriviewConverter : System.Windows.Data.IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string source = value.ToString();
            MainWindow mw = (MainWindow)Application.Current.MainWindow;
            foreach (var item in DataLibrary.DefaultFlag)
            {
                if (source.Contains(item.Key))
                    source = source.Replace(item.Key, AutoDataHelp.GetData(item.Value));
            }
            Dictionary<string, Flag> Flags = (Dictionary<string, Flag>)parameter;
            foreach (var item in mw.Config.Flags)
            {
                if (source.Contains(item.Key))
                    source = source.Replace(item.Key, AutoDataHelp.GetData(item.Value,item.Key));

            }
            return source;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return "";
        }
    }
}
