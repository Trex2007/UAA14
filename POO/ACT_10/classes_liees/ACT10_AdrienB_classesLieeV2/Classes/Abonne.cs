using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT10_AdrienB_classesLieeV2.Classes
{
    internal class Abonne
    {
        string _nom;
        string _prenom;
        string _adresse;

        public Abonne(string Nom, string Prenom, string Adresse)
        {
            _nom = Nom;
            _prenom = Prenom;
            _adresse = Adresse;
        }

        public string Nom
        {
            get { return _nom; }
        }
        public string Prenom
        {
            get { return _prenom; }
        }
        public string Adresse
        {
            get { return _adresse; }
        }
    }
}
