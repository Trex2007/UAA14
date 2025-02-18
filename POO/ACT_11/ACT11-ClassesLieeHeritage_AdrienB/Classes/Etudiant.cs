using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT11_ClassesLieeHeritage_AdrienB.Classes
{
    internal class Etudiant : Personne
    {
        private int _anneeEntree;
        private List<InfoCours> _listCours;

        public Etudiant(string Nom, string Prenom, string Email, string Telephone, int AnneeEntree, List<InfoCours> ListCours) : base(Nom, Prenom, Email, Telephone)
        {
            _anneeEntree = AnneeEntree;
            _listCours = ListCours;
            _nom = Nom;
            _prenom = Prenom;
            _email = Email;
            _telephone = Telephone;
        }

        public int AnneeEntree
        {
            get { return _anneeEntree; }
        }
        public List<InfoCours> ListCours
        {
            get { return _listCours; }
        }

        public override string Infos() { return "test"; }

    }
}
