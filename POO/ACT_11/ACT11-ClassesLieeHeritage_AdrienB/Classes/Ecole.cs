using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT11_ClassesLieeHeritage_AdrienB.Classes
{
    internal class Ecole
    {
        private string _codeEcole;
        private string _siteInternet;
        private List<Salle> _listeSalles;
        private List<Departement> _listeDepartements;

        public Ecole(string codeEcole, string siteInternet, List<Salle> salles, List<Departement> departements)
        {
            _codeEcole = codeEcole;
            _siteInternet = siteInternet;
            _listeSalles = salles;
            _listeDepartements = departements;
        }


        public string CodeEcole => _codeEcole;
        public string SiteInternet => _siteInternet;
        public List<Salle> ListeSalles => _listeSalles;
        public List<Departement> ListeDepartements => _listeDepartements;

        public void AjouterSalle(Salle salle)
        {
            _listeSalles.Add(salle);
        }

        public void AjouterDepartement(Departement departement)
        {
            _listeDepartements.Add(departement);
        }

        public string AfficherDepartements()
        {
            if (_listeDepartements.Count == 0)
                return "Aucun département.";

            return string.Join(", ", _listeDepartements.Select(d => d.Nom));
        }
    }

}
