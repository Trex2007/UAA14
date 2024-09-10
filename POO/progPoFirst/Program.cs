namespace progPoFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat premierGogole = new Cat(2, "Reaver", 5.2, 50, "Mencoon", true, false);
            Cat[] clubCat = new Cat[100];
            while (true)
            {
                Console.WriteLine("\nQue voulez-vous faire ?\n[A]=Infos | [Z]=Manger | [E]=Boire\n[Q]=Viellir | [S]=Blessé | [D]=Mourir\n\n[W]=Crée " + clubCat.Length + " Chats | [X]=Afficher Un Chats");

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.A:
                        Console.Clear();
                        Console.WriteLine(premierGogole.InfosCat());
                        break;
                    case ConsoleKey.Z:
                        Console.Clear();
                        Console.WriteLine(premierGogole.Manger());
                        break;
                    case ConsoleKey.E:
                        Console.Clear();
                        Console.WriteLine(premierGogole.Boire());
                        break;
                    case ConsoleKey.Q:
                        Console.Clear();
                        Console.WriteLine(premierGogole.Viellir());
                        break;
                    case ConsoleKey.S:
                        Console.Clear();
                        Console.WriteLine(premierGogole.SeBlesse());
                        break;
                    case ConsoleKey.D:
                        Console.Clear();
                        Console.WriteLine(premierGogole.Mort());
                        break;
                    case ConsoleKey.W:
                        Console.Clear();
                            for (int i = 0; i < clubCat.Length; i++)
                            {
                                clubCat[i] = new Cat(3, "Nom-"+i, 3, Math.Round(i *10.5)+1, "Race-"+i, true, false);
                            }
                        if (clubCat[0] != null)
                        {
                            Console.WriteLine("Crée avec succès !");
                        }
                        else
                        {
                            Console.WriteLine("Il y a eu un problème lors de la création.");
                        }
                        break;
                    case ConsoleKey.X:
                        Console.Clear();
                        if(clubCat[0] != null)
                        {
                            int choix = -1;
                            while (choix < 0 || choix > clubCat.Length-1)
                            {
                                lireInt("Quelle chat voulez-vous voir ?", out choix);
                                if(choix < 0 || choix > clubCat.Length - 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Nombre de mauvaise taille !");
                                }
                            }
                            Console.Clear();
                            Console.WriteLine(clubCat[choix].InfosCat());
                        }
                        else
                        {
                            Console.WriteLine("Aucun chats n'existent");
                        }
                        
                        break;

                }


            }
        }
        static void lireInt(string question, out int n)
        {
            string nUser;
            Console.WriteLine(question);
            nUser = Console.ReadLine();
            while (!int.TryParse(nUser, out n))
            {
                Console.Clear();
                Console.WriteLine("Vueillez entrer un nombre valide !");
                Console.WriteLine(question);
                nUser = Console.ReadLine();
            }
        }
    }
}
