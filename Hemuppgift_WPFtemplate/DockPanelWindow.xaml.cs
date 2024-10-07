using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for DockPanelWindow.xaml
    /// </summary>
    public partial class DockPanelWindow : Window
    {
        public DockPanelWindow()
        {
            InitializeComponent();
            MessageBox.Show("Välkommen! Tryck på knapparnaa för att få en överraskning!","Instruktioner", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void topBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Inte rätt, testa igen");
        }   

        private void bottemBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Inte rätt, testa igen");
        }

        private void leftBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Inte rätt, testa igen");
        }

        private void rightBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Inte rätt, testa igen");
        }

        private void centerBtn_Click(object sender, RoutedEventArgs e)
        {
            centerBtn.Visibility = Visibility.Collapsed;
            trophyImage.Visibility = Visibility.Visible; //Visar trophébilden när knappen klickas
        }
    }
}
