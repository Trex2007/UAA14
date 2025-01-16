using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT10_AdrienB_classesLieeV2.Classes
{
    internal class Bibliotheque
    {
        List<Livre> _livres;

        public Bibliotheque()
        {
            _livres = new List<Livre>();
        }

        public List<Livre> Livres
        {
            get { return _livres; }
        }

        public void AjouteLivre(Livre livre)
        {
            _livres.Add(livre);
        }
    }
}
