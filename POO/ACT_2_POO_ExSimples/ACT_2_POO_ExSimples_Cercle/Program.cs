namespace ACT_2_POO_ExSimples_Cercle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            lireInt("Quelle rayon voulez-vous pour vôtre cercle ?", out int rayon);
            Cercle monCercle = new Cercle(rayon);
            
            while (true) {
                Console.WriteLine("\nA = Infos | B = Changer Rayon | C = Aire | D = Périmètre");
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.A:
                        Console.Clear();
                        Console.WriteLine("Rayon : " + monCercle.Rayon);
                        break;
                    case ConsoleKey.B:
                        Console.Clear();
                        lireInt("Quelle rayon voulez-vous pour vôtre cercle ?\nActuelle : " + monCercle.Rayon, out rayon);
                        monCercle.Rayon = rayon;
                        break;
                    case ConsoleKey.C:
                        Console.Clear();
                        Console.WriteLine("Aire : " + monCercle.CalculeAire());
                        break;
                    case ConsoleKey.D:
                        Console.Clear();
                        Console.WriteLine("Périmètre : " + monCercle.CalculePermimetre());
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
                Console.WriteLine("La réponse envoyer n'est pas valide, vueillez réaltérer la question.");
                Console.WriteLine(question);
                nUser = Console.ReadLine();
            }
        }
    }
}
