using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT_2_POO_ExSimples_Cercle
{
    internal class Complexe
    {
        private double _reel;
        private double _imaginaire;
        public Complexe(double reel, double imaginaire)
        {
            _reel = reel;
            _imaginaire = imaginaire;
        }
        public double Reel
        {
            get
            {
                return _reel;
            }
            set
            {
                _reel = value;
            }
        }
        public double Imaginaire
        {
            get
            {
                return _imaginaire;
            }
            set
            {
                _imaginaire = value;
            }
        }
        public string AfficheComplexe()
        {
            return "Nbr Complexe : (" + _reel + "," + _imaginaire + ")";
        }
        public string CalculeModule()
        {
            return "Module : " + Math.Sqrt((_reel * _reel) + (_imaginaire * _imaginaire));
        }
        public void AjouteComplexe(Complexe secondComplexe)
        {
            _reel += secondComplexe.Reel;
            _imaginaire += secondComplexe.Imaginaire;
        }
    }
}
