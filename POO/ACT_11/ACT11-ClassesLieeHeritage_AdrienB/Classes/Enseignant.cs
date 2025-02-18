using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT11_ClassesLieeHeritage_AdrienB.Classes
{
    internal class Enseignant : Personne
    {
        private DateTime _datePriseFonction;
        private string _matiere;
        private List<InfoCours> _listCours;

        public Enseignant(string Nom, string Prenom, string Email, string Telephone, DateTime DatePriseFonction, string Matiere, List<InfoCours> ListCours) : base(Nom, Prenom, Email, Telephone)
        {
            _datePriseFonction = DatePriseFonction;
            _matiere = Matiere;
            _listCours = ListCours;
            _nom = Nom;
            _prenom = Prenom;
            _email = Email;
            _telephone = Telephone;
        }

        public DateTime DatePriseFonction
        {
            get { return _datePriseFonction; }
        }
        public string Matiere
        {
            get { return _matiere; }
        }
        public List<InfoCours> ListCours
        {
            get { return _listCours; }
        }

        public override string Infos() { return "test"; }
    }
}
