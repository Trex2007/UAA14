using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I5_6TTIUAA14_AdrienB.Class
{
    internal class PaintBallGun
    {
        byte _nbBallesChargeur;
        byte _tailleChargeur;

        public PaintBallGun (byte NbBallesChargeur, byte TailleChargeur)
        {
            _nbBallesChargeur = NbBallesChargeur;
            _tailleChargeur = TailleChargeur;
        }

        public byte NbBallesChargeur
        {
            get
            {
                return _nbBallesChargeur;
            }
            set
            {
                _nbBallesChargeur = value;
            }
        }
        public byte TailleChargeur
        {
            get
            {
                return _tailleChargeur;
            }
        }

        /// <summary>
        /// Pour vérifier si le chageur est vide
        /// </summary>
        /// <returns></returns>
        public bool ChargeurEstVide()
        {
            if (_nbBallesChargeur == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
