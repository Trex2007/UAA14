using I5_6TTIUAA14_AdrienB.Class;
using System.Linq.Expressions;
using System.Reflection;

namespace I5_6TTIUAA14_AdrienB
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ;
            bool rejouer = true;
            string question = "[Espace] = Tirer | [R] = Recharger | [V] = Voir Balles | [+] = Prendre Muns | [Q] = Quitter";

            PaintBallGun arme1 = new PaintBallGun(0, 16);

            Joueur joueur1 = new Joueur("joueur1", 30, arme1);

            Console.WriteLine("Bienvenue dans ce jeu de tir ... Vous démarrez avec 30 balles");
            Console.WriteLine("=============================================================");
            Console.WriteLine("\n"+question);
            while (rejouer) {
                if (arme1.ChargeurEstVide())
                {
                    Console.WriteLine("\nAttention votre chargeur est vide");
                }
                
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.Spacebar:
                        Console.Clear();
                        Console.WriteLine(question);

                        if (joueur1.Tire())
                        {
                            joueur1.MyPaintBallGun.NbBallesChargeur -= 1;
                            Console.WriteLine("\nPAW, balle tirée"); 
                        } else
                        {
                            Console.WriteLine("\nPas asser de balles");
                        }

                        if(joueur1.MyPaintBallGun.NbBallesChargeur == 1)
                        {
                            Console.WriteLine("\nAttention ! Il ne reste que une balle dans le chargeur");
                        }


                        break;



                    case ConsoleKey.R:
                        Console.Clear();
                        Console.WriteLine(question);

                        Console.WriteLine(joueur1.Recharger());

                        break;



                    case ConsoleKey.V:
                        Console.Clear();
                        Console.WriteLine(question);

                        Console.WriteLine(joueur1.VerifPoche());

                        break;



                    case ConsoleKey.Add:
                        Console.Clear();
                        Console.WriteLine(question);

                        if(joueur1.NbCartouchesEnPoche <= 226)
                        {
                            joueur1.NbCartouchesEnPoche += 30;
                            Console.WriteLine("Vous avez pris 30 balles");
                        }
                        else
                        {
                            Console.WriteLine("Vous avez trop de balles");
                        }
                        
                        Console.WriteLine(joueur1.VerifPoche());

                        break;



                    case ConsoleKey.Q:

                        rejouer = false;

                        break;
                }
            }
        }
    }
}
