namespace I2P624_BrahyAdrien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FeuDeSignalisation FeuCoin = new FeuDeSignalisation(0, "coinDeRue", false);
            FeuDeSignalisation FeuBat = new FeuDeSignalisation(0, "BatDeRue", false);
            Console.WriteLine("A = Infos | B = Changer Etat | C = Clignotant | D = ChangeCouleur");
            int nbAlternance = 5;
            while (true)
            {
                
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.A:
                        Console.Clear();
                        Console.WriteLine("A = Infos | B = Changer Etat | C = Clignotant | D = ChangeCouleur\n");

                        Console.WriteLine("Etats et Couleurs des feux :\n--------------------------");

                        Console.WriteLine("Le feu de Signalisation " + FeuCoin.Identifiant + " est " + FeuCoin.AfficheCouleur() + " et est " + FeuCoin.AfficheEtat());
                        Console.WriteLine("Le feu de Signalisation " + FeuBat.Identifiant + " est " + FeuBat.AfficheCouleur() + " et est " + FeuBat.AfficheEtat());
                        break;
                    case ConsoleKey.B:
                        Console.Clear();
                        Console.WriteLine("A = Infos | B = Changer Etat | C = Clignotant | D = ChangeCouleur\n");

                        Console.WriteLine("Faire passer " + FeuCoin.Identifiant+ " a l'orange\n--------------------------");
                        FeuCoin.Couleur = 1;
                        FeuCoin.Etat = true;
                        Console.WriteLine("Le feu de Signalisation " + FeuCoin.Identifiant + " est " + FeuCoin.AfficheCouleur() + " et est " + FeuCoin.AfficheEtat());
                        break;
                    case ConsoleKey.C:
                        Console.Clear();
                        Console.WriteLine("A = Infos | B = Changer Etat | C = Clignotant | D = ChangeCouleur\n");

                        Console.WriteLine("Feu Clignotant\n--------------------------");
                        FeuCoin.Clignote(nbAlternance);

                        break;
                    case ConsoleKey.D:
                        Console.Clear();
                        Console.WriteLine("A = Infos | B = Changer Etat | C = Clignotant | D = ChangeCouleur\n");
                        
                        Console.WriteLine("Changement d'état\n--------------------------");

                        Console.WriteLine("Le feu de signalisation" + FeuBat.Identifiant + " était au départ " + FeuBat.AfficheCouleur());
                        for (int i = 0; i < 4; i++)
                        {
                            FeuBat.ChangeEtat();
                            Console.WriteLine("Le feu de signalisation"+ FeuBat.Identifiant +" est maintenant " + FeuBat.AfficheCouleur());
                        }

                        break;

                }
            }
        }
    }
}
