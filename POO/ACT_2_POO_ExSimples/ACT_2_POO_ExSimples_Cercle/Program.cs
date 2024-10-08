using System.Numerics;

namespace ACT_2_POO_ExSimples_Cercle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool dedans = false;
            while (true) { 
                Console.WriteLine("A = Cercle | Z = Nbr Complexes | E = Sandwitch | R = Virements");
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.A:
                        Console.Clear();
                        lireDouble("Quelle rayon voulez-vous pour vôtre cercle ?", out double rayon);
                        Cercle monCercle = new Cercle(rayon);
                        dedans = true;
                        while (dedans)
                        {
                            Console.WriteLine("\nA = Infos | Z = Changer Rayon | E = Aire | R = Périmètre | T = Quitter");
                            switch (Console.ReadKey(true).Key)
                            {
                                case ConsoleKey.A:
                                    Console.Clear();
                                    Console.WriteLine("Rayon : " + monCercle.Rayon);
                                    break;
                                case ConsoleKey.Z:
                                    Console.Clear();
                                    lireDouble("Quelle rayon voulez-vous pour vôtre cercle ?\nActuelle : " + monCercle.Rayon, out rayon);
                                    monCercle.Rayon = rayon;
                                    break;
                                case ConsoleKey.E:
                                    Console.Clear();
                                    Console.WriteLine("Aire : " + monCercle.CalculeAire());
                                    break;
                                case ConsoleKey.R:
                                    Console.Clear();
                                    Console.WriteLine("Périmètre : " + monCercle.CalculePermimetre());
                                    break;
                                case ConsoleKey.T:
                                    Console.Clear();
                                    dedans = false;
                                    break;
                            }
                        }
                        break;
                    case ConsoleKey.Z:
                        Console.Clear();
                        lireDouble("Quelle sera vôtre nombre réel ?", out double reel);
                        Console.Clear();
                        lireDouble("Quelle sera vôtre nombre imaginaire ?", out double imaginaire);
                        Complexe monComplexe = new Complexe(reel, imaginaire);
                        dedans = true;
                        while (dedans)
                        {
                            Console.WriteLine("\nA = Infos | Z = Calculer | E = Ajouter | R = Quitter");
                            switch (Console.ReadKey(true).Key)
                            {
                                case ConsoleKey.A:
                                    Console.Clear();
                                    Console.WriteLine(monComplexe.AfficheComplexe());
                                    break;
                                case ConsoleKey.Z:
                                    Console.Clear();
                                    Console.WriteLine(monComplexe.CalculeModule());
                                    break;
                                case ConsoleKey.E:
                                    Console.Clear();
                                    lireDouble("Quelle sera vôtre nombre réel ?", out reel);
                                    Console.Clear();
                                    lireDouble("Quelle sera vôtre nombre imaginaire ?", out imaginaire);
                                    Complexe secondComplexe = new Complexe(reel, imaginaire);
                                    monComplexe.AjouteComplexe(secondComplexe);
                                    Console.WriteLine(monComplexe.AfficheComplexe());
                                    break;
                                case ConsoleKey.R:
                                    Console.Clear();
                                    dedans = false;
                                    break;
                            }
                        }
                        break;
                    case ConsoleKey.E:
                        Console.Clear();
                        Sandwitch monSandwitch = new Sandwitch();
                        dedans = true;
                        while (dedans)
                        {
                            Console.WriteLine("\nA = Crée | Z = Quitter");
                            switch (Console.ReadKey(true).Key)
                            {
                                case ConsoleKey.A:
                                    Console.Clear();
                                    Console.Write(monSandwitch.SandwitchMaker());
                                    break;
                                case ConsoleKey.Z:
                                    Console.Clear();
                                    dedans = false;
                                    break;
                            }
                        }
                        break;
                    case ConsoleKey.R:
                        Console.Clear();
                        Personne personne1 = new Personne("Roberto", 100);
                        Personne personne2 = new Personne("Alberto", 100);
                        dedans = true;
                        while (dedans)
                        {
                            Console.WriteLine("\nA = Infos | Z = Donner | E = Donner | R = Donner | T = Quitter");
                            switch (Console.ReadKey(true).Key)
                            {
                                case ConsoleKey.A:
                                    Console.Clear();

                                    break;
                                case ConsoleKey.Z:
                                    Console.Clear();

                                    break;
                                case ConsoleKey.E:
                                    Console.Clear();

                                    break;
                                case ConsoleKey.R:
                                    Console.Clear();

                                    break;
                                case ConsoleKey.T:
                                    Console.Clear();
                                    dedans = false;
                                    break;
                            }
                        }
                        break;
                }
            }            
        }
        static void lireDouble(string question, out double n)
        {
            string nUser;
            Console.WriteLine(question);
            nUser = Console.ReadLine();
            while (!double.TryParse(nUser, out n))
            {
                Console.WriteLine("La réponse envoyer n'est pas valide, veuillez réaltérer la question.");
                Console.WriteLine(question);
                nUser = Console.ReadLine();
            }
        }
    }
}
