using System.Net;
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

namespace act4_creationDynamique_AdrienB
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
            ColumnDefinition coldef1 = new ColumnDefinition();
            ColumnDefinition coldef2 = new ColumnDefinition();
            ColumnDefinition coldef3 = new ColumnDefinition();
            Index.ColumnDefinitions.Add(coldef1);
            Index.ColumnDefinitions.Add(coldef2);
            Index.ColumnDefinitions.Add(coldef3);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            Index.RowDefinitions.Add(rowDef1);
            Index.RowDefinitions.Add(rowDef2);
            Index.RowDefinitions.Add(rowDef3);


            TextBlock tktMonReuf = new TextBlock();
            tktMonReuf.Text = "TextBlock crée dynamiquement";
            tktMonReuf.FontSize = 22;
            tktMonReuf.Foreground = Brushes.Red;
            tktMonReuf.Background = Brushes.Yellow;
            Grid.SetColumnSpan(tktMonReuf, 3);
            Index.Children.Add(tktMonReuf);

            Button tktMonBut1 = new Button();
            tktMonBut1.Content = "But1";
            Thickness myThickness = new Thickness();
            myThickness.Bottom = 20;
            myThickness.Left = 20;
            myThickness.Right = 20;
            myThickness.Top = 20;
            tktMonBut1.Margin = myThickness;
            Grid.SetRow(tktMonBut1, 1);
            Index.Children.Add(tktMonBut1);

            Button tktMonBut2 = new Button();
            tktMonBut2.Content = "But2";
            Thickness my2Thickness = new Thickness();
            my2Thickness.Bottom = 20;
            my2Thickness.Left = 20;
            my2Thickness.Right = 20;
            my2Thickness.Top = 20;
            tktMonBut2.Margin = my2Thickness;
            Grid.SetRow(tktMonBut2, 1);
            Grid.SetColumn(tktMonBut2, 1);
            Index.Children.Add(tktMonBut2);

            Button tktMonBut3 = new Button();
            tktMonBut3.Content = "But3";
            Thickness my3Thickness = new Thickness();
            my3Thickness.Bottom = 20;
            my3Thickness.Left = 20;
            my3Thickness.Right = 20;
            my3Thickness.Top = 20;
            tktMonBut3.Margin = my3Thickness;
            Grid.SetRow(tktMonBut3, 1);
            Grid.SetColumn(tktMonBut3, 2);
            Index.Children.Add(tktMonBut3);

            StackPanel tktPanel = new StackPanel();
            Grid.SetRow(tktPanel, 2);
            Grid.SetColumnSpan(tktPanel, 2);
            Index.Children.Add(tktPanel);


            TextBlock tkt2MonReuf = new TextBlock();
            tkt2MonReuf.Text = "infos :";
            tkt2MonReuf.FontSize = 18;
            tkt2MonReuf.Background = Brushes.Yellow;
            tkt2MonReuf.Height = (this.Height / 3) / 2;
            tktPanel.Children.Add(tkt2MonReuf);


            TextBox tktMesDonnees = new TextBox();
            tktMesDonnees.Text = "Hola mi amigo como esta ?";
            tktMesDonnees.Height = (this.Height / 3) / 2;
            tktPanel.Children.Add(tktMesDonnees);

            ComboBox tktMonDrop = new ComboBox();
            Thickness my4Thickness = new Thickness();
            my4Thickness.Bottom = 20;
            my4Thickness.Left = 20;
            my4Thickness.Right = 20;
            my4Thickness.Top = 20;
            tktMonDrop.Margin = my4Thickness;
            tktMonDrop.Items.Add("Tkt");
            tktMonDrop.Items.Add("Mon");
            tktMonDrop.Items.Add("Stuff");
            Grid.SetRow(tktMonDrop, 2);
            Grid.SetColumn(tktMonDrop, 2);
            Index.Children.Add(tktMonDrop);
        }
    }
}