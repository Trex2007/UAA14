using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT10_AdrienB_classesLiee.Classes
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

        public void Ajoute(Livre livre)
        {
            _livres.Add(livre);
        }

        public void SupprimerLivreAbimes()
        {
            for (int i = 0; i < _livres.Count(); i++)
            {
                Livre item = _livres[i];
                item.DescriptionDuLivre();
                if (item.Etat < 1)
                {
                    _livres.Remove(item);
                    Console.WriteLine("-"+item.Titre);
                    i--;
                }
            }
        }

        public void Inventaire()
        {
            foreach (var item in _livres)
            {
                item.DescriptionDuLivre();
            }
        }
    }
}
