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

        public Personne (string Nom, string Prenom, string Email, string Telephone)
        {
            _nom = Nom;
            _prenom = Prenom;
            _email = Email;
            _telephone = Telephone;
        }
        public string Nom { get { return _nom; } }
        public string Prenom { get { return _prenom; } }
        public string Email { get { return _email; } }
        public string Telephone { get { return _telephone; } }

        public abstract string Infos();
    }
}
