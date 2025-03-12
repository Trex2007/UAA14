using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT11_ClassesLieeHeritage_AdrienB.Classes
{
    internal class InfoCours
    {
        public Cours cours;
        public double note;

        public InfoCours(Cours cours, double note)
        {
            this.cours = cours;
            this.note = note;
        }
    }
}
