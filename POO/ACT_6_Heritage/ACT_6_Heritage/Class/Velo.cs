using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT_6_Heritage.Class
{
    internal class Velo : Vehicule
    {
        private string _type;
        private bool _ebike;
        public Velo(string type, bool ebike, string modele, string marque, string couleur, decimal prix) : base(modele, marque, couleur, prix)
        {
            _type = type;
            _ebike = ebike;
        }
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public bool Ebike
        {
            get { return _ebike; }
            set { _ebike = value; }
        }
        public override string Afficher()
        {
            return "Velo " + base.Afficher() + ", " + _type + ", eBike=" + _ebike + ".";
        }
    }
}
