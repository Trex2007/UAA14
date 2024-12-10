using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT6_HERITAGE_2.Class
{
    internal abstract class Parallelepipede
    {
        protected string _couleur;

        public Parallelepipede(string couleur)
        {
            _couleur = couleur;
        }

        public string Couleur
        {
            get => _couleur;
            set => _couleur = value;
        }

        public abstract int CalculerSurface();
        public abstract int CalculerPerimetre();
    }

    internal class Rectangle : Parallelepipede
    {
        private float[] _dimensions;

        public Rectangle(string couleur, float[] dimensions) : base(couleur)
        {
            _dimensions = dimensions;
        }

        public float[] Dimensions
        {
            get => _dimensions;
            set => _dimensions = value;
        }

        public override int CalculerSurface() => (int)(_dimensions[0] * _dimensions[1]);
        public override int CalculerPerimetre() => (int)(2 * (_dimensions[0] + _dimensions[1]));
    }

    internal class Carre : Parallelepipede
    {
        private float _dimension;

        public Carre(string couleur, float dimension) : base(couleur)
        {
            _dimension = dimension;
        }

        public float Dimension
        {
            get => _dimension;
            set => _dimension = value;
        }

        public override int CalculerSurface() => (int)(_dimension * _dimension);
        public override int CalculerPerimetre() => (int)(4 * _dimension);
    }
}