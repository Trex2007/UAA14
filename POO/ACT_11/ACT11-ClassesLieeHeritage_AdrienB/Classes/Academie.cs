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

        public Academie(string nom, List<Ecole> ecoles)
        {
            _nom = nom;
            _listeEcoles = ecoles;
        }

        public string Nom => _nom;
        public List<Ecole> ListeEcoles => _listeEcoles;

        public void AjouterEcole(Ecole ecole)
        {
            _listeEcoles.Add(ecole);
        }

        public string AfficherEcoles()
        {
            if (_listeEcoles.Count == 0)
                return "Aucune école.";

            return string.Join(", ", _listeEcoles.Select(e => e.CodeEcole));
        }
    }

}
