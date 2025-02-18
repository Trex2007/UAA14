using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT11_ClassesLieeHeritage_AdrienB.Classes
{
    internal class Salle
    {
        private string _nom;
        private int _nombrePlaces;

        public Salle(string Nom, int NombrePlaces)
        {
            _nom = Nom;
            _nombrePlaces = NombrePlaces;
        }

        public string Nom
        {
            get { return _nom; }
        }
        public int NombrePlaces
        {
            get { return _nombrePlaces; }
        }
    }
}
