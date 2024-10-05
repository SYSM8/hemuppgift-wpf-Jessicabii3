using System.Windows;

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //HEJ
        public MainWindow()
        {
            InitializeComponent();
        }
        private void gridButton_Click(object sender, RoutedEventArgs e)
        {
            GridWindow gridWindow = new GridWindow();
            gridWindow.Show();
        }
        private void StackPanelButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void wrapPanelButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void dockPanelButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}