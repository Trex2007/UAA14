using Microsoft.Win32.SafeHandles;
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

namespace ACT_3BIS_AdrienB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dateArrivee.CalendarClosed += new RoutedEventHandler(DateVerify);
            dateSortie.CalendarClosed += new RoutedEventHandler(DateVerify);
            nbrePersonnes.PreviewTextInput += new TextCompositionEventHandler(VerifPersonnes);


        }
        private void DateVerify(object sender, RoutedEventArgs e)
        {
            CalendarDateRange beforeToday = new CalendarDateRange(new DateTime(0001, 01, 01), DateTime.Now.AddDays(-1));
            CalendarDateRange afterOneYear = new CalendarDateRange(DateTime.Now.AddYears(1).AddDays(1), DateTime.MaxValue);
            dateSortie.BlackoutDates.Clear();
            dateSortie.BlackoutDates.Add(beforeToday);
            dateSortie.BlackoutDates.Add(afterOneYear);
        }
        private void VerifPersonnes(object sender, TextCompositionEventArgs e)
        {
            if (!int.TryParse(e.Text, out int i))
            {
                e.Handled = true;
            } else if (i > 6 || i < 1)
            {
                e.Handled = true;
            }
            else if ((((TextBox)sender).Text).Length == 1)
            {
                e.Handled = true;
            }
        }

        private int CalcPrix()
        {
            string batiment = "Chalet";
            int nbrPersonnes = 4;
            int prix = 0;
            string mois = "paque";


            if (batiment == "Chalet")
            {
                if (nbrPersonnes <= 4)
                {
                    prix = 547;
                } else if (nbrPersonnes == 5)
                {
                    prix = 580;
                } else
                {
                    prix = 597;
                }

                if (mois == "paque")
                {
                    prix -= 250;
                }

            } else
            {
                if (nbrPersonnes <= 4)
                {

                }
                else if (nbrPersonnes == 5)
                {

                }
                else
                {

                }
            }
            return prix;
        }
    }
}