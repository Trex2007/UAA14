using System.ComponentModel;
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

namespace act4_creationDynamique_2_AdrienB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Affichage();
        }
        public void Affichage()
        {
            ColumnDefinition Saoule1 = new ColumnDefinition();
            Index.ColumnDefinitions.Add(Saoule1);
            ColumnDefinition Saoule2 = new ColumnDefinition();
            Index.ColumnDefinitions.Add(Saoule2);
            ColumnDefinition Saoule3 = new ColumnDefinition();
            Index.ColumnDefinitions.Add(Saoule3);
            ColumnDefinition Saoule4 = new ColumnDefinition();
            Index.ColumnDefinitions.Add(Saoule4);

            RowDefinition Sal1 = new RowDefinition();
            Index.RowDefinitions.Add(Sal1);
            RowDefinition Sal2 = new RowDefinition();
            Index.RowDefinitions.Add(Sal2);
            RowDefinition Sal3 = new RowDefinition();
            Index.RowDefinitions.Add(Sal3);
            RowDefinition Sal4 = new RowDefinition();
            Index.RowDefinitions.Add(Sal4);



            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    Button tktMonReuf = new Button();
                    tktMonReuf.Content = "?";
                    tktMonReuf.FontSize = 50;

                    tktMonReuf.Click += GrosCaca;

                    Grid.SetRow(tktMonReuf, x);
                    Grid.SetColumn(tktMonReuf, y);

                    Index.Children.Add(tktMonReuf);
                }
            }
        }

        private void GrosCaca(object sender, RoutedEventArgs e)
        {
            ((Button)sender).Content = "X";
        }
    }
}