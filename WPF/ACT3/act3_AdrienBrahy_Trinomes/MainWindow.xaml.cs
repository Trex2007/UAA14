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

namespace act3_AdrienBrahy_Trinomes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            TextA.PreviewTextInput += new TextCompositionEventHandler(VerifTextInput);
            TextB.PreviewTextInput += new TextCompositionEventHandler(VerifTextInput);
            TextC.PreviewTextInput += new TextCompositionEventHandler(VerifTextInput);

            BtnHover.MouseEnter += new MouseEventHandler(SurvolBouton);
            Calcueler.Click += new RoutedEventHandler(Mouse_Down_Calc); 
        }
        private void Mouse_Down_Calc(object sender, RoutedEventArgs e)
        {
            MethodesDuProjet mesOutils = new MethodesDuProjet();
            PageResultat SecondePage = new PageResultat();



            double a = EstReady(TextA.Text);
            double b = EstReady(TextB.Text);
            double c = EstReady(TextC.Text);



            if (a != null && b != null && c != null)
            SecondePage.LblResultat.Text = mesOutils.ResoudreTrinome(a, b, c);
            SecondePage.Show();

        }
        public double EstReady(string x)
        {
            double.TryParse(x, out double y);

            return y;
        }
        public void SurvolBouton(object sender, MouseEventArgs e)
        {
            allGrid.Background = Brushes.Purple;
            BtnHover.Visibility = Visibility.Hidden;
        }
        public void VerifTextInput(object sender, TextCompositionEventArgs e)
        {
            if (e.Text != "," && !EstEntier(e.Text)){
                e.Handled = true;
            }else if (e.Text == "," && ((TextBox)sender).Text.IndexOf(e.Text) > -1)
            {
                e.Handled = true;
            }
        }

        private bool EstEntier(string texteUser)
        {
            bool vraiOuFaux = int.TryParse(texteUser, out int i);
            return vraiOuFaux;
        }

    }
}