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
            StackPanelWindow stackPanelWindow = new StackPanelWindow();
            stackPanelWindow.Show(); // Öppnar StackPanelWindow

        }

        private void wrapPanelButton_Click(object sender, RoutedEventArgs e)
        {
            WrapPanelWindow wrapWindow = new WrapPanelWindow();
            wrapWindow.Show();
        }

        private void dockPanelButton_Click(object sender, RoutedEventArgs e)
        {
            DockPanelWindow dockPanelWindow = new DockPanelWindow(); 
            dockPanelWindow.Show();
        }
    }
}