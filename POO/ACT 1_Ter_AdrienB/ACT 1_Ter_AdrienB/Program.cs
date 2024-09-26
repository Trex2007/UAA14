namespace ACT_1_Ter_AdrienB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint lastLampe = 0;
            Lampe[] toutesLampes = new Lampe[10];

            Interupteur Interupteur1 = new Interupteur(0, toutesLampes[0]);

            while (true)
            {
                Console.WriteLine("Lampes:");
                for (int i = 0; i < lastLampe; i++)
                {
                    Console.WriteLine(i + " " + toutesLampes[i].Statut + ", " + toutesLampes[i].Color + ", " + toutesLampes[i].Intensite);
                }

                Console.WriteLine("\nQue voulez-vous faire ?\n[A] Nouvelle Lampe | [B] Allumer/Eteindre");

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.A:
                        Console.Clear();

                        toutesLampes[lastLampe] = new Lampe(false, "white", 5);
                        lastLampe++;

                        break;
                    case ConsoleKey.B:
                        Console.Clear();

                        Interupteur1.ChangerStatut();

                        break;
                }
            }
        }
    }
}
