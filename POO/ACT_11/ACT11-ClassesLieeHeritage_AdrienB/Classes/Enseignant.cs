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
        private List<InfoCours> _listCours; // Doit contenir les cours et non InfoCours

        public Enseignant(string nom, string prenom, string email, string telephone, DateTime dateEmbauche, string matiere, List<InfoCours> ListeCours)
    : base(nom, prenom, email, telephone)
        {
            _datePriseFonction = dateEmbauche;
            _matiere = matiere;
            _listCours = ListeCours;
        }


        public DateTime DatePriseFonction => _datePriseFonction;
        public string Matiere => _matiere;
        public List<InfoCours> ListCours => _listCours;

        public void AjouterCours(InfoCours cours)
        {
            _listCours.Add(cours);
        }

        public override string Infos()
        {
            return $"Enseignant : {Nom} {Prenom}, Email : {Email}, Téléphone : {Telephone}, Matière : {Matiere}, Date de prise de fonction : {DatePriseFonction.ToShortDateString()}";
        }
    }
}
