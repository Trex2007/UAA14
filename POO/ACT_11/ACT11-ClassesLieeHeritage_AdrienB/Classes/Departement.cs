using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT11_ClassesLieeHeritage_AdrienB.Classes
{
    internal class Departement
    {
        private string _nom;
        private string _matiere;
        private List<Enseignant> _listeEnseignant;

        public Departement(string Nom, string Matiere, List<Enseignant> ListeEnseignant)
        {
            _nom = Nom;
            _matiere = Matiere;
            _listeEnseignant = ListeEnseignant;
        }

        public string Nom
        {
            get { return _nom; }
        }
        public string Matiere
        {
            get { return _matiere; }
        }
        public List<Enseignant> ListeEnseignant
        {
            get { return _listeEnseignant; }
        }
    }
}
