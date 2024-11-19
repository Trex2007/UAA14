using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ACT_6_Heritage.Class
{
    internal class Voiture : Vehicule
    {
        private string _motorisation;
        private bool _gps;
        public Voiture(string motorisation, bool gps, string modele, string marque, string couleur, decimal prix) : base(modele, marque, couleur, prix)
        {
            _motorisation = motorisation;
            _gps = gps;
        }
        public string Motorisation
        {
            get { return _motorisation; }
            set { _motorisation = value; }
        }
        public bool Gps
        {
            get { return _gps; }
            set { _gps = value; }
        }
        public override string Afficher()
        {
            return "Voiture " + base.Afficher() + ", " + _motorisation + ", GPS=" + _gps + ".";
        }
    }
    
}
