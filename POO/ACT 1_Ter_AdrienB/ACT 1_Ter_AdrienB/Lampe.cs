using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT_1_Ter_AdrienB
{
    internal class Lampe
    {
        private bool _statut;
        private string _color;
        private double _intensite;

        public Lampe(bool statut, string color, double intensite)
        {
            this._statut = statut;
            this._color = color;
            this._intensite = intensite;
        }

        public bool Statut
        {
            get {
                return _statut; 
            }
            set
            {
                _statut = value;
            }
        }
        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }
        public double Intensite
        {
            get
            {
                return _intensite;
            }
            set
            {
                _intensite = value;
            }
        }
    }
}
