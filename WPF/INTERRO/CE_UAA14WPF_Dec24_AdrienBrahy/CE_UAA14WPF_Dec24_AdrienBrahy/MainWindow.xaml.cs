using System.Drawing;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CE_UAA14WPF_Dec24_AdrienBrahy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            NbreLignes.PreviewTextInput += new TextCompositionEventHandler(VerifTextInput); //verif si l'entrée user est entier
            NbreColonnes.PreviewTextInput += new TextCompositionEventHandler(VerifTextInput); //verif si l'entrée user est entier
        }
        /// <summary>
        /// verif si l'entrée user est entié
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void VerifTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!int.TryParse(e.Text, out int i))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// vérification de si le nombre est entier et renvoie le nombre adéquoit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void verifTaille(object sender, TextCompositionEventArgs e)
        {
            int.TryParse(e.Text, out int i);
        }

        /// <summary>
        /// calculer et faire afficher tous les graphs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculer_Click(object sender, RoutedEventArgs e)
        {
            ErrorText.Text = "Test WPF 6T 2024";

            ContentGame.Children.Clear();
            ContentGame.RowDefinitions.Clear();
            ContentGame.ColumnDefinitions.Clear();

            if (optSolitaire.IsChecked ?? false)
            {
                CreeSolitaire();
            }
            else if (optMarelle.IsChecked ?? false)
            {
                CreeMarelle();
            }
            else
            {
                int maxRow = 0;
                int maxCol = 0;
                if (int.TryParse(NbreLignes.Text, out int Row))
                {
                    maxRow = Row;
                }
                if (int.TryParse(NbreColonnes.Text, out int Col))
                {
                    maxCol = Col;
                }

                if(maxRow < 13 && maxCol < 13 && maxRow > 1 && maxCol > 1)
                {
                    CreeBande(maxRow, maxCol);
                }
                else
                {
                    ErrorText.Text = "Veuillez encoder des dimensions valides comprises entre 1 et 12;";
                }

                
            }
        }
        /// <summary>
        /// bouton pour tout reset
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            ErrorText.Text = "Test WPF 6T 2024";
            NbreLignes.Text = "";
            NbreColonnes.Text = "";

            optSolitaire.IsChecked = true;
            optMarelle.IsChecked = false;
            optBande.IsChecked = false;

            ContentGame.Children.Clear();
            ContentGame.RowDefinitions.Clear();
            ContentGame.ColumnDefinitions.Clear();

            BandeForm.Visibility = Visibility.Hidden;
        }
        /// <summary>
        /// buton de selection du "jeux" et affichage du menu supp pour un des 3 jeux
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButt(object sender, RoutedEventArgs e)
        {
            if (optSolitaire.IsChecked ?? false)
            {
                BandeForm.Visibility = Visibility.Hidden;

            }
            else if (optMarelle.IsChecked ?? false)
            {
                BandeForm.Visibility = Visibility.Hidden;
            }
            else
            {
                BandeForm.Visibility = Visibility.Visible;
            }
            ErrorText.Text = "Test WPF 6T 2024";
        }
        /// <summary>
        /// crée le jeux n1 - solitaire
        /// </summary>
        public void CreeSolitaire()
        {
            for (int x = 0; x < 9; x++)
            {
                ColumnDefinition col = new ColumnDefinition();
                ContentGame.ColumnDefinitions.Add(col);
                RowDefinition row = new RowDefinition();
                ContentGame.RowDefinitions.Add(row);
                for (int y = 0; y < 9; y++)
                {

                    Button tktMonReuf = new Button();
                    if(x > 5 && y > 2 && y < 6  || x < 3 && y > 2 && y < 6 || x == 3 || x == 4 || x == 5)
                    {
                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("Images/petitCercleRouge.png", UriKind.Relative);
                        imageBouton.EndInit();

                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        imBouton.Stretch = System.Windows.Media.Stretch.None;

                        tktMonReuf.Content = imBouton;

                        tktMonReuf.Background = Brushes.Khaki;

                        tktMonReuf.Click += ChangeNum;

                    } else
                    {
                        tktMonReuf.BorderBrush = Brushes.Transparent;
                        tktMonReuf.Background = Brushes.Transparent;
                    }

                    


                    Grid.SetRow(tktMonReuf, x);
                    Grid.SetColumn(tktMonReuf, y);

                    ContentGame.Children.Add(tktMonReuf);
                }

            }
        }
        /// <summary>
        /// crée le jeux n2 - Marelle
        /// </summary>
        public void CreeMarelle()
        {
            for (int x = 0; x < 7; x++)
            {
                ColumnDefinition col = new ColumnDefinition();
                ContentGame.ColumnDefinitions.Add(col);
                RowDefinition row = new RowDefinition();
                ContentGame.RowDefinitions.Add(row);
                for (int y = 0; y < 7; y++)
                {

                    Button tktMonReuf = new Button();
                    if (
                        x == 0 && y == 0 || x == 0 && y == 3 || x == 0 && y == 6
                        ||
                        x == 6 && y == 0 || x == 6 && y == 3 || x == 6 && y == 6
                        ||
                        x == 1 && y % 2 == 1
                        ||
                        x == 5 && y % 2 == 1
                        ||
                        x == 2 && y > 1 && y < 5
                        ||
                        x == 4 && y > 1 && y < 5
                        ||
                        x == 3 && y != 3
                        )
                    {
                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("Images/petitCercleRouge.png", UriKind.Relative);
                        imageBouton.EndInit();

                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        imBouton.Stretch = System.Windows.Media.Stretch.None;

                        tktMonReuf.Content = imBouton;

                        tktMonReuf.Background = Brushes.Khaki;

                        tktMonReuf.Click += ChangeNum;

                    }
                    else
                    {
                        tktMonReuf.BorderBrush = Brushes.Transparent;
                        tktMonReuf.Background = Brushes.Transparent;
                    }




                    Grid.SetRow(tktMonReuf, x);
                    Grid.SetColumn(tktMonReuf, y);

                    ContentGame.Children.Add(tktMonReuf);
                }

            }
        }
        /// <summary>
        /// Création du jeux 3 avec un trou au millieu
        /// </summary>
        /// <param name="maxRow">nombre de rows</param>
        /// <param name="maxCol">nombre de collumns</param>
        public void CreeBande(int maxRow, int maxCol)
        {
            for (int x = 0; x < maxRow; x++)
            {
                ColumnDefinition col = new ColumnDefinition();
                ContentGame.ColumnDefinitions.Add(col);
                for (int y = 0; y < maxCol; y++)
                {
                    if(x == 0)
                    {
                        RowDefinition row = new RowDefinition();
                        ContentGame.RowDefinitions.Add(row);
                    }
                    

                    Button tktMonReuf = new Button();
                    
                    if (x == 0 || y == 0 || x == maxRow-1 || y == maxCol-1)
                    {
                        tktMonReuf.Content = "X";
                        tktMonReuf.FontSize = 30;

                        tktMonReuf.Foreground = Brushes.Red;

                        tktMonReuf.Background = Brushes.Khaki;

                        tktMonReuf.Click += ChangeColor;

                    }
                    else
                    {
                        tktMonReuf.BorderBrush = Brushes.Transparent;
                        tktMonReuf.Background = Brushes.Transparent;
                    }




                    Grid.SetRow(tktMonReuf, y);
                    Grid.SetColumn(tktMonReuf, x);

                    ContentGame.Children.Add(tktMonReuf);
                }
            }
        }
        /// <summary>
        /// changer la couleur de la case touchée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeColor(object sender, RoutedEventArgs e)
        {
            if (((Button)sender).Background == Brushes.Khaki)
            {
                ((Button)sender).Background = Brushes.Red;
                ((Button)sender).Foreground = Brushes.Khaki;
            }
            else
            {
                ((Button)sender).Background = Brushes.Khaki;
                ((Button)sender).Foreground = Brushes.Red;
            }
        }
        /// <summary>
        /// changée l'image du nombre touché
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeNum(object sender, RoutedEventArgs e)
        {
            BitmapImage imageBouton = new BitmapImage();
            imageBouton.BeginInit();
            imageBouton.UriSource = new Uri("Images/golfBall60.png", UriKind.Relative);
            imageBouton.EndInit();

            Image imBouton = new Image();
            imBouton.Source = imageBouton;
            imBouton.Stretch = System.Windows.Media.Stretch.Fill;

            ((Button)sender).Content = imBouton;
        }
    }
}