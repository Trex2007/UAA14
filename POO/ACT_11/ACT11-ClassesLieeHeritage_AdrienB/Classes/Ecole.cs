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

        public Ecole(string CodeEcole, string SiteInternet, List<Salle> ListeSalles, List<Departement> ListeDepartements)
        {
            _codeEcole = CodeEcole;
            _siteInternet = SiteInternet;
            _listeSalles = ListeSalles;
            _listeDepartements = ListeDepartements;
        }

        public string CodeEcole
        {
            get { return _codeEcole; }
        }
        public string SiteInternet
        {
            get { return _siteInternet; } 
        }
        public List<Salle> ListeSalles
        {
            get { return _listeSalles; }
        }
        public List<Departement> ListeDepartements
        {
            get { return _listeDepartements; }
        }
    }
}
