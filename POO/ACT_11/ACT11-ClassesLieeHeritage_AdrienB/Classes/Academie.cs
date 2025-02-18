using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT11_ClassesLieeHeritage_AdrienB.Classes
{
    internal class Academie
    {
        private string _nom;
        private List<Ecole> _listeEcoles;

        public Academie(string Nom, List<Ecole> ListeEcoles)
        {
            _nom = Nom;
            _listeEcoles = ListeEcoles;
        }

        public string Nom
        {
            get { return _nom; }
        }
        public List<Ecole> ListeEcoles
        {
            get { return _listeEcoles; }
        }
    }
}
