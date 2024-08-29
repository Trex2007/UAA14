using System;
using System.Collections.Generic;
using System.Text;

namespace ACT00_REVISION
{ // écrire les signatures des procédures et fonctions...
    public struct MethodesDuProjet
    {
        public void Affiche(bool ok, string methode, out string infos)
        {
            string verbe;
            infos = "";
            
            if (ok)
            {
                verbe = " est ";
            }
            else
            {
                verbe = " n'est pas ";
            }
            // selon la méthode, on prépare la bonne phrase.
            switch (methode)
            {
                case "triangle":
                    infos = "le polygone " + verbe + "un triangle.";
                    break;
                case "equilateral":
                    infos = "le polygone " + verbe + "un triangle equilateral.";
                    break;
                case "isocele":
                    infos = "le polygone " + verbe + "un triangle isocele.";
                    break;
                case "rectangle":
                    infos = "le polygone " + verbe + "un triangle rectangle.";
                    break;
                default:
                    break;
            }
        }
        // fonction qui calcule la longueur de l'hypothénuse à partir de 2 cotés de type double
        public double Hypo(double x, double y)
        {
            double z = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return z;
        }
        // fonction qui permet de déterminer si oui ou non un triangle est rectangle en se basant sur ses 3 côtés
        public bool TriangleRectangle(double a, double b, double c)
        {
            bool ok = false;
            double hypothenuse = Hypo(b, c);
            if (a == hypothenuse)
            {
                ok = true;
            }
            return ok;
        }
        // procédure qui permet de classer les cotés : on choisi de mettre dans 'a' le plus grand des cotés
        // les 2 côtés sont modifiés par la procédure
        public void OrdonneCotes(ref double a, ref double b, ref double c)
        {
            double temp;

            if ((b >= a) && (b >= c))
            {
                temp = a;
                a = b;
                b = temp;
            }
            else if ((c >= a) && (c >= b))
            {
                temp = a;
                a = c;
                c = temp;
            }
        }
        // fonction booléenne qui détermine si on a un triangle ou pas en se basant sur les longueurs des côtés
        public bool Triangle(double a, double b, double c)
        {
            bool ok = false;

            OrdonneCotes(ref a, ref b, ref c);

            if (a <= (b + c))
            {
                ok = true;
            }
            return ok;
        }
        // procédure qui détermine si un triangle est isocèle ou non sur base des longueurs de côtés
        public bool Isocele(double a, double b, double c)
        {
            bool ok = false;
            if ((a == b) ^ (a == c) ^ (b == c))   // '^' est le 'ou' exclusif (xor)
            {
                ok = true;
            }
            return ok;
        }
        // fonction booléenne qui détermine si un triangle est équilatéral sur base de ses côtés
        public bool Equi(double a, double b, double c)
        {
            bool ok = false;
            if ((a == b) && (a == c))
            {
                ok = true;
            }
            return ok;
        }
    }
}
