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
            _listCours = new List<InfoCours>(); // Initialise une liste vide
        }

        public int AnneeEntree => _anneeEntree;
        public List<InfoCours> ListCours => _listCours;

        public void AjouterInfoCours(Cours cours, double note)
        {
            _listCours.Add(new InfoCours(cours, note));
        }

        public double CalculerMoyenneGenerale()
        {
            if (_listCours.Count == 0)
                return 0; // Évite la division par zéro

            return _listCours.Average(info => info.note);
        }

        public string AfficherMatieresNotees()
        {
            if (_listCours.Count == 0)
                return "Aucune matière notée.";

            return string.Join(", ", _listCours.Select(info => info.cours.Nom));
        }

        public override string Infos()
        {
            return $"Étudiant : {Nom} {Prenom}, Email : {Email}, Téléphone : {Telephone}, Année d'entrée : {AnneeEntree}";
        }
    }

}
