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
        private List<Enseignant> _listeEnseignants;

        public Departement(string nom, string matiere, List<Enseignant> listeEnseignants)
        {
            _nom = nom;
            _matiere = matiere;
            _listeEnseignants = listeEnseignants;
        }

        public string Nom => _nom;
        public string Matiere => _matiere;
        public List<Enseignant> ListeEnseignants => _listeEnseignants;

        public void AjouterEnseignant(Enseignant enseignant)
        {
            _listeEnseignants.Add(enseignant);
        }

        public string AfficherEnseignants()
        {
            if (_listeEnseignants.Count == 0)
                return "Aucun enseignant.";

            return string.Join(", ", _listeEnseignants.Select(e => e.Nom + " " + e.Prenom));
        }
    }

}
