using System;

namespace ACT00_REVISION
{
    class Program
    {
        static void Main(string[] args)
        {

            MethodesDuProjet outilPro = new MethodesDuProjet(); // instanciation d ela structure

            // déclaration des variables.... COMPLETER AVEC CE QUI MANQUE
            string rep;
            string reapeatProg;
            double c1 = 0;
            double c2 = 0;
            double c3 = 0;
            bool ok = false;

            Console.WriteLine("Testez les polygones !");
            do
            {
                c1 = lireDouble(1);
                c2 = lireDouble(2);
                c3 = lireDouble(3);

                outilPro.OrdonneCotes(ref c1, ref c2, ref c3);

                if (outilPro.Triangle(c1, c2, c3))
                {
                    ok = true;
                    outilPro.Affiche(ok, "triangle", out rep);
                    Console.WriteLine(rep);

                    if (outilPro.Equi(c1, c2, c3))
                    {
                        ok = true;
                        outilPro.Affiche(ok, "equilateral", out rep);
                        Console.WriteLine(rep);
                    }
                    else
                    {
                        ok = outilPro.TriangleRectangle(c1, c2, c3);
                        outilPro.Affiche(ok, "rectangle", out rep);
                        Console.WriteLine(rep);

                        ok = outilPro.Isocele(c1, c2, c3);
                        outilPro.Affiche(ok, "isocele", out rep);
                        Console.WriteLine(rep);
                    }
                }
                else
                {
                    ok = false;
                    outilPro.Affiche(ok, "triangle", out rep);
                    Console.WriteLine(rep);
                }

                Console.WriteLine("voulez-vous recommencez 'O' = oui");
                reapeatProg = Console.ReadLine();
                if (reapeatProg == "O")
                {
                    Console.WriteLine("- - - - - - - -");
                }
            } while (reapeatProg == "O");
        }
        static double lireDouble(int numeroCote)
        {
            double cote = 0;
            while (cote < 1)
            {
                Console.Write("Tapez la valeur du côté " + numeroCote + " : ");
                cote = double.Parse(Console.ReadLine());
                if (cote < 1) {
                    Console.WriteLine("Merci d'entrer un nombre supérieur a 0");
                }
            }
            
            return cote;
        }
    }
}
