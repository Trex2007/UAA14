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

namespace Wpf_ACT5_DAMIERS_AdrienB_ex3
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
            int ligne = 0;

            for (int x = 0; x < 8; x++)
            {
                ColumnDefinition col = new ColumnDefinition();
                Index.ColumnDefinitions.Add(col);
                RowDefinition row = new RowDefinition();
                Index.RowDefinitions.Add(row);
                for (int y = 0; y < 8; y++)
                {
                    nombre++;

                    BitmapImage imageBouton = new BitmapImage();
                    
                    if (ligne == 1 || ligne == 6)
                    {
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("images/p.png", UriKind.Relative);
                        imageBouton.EndInit();
                    }
                    if (ligne == 0 || ligne == 7)
                    {
                        imageBouton.BeginInit();
                        if (y == 0 || y == 7) {
                            imageBouton.UriSource = new Uri("images/t.png", UriKind.Relative);
                        } else if (y == 1 || y == 6)
                        {
                            imageBouton.UriSource = new Uri("images/kn.png", UriKind.Relative);
                        } else if (y == 2 || y == 5)
                        {
                            imageBouton.UriSource = new Uri("images/p.png", UriKind.Relative);
                        } else if (y == 3)
                        {
                            imageBouton.UriSource = new Uri("images/k.png", UriKind.Relative);
                        } else if (y == 4)
                        {
                            imageBouton.UriSource = new Uri("images/q.png", UriKind.Relative);
                        }
                        imageBouton.EndInit();
                    }


                    Image imBouton = new Image();
                    imBouton.Source = imageBouton;
                    imBouton.Stretch = System.Windows.Media.Stretch.None;

                    Button tktMonReuf = new Button();
                    tktMonReuf.Content = imBouton;

                    if (ligne % 2 == 0)
                    {
                        if (nombre % 2 == 1)
                        {
                            tktMonReuf.Background = Brushes.Black;
                        }
                    }
                    else
                    {
                        if (nombre % 2 == 0)
                        {
                            tktMonReuf.Background = Brushes.Black;
                        }
                    }

                    



                    Grid.SetRow(tktMonReuf, x);
                    Grid.SetColumn(tktMonReuf, y);

                    Index.Children.Add(tktMonReuf);
                }
                ligne++;
            }
        }
    }
}