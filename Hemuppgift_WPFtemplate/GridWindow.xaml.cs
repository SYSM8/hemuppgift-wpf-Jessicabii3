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
    /// Interaction logic for GridWindow.xaml
    /// </summary>
    public partial class GridWindow : Window
    {
        public GridWindow()
        {
            InitializeComponent();
        }

        private void applyButton_Click(object sender, RoutedEventArgs e)
        {
            int row, column; //Hämta rad och kolumn från textfält
            if (int.TryParse(rowInput.Text, out row) && int.TryParse(columnInput.Text, out column))
            {
                //Kontrollera att row & kolumn är gilitga för gridens strl(0-3)
                if (row >= 0 && row < 4 && column >= 0 && column < 4)
                {
                    Button gridButton = new Button
                    {
                        Content = $"Row: {row}, Column: {column}", //Sätt innehåll för knappen
                        Background = Brushes.Lavender, //Sätt bakgrundsfärg
                        
                    };

                    
                    Grid.SetRow(gridButton, row);
                    Grid.SetColumn(gridButton, column);
                    MainGrid.Children.Add(gridButton);
                    
                }
                else
                {
                    MessageBox.Show("Vänligen ange giltig Row och Column mellan 0-3", "Felmeddelande", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Ange giltigt nummer för Row och Column", "Felmeddelande", MessageBoxButton.OK, MessageBoxImage.Stop);
            }
        }

        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            //Hämta värden från textboxarna
            if(int.TryParse(rowInput.Text,out int row) && int.TryParse(columnInput.Text, out int column))
            {
                // Kontrollera om värdena är giltiga
                if(row >= 0 && row < MainGrid.RowDefinitions.Count && column >=0 && column < MainGrid.ColumnDefinitions.Count)
                {
                    //Hitta och remove dn första texblock som ligger i den angivna cellen
                    for(int i = MainGrid.Children.Count - 1; i >= 0; i--) //Bakifrån(Undvika issues när man tar bort element)
                    {
                        var child = MainGrid.Children[i];

                        //Kontrollera om barnet är en TextBlock och ligger på rätt position
                        if (child is Button button)
                        {
                            if (Grid.GetRow(button) == row && Grid.GetColumn(button) == column)
                            {
                                MainGrid.Children.RemoveAt(i);
                                MessageBox.Show($"Removed {row}, {column}");
                                return;
                            }
                        }

                    }
                    MessageBox.Show($"Angiven Rad och Column finns inte med");

                }
                else
                {
                    MessageBox.Show("Inkorrekt Row och Column för borttagning", "Error",MessageBoxButton.OK,MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Vänligen ange en giltig Row och Column nummer","Felmeddelande", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
