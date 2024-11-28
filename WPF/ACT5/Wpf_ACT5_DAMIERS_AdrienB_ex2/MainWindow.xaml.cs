using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_ACT5_DAMIERS_AdrienB_ex2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CreeDamier();
        }
        public void CreeDamier()
        {
            int nombre = 0;
            bool ligne = false;

            for (int x = 0; x < 10; x++)
            {
                ColumnDefinition col = new ColumnDefinition();
                Index.ColumnDefinitions.Add(col);
                RowDefinition row = new RowDefinition();
                Index.RowDefinitions.Add(row);
                for (int y = 0; y < 10; y++)
                {
                    


                    Button tktMonReuf = new Button();
                    
                    tktMonReuf.FontWeight = FontWeights.Bold;
                    tktMonReuf.FontSize = 30;
                    tktMonReuf.Foreground = Brushes.Red;

                    if (ligne)
                    {
                        nombre--;
                        tktMonReuf.Content = nombre;
                    }
                    else
                    {
                        nombre++;
                        tktMonReuf.Content = nombre;
                    }


                    if (nombre % 2 == 0)
                    {
                        tktMonReuf.Background = Brushes.Black;
                    }


                    tktMonReuf.Click += HideNum;

                    Grid.SetRow(tktMonReuf, x);
                    Grid.SetColumn(tktMonReuf, y);

                    Index.Children.Add(tktMonReuf);
                }
                ligne = !ligne;
                if (!ligne)
                {
                    nombre += 9;
                } else
                {
                    nombre += 11;
                }
            }
        }
        private void HideNum(object sender, RoutedEventArgs e)
        {
            ((Button)sender).Content = "";
        }
    }
}