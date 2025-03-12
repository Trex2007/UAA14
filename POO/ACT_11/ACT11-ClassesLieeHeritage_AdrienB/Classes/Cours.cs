using System;
using System.Collections.Generic;
using System.Linq;

namespace ACT11_ClassesLieeHeritage_AdrienB.Classes
{
    internal class Cours
    {
        private string _nom;
        private Salle _salle;
        private List<double> _listeNotes;

        public Cours(string nom, Salle salle, List<double> notes)
        {
            _nom = nom;
            _salle = salle;
            _listeNotes = notes ?? new List<double>();
        }

        public string Nom => _nom;
        public Salle Salle => _salle;
        public List<double> ListeNotes => _listeNotes;

        public void AjouterNote(double note)
        {
            _listeNotes.Add(note);
        }

        public double CalculerMoyenneCours()
        {
            if (_listeNotes.Count == 0)
                return 0; // Retourne 0 si pas de notes pour éviter la division par zéro

            return _listeNotes.Average();
        }
    }
}
