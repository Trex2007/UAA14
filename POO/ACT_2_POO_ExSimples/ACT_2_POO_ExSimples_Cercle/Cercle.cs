﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT_2_POO_ExSimples_Cercle
{
    internal class Cercle
    {
        private double _rayon;

        public Cercle(double rayon)
        {
            _rayon = rayon;
        }
        public double Rayon
        {
            get
            {
                return _rayon;
            }
            set
            {
                _rayon = value;
            }
        }
        public Double CalculeAire()
        {
            return Math.PI * (_rayon * _rayon);
        }
        public Double CalculePermimetre()
        {
            return (2 * Math.PI) * _rayon;
        }
    }
}
