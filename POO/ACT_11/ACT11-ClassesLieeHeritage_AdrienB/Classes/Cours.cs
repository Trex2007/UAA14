using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT11_ClassesLieeHeritage_AdrienB.Classes
{
    internal class Cours
    {
        private string _nom;
        private Salle _salle;
        private List<double> _listeNotes;

        public Cours(string Nom, Salle Salle, List<double> ListeNotes)
        {
            _nom = Nom;
            _salle = Salle;
            _listeNotes = ListeNotes;
        }

        public string Nom
        {
            get { return _nom; }
        }
        public Salle Salle
        {
            get { return _salle; }
        }
        public List<double> ListeNotes
        {
            get { return _listeNotes; }
        }
    }
}
