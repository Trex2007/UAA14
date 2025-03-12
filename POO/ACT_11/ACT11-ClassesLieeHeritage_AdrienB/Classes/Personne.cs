using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT11_ClassesLieeHeritage_AdrienB.Classes
{
    internal abstract class Personne
    {
        protected string _nom;
        protected string _prenom;
        protected string _email;
        protected string _telephone;

        public Personne(string Nom, string Prenom, string Email, string Telephone)
        {
            _nom = Nom;
            _prenom = Prenom;
            _email = Email;
            _telephone = Telephone;
        }

        public string Nom => _nom;
        public string Prenom => _prenom;
        public string Email => _email;
        public string Telephone => _telephone;

        public abstract string Infos();
    }

}
