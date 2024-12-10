using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT6_HERITAGE_1.Class
{
    internal class Animaux
    {
        protected string _nom;
        protected DateTime _ddn;
        protected int _npuce;
        protected float _height;
        protected bool _concours;

        public Animaux(string nom, DateTime ddn, int npuce, float height, bool concours)
        {
            _nom = nom;
            _ddn = ddn;
            _npuce = npuce;
            _height = height;
            _concours = concours;
        }

        public string Nom => _nom;
        public DateTime Ddn => _ddn;
        public int Npuce => _npuce;
        public float Height => _height;
        public bool Concours => _concours;

        public virtual string Dormir() => $"{_nom} dort.";
        public virtual string Manger() => $"{_nom} mange.";
    }

    internal class Chien : Animaux
    {
        public Chien(string nom, DateTime ddn, int npuce, float height, bool concours)
            : base(nom, ddn, npuce, height, concours) { }

        public string Aboyer() => $"{_nom} aboie.";
    }

    internal class Chat : Animaux
    {
        public Chat(string nom, DateTime ddn, int npuce, float height, bool concours)
            : base(nom, ddn, npuce, height, concours) { }

        public string Miauler() => $"{_nom} miaule.";
        public string Ronronner() => $"{_nom} ronronne.";
    }

    internal class Lapin : Animaux
    {
        private float _tailleOreille;

        public Lapin(string nom, DateTime ddn, int npuce, float height, bool concours, float tailleOreille)
            : base(nom, ddn, npuce, height, concours)
        {
            _tailleOreille = tailleOreille;
        }

        public float TailleOreille => _tailleOreille;

        public string Bondir() => $"{_nom} bondit.";
    }
}