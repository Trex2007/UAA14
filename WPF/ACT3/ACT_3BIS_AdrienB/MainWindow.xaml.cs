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
    public partial class MainWindow : Window
    {
        private bool traitementEffectue = false; // Variable pour savoir si le traitement a déjà été fait

        public MainWindow()
        {
            InitializeComponent();

            // Vérifier le nombre de personnes saisies
            nbrePersonnes.PreviewTextInput += new TextCompositionEventHandler(VerifPersonnes);

            // Calcul de la durée du séjour en semaines
            btnCalculerDuree.Click += new RoutedEventHandler(CalcDureeSejour);

            // Calcul du prix total
            btnCalculer.Click += new RoutedEventHandler(CalcPrixTotal);

            // Réinitialiser les champs
            btnInit.Click += new RoutedEventHandler(ResetFields);

            // Bloquer les dates non valides
            BlockInvalidDates();
        }

        // Vérification du nombre de personnes saisies (1 à 6)
        private void VerifPersonnes(object sender, TextCompositionEventArgs e)
        {
            if (!int.TryParse(e.Text, out int i) || i < 1 || i > 6 || (((TextBox)sender).Text).Length >= 1)
            {
                e.Handled = true;
            }
        }

        // Méthode pour bloquer les dates non valides dans les DatePickers
        private void BlockInvalidDates()
        {
            DateTime start = DateTime.Now.AddDays(1);  // Bloquer aujourd'hui
            DateTime end = DateTime.Now.AddYears(1);   // Permettre la sélection jusqu'à un an à l'avance

            for (DateTime date = start; date <= end; date = date.AddDays(1))
            {
                int mois = date.Month;
                // Autoriser uniquement les mois de décembre-janvier, avril, juillet-août
                if (!(mois == 12 || mois == 1 || mois == 4 || mois == 7 || mois == 8))
                {
                    dateArrivee.BlackoutDates.Add(new CalendarDateRange(date));
                    dateSortie.BlackoutDates.Add(new CalendarDateRange(date));
                }
            }

            // Bloquer toutes les dates avant demain
            dateArrivee.BlackoutDates.Add(new CalendarDateRange(new DateTime(0001, 01, 01), DateTime.Now));
            dateSortie.BlackoutDates.Add(new CalendarDateRange(new DateTime(0001, 01, 01), DateTime.Now));
        }

        // Calcul de la durée du séjour en semaines
        private void CalcDureeSejour(object sender, RoutedEventArgs e)
        {
            if (dateArrivee.SelectedDate.HasValue && dateSortie.SelectedDate.HasValue)
            {
                TimeSpan duree = dateSortie.SelectedDate.Value - dateArrivee.SelectedDate.Value;
                double nbSemaines = duree.TotalDays / 7;
                nbSemaines = Math.Ceiling(nbSemaines);  // Arrondir au nombre entier supérieur
                this.nbSemaines.Text = $"Nombre de semaines : {nbSemaines}";
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner des dates valides.");
            }
        }

        // Calcul du prix avec garde-fou et affichage de "TRAITEMENT RÉALISÉ" après un clic
        private void CalcPrixTotal(object sender, RoutedEventArgs e)
        {
            if (!traitementEffectue)
            {
                // Si le traitement n'a pas encore été fait, calculer le prix
                if (dateArrivee.SelectedDate.HasValue && dateSortie.SelectedDate.HasValue && int.TryParse(nbrePersonnes.Text, out int nbPersonnes) && nbPersonnes >= 1 && nbPersonnes <= 6)
                {
                    int prixFinal = CalcPrix();
                    prixAPayer.Text = $"Prix à payer : {prixFinal}€";
                    traitementEffectue = true;  // Marquer que le traitement a été fait
                }
                else
                {
                    MessageBox.Show("Veuillez vérifier les données saisies (dates et nombre de personnes).");
                }
            }
            else
            {
                // Si le traitement a déjà été effectué, afficher seulement "TRAITEMENT RÉALISÉ"
                prixAPayer.Text = "TRAITEMENT RÉALISÉ";
            }
        }

        // Réinitialisation des champs
        private void ResetFields(object sender, RoutedEventArgs e)
        {
            nbrePersonnes.Clear();
            dateArrivee.SelectedDate = null;
            dateSortie.SelectedDate = null;
            prixAPayer.Text = "Prix à Payer :";
            nbSemaines.Text = "Nombre de semaines :";
            Reservation.IsChecked = false;
            traitementEffectue = false;  // Réinitialiser l'état du traitement
        }

        // Calcul du prix total en fonction des conditions
        private int CalcPrix()
        {
            int nbPersonnes = int.Parse(nbrePersonnes.Text);
            bool isChalet = chxChalet.IsChecked ?? false;
            bool isTente = chxTente.IsChecked ?? false;
            int dureeSejour = (int)Math.Ceiling((dateSortie.SelectedDate.Value - dateArrivee.SelectedDate.Value).TotalDays / 7);
            bool reservation = Reservation.IsChecked ?? false;

            int prixBase = 0;
            string saison = "Grandes vacances"; // Supposons cette saison, il faudrait un contrôle pour la définir

            // Déterminer le prix en fonction du type de logement et du nombre de personnes
            if (isChalet)
            {
                if (nbPersonnes <= 4) prixBase = (saison == "Grandes vacances") ? 547 : 297;
                else if (nbPersonnes == 5) prixBase = (saison == "Grandes vacances") ? 580 : 330;
                else prixBase = (saison == "Grandes vacances") ? 597 : 347;
            }
            else if (isTente)
            {
                if (nbPersonnes <= 4) prixBase = (saison == "Grandes vacances") ? 348 : 198;
                else if (nbPersonnes == 5) prixBase = (saison == "Grandes vacances") ? 370 : 220;
                else prixBase = (saison == "Grandes vacances") ? 400 : 250;
            }

            // Appliquer les remises en fonction de la durée du séjour
            if (dureeSejour >= 3 && dureeSejour <= 4)
            {
                prixBase = (int)(prixBase * 0.95);  // 5% de réduction
            }
            else if (dureeSejour >= 5)
            {
                prixBase = (int)(prixBase * 0.90);  // 10% de réduction
            }

            // Ajouter les frais de réservation s'il y en a
            if (reservation)
            {
                prixBase += 12;
            }

            // Calcul de la taxe de séjour : 0.30€ par personne et par jour
            double taxeSejour = 0.30 * nbPersonnes * (dureeSejour * 7);
            prixBase += (int)taxeSejour;

            return prixBase;
        }
    }
}