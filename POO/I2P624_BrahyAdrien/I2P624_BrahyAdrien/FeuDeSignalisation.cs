using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I2P624_BrahyAdrien
{
    internal class FeuDeSignalisation
    {
        int _couleur;
        string _identifiant;
        bool _etat;

        public FeuDeSignalisation(int Couleur, string Identifiant, bool Etat)
        {
            _couleur = Couleur;
            _identifiant = Identifiant;
            _etat = Etat;
        }
        public int Couleur
        {
            get { return _couleur; }
            set { _couleur = value; }
        }
        public string Identifiant
        {
            get { return _identifiant; }
            set { _identifiant = value; }
        }
        public bool Etat
        {
            get { return _etat; }
            set { _etat = value; }
        }
        /// <summary>
        /// afficher sa couleur en texte au lieu de int
        /// </summary>
        /// <returns></returns>
        public string AfficheCouleur()
        {
            string laCouleur;

            if (_couleur == 0)
            {
                laCouleur = "Vert";
            } else if (_couleur == 1)
            {
                laCouleur = "Orange";
            } else
            {
                laCouleur = "Rouge";
            }

            return laCouleur;
        }
        /// <summary>
        /// afficher son etat en texte au lieu de bool
        /// </summary>
        /// <returns></returns>
        public string AfficheEtat()
        {
            string leEtat = "Introuvable";

            if(_etat == true)
            {
                leEtat = "Allumé";
            } else
            {
                leEtat = "Eteint";
            }

            return leEtat;
        }
        /// <summary>
        /// Passer a la couleur suivante
        /// </summary>
        /// <returns></returns>
        public int ChangeCouleur()
        {
            int couleur = _couleur;
            if (couleur > 1)
            { 
                couleur = 0; 
            } 
            else 
            { 
                couleur += 1; 
            }
            return couleur;
        }
        /// <summary>
        /// allumer eteindre la lampe
        /// </summary>
        /// <param name="nbAlternance">nombre de fois qu'il le change</param>
        public void Clignote(int nbAlternance)
        {
            Console.WriteLine("Le feu de signalisations " + Identifiant + " était au départ " + AfficheEtat());
            for (int i = 0; i < nbAlternance; i++)
            {
                _etat = !_etat;
                Console.WriteLine("Le feu de signalisations "+Identifiant+ " est maintenant " + AfficheEtat());
            }
        }
        public void ChangeEtat()
        {
            _couleur = ChangeCouleur();
        }
    }
}
