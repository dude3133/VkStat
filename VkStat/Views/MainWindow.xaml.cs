using System.Windows;
using System.Windows.Input;

namespace VkStat.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void rectangle1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed) DragMove();
        }

        private void rectangle2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }
    }
}
