using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT_1_Ter_AdrienB
{
    internal class Interupteur
    {
        private Lampe _lampe;
        private int _numeroInter;

        public Interupteur(int numeroInter, Lampe lampe)
        {
            _numeroInter = _numeroInter;
            _lampe = lampe;
        }

        public void ChangerStatut()
        {
            _lampe.Statut = !_lampe.Statut;
        }
    }
}
