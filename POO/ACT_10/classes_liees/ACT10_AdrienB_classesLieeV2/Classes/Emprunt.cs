using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT10_AdrienB_classesLieeV2.Classes
{
    internal class Emprunt
    {
        DateOnly _dateEmpr;
        Abonne _emprunteur;
        Livre _livre;

        public Emprunt(DateOnly DateEmpr, Abonne Emprunteur, Livre Livre)
        {
            _dateEmpr = DateEmpr;
            _emprunteur = Emprunteur;
            _livre = Livre;
        }

        public DateOnly DateEmpr
        {
            get { return _dateEmpr; }
        }
        public Abonne Emprunteur
        {
            get { return _emprunteur; }
        }
        public Livre Livre
        {
            get { return _livre; }
        }
    }
}
