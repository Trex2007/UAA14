using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdrienB_6TI_Revisions2
{
    public struct MethodesDuProjet
    {
        public void lireDouble(string question, out double nombreCouleur)
        {
            string nUser;
            nombreCouleur = 4;
            while (nombreCouleur > 3 || nombreCouleur < 1)
            {
                Console.WriteLine(question);
                nUser = Console.ReadLine();
                while (!double.TryParse(nUser, out nombreCouleur))
                {
                    Console.WriteLine("Veuillez entrer un nombre valide");
                    Console.WriteLine(question);
                    nUser = Console.ReadLine();
                } 
                if (nombreCouleur > 3 || nombreCouleur < 0)
                {
                    Console.WriteLine("Veuillez choisir un nombre entre 1 et 3");
                }
            }           
        }
        public void couleur(double nombreCouleur)
        {
            if (nombreCouleur == 1) {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Rouge");
            } else if (nombreCouleur == 2)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("Bleu");
            } else if (nombreCouleur == 3)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Vert");
            }

        }
    }
}
