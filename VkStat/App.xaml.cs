using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace VkStat
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void rectangle1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed) App.Current.MainWindow.DragMove();
        }

        private void rectangle2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
