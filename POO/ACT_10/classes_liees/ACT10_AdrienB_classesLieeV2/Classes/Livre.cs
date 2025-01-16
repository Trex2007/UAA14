using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT10_AdrienB_classesLieeV2.Classes
{
    internal class Livre
    {
        string _titre;
        string _auteur;
        ushort _etat;

        public Livre(string Titre, string Auteur, ushort Etat)
        {
            _titre = Titre;
            _auteur = Auteur;
            _etat = Etat;
        }

        public string Titre
        {
            get { return _titre; }
        }

        public string Auteur
        {
            get { return _auteur; }
        }

        public ushort Etat
        {
            get { return _etat; }
            set { _etat = value; }
        }

        /// <summary>
        /// Dégrade les livres
        /// </summary>
        /// <returns></returns>
        public void Degrade()
        {
            if (_etat > 0) { _etat--; }
        }
        /// <summary>
        /// description du livre
        /// </summary>
        /// <returns>Description</returns>
        public string DescriptionDuLivre()
        {
            return "\nTitre : " + _titre + "\nAuteur : " + _auteur + "\nEtat :" + _etat;
        }
    }
}
