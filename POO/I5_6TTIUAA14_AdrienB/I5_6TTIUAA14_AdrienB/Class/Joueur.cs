using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace I5_6TTIUAA14_AdrienB.Class
{
    internal class Joueur
    {
        string _pseudo;
        byte _nbCartouchesEnPoche;
        PaintBallGun _myPaintBallGun;

        public Joueur(string Pseudo, byte NbCartouchesEnPoche, PaintBallGun MyPaintBallGun)
        {
            _pseudo = Pseudo;
            _nbCartouchesEnPoche = NbCartouchesEnPoche;
            _myPaintBallGun = MyPaintBallGun;
        }

        public string Pseudo 
        {
            get 
            { 
                return _pseudo; 
            } 
        }
        public byte NbCartouchesEnPoche
        {
            get
            {
                return _nbCartouchesEnPoche;
            }
            set
            {
                _nbCartouchesEnPoche = value;
            }
        }
        public PaintBallGun MyPaintBallGun
        {
            get
            {
                return _myPaintBallGun;
            }
            set
            {
                _myPaintBallGun = value;
            }
        }

        /// <summary>
        /// pour recharger l'arme et verifier si on en a asser
        /// </summary>
        /// <returns></returns>
        public string Recharger()
        {
            int remPoche = _myPaintBallGun.TailleChargeur - _myPaintBallGun.NbBallesChargeur;
            if(_myPaintBallGun.TailleChargeur == _myPaintBallGun.NbBallesChargeur)
            {
                return "\nLe chargeur est déja plein";
            }
            else
            {
                if (_nbCartouchesEnPoche >= (_myPaintBallGun.TailleChargeur - _myPaintBallGun.NbBallesChargeur))
                {
                    _nbCartouchesEnPoche -= ((byte)remPoche);
                    _myPaintBallGun.NbBallesChargeur += ((byte)remPoche);
                    return "\nChargeur rechargé avec succès ! Il vous reste : " + _nbCartouchesEnPoche + " Dans vos poches\nNombres de balles ajoutée : " + remPoche;
                }
                else
                {
                    return "\nL'arme n'a pas pus etre rechargée, il vous manques des balles";
                }
            }
        }
        /// <summary>
        /// Pour vérifier si l'ont peut tirer avec l'arme
        /// </summary>
        /// <returns></returns>
        public bool Tire()
        {
            if (_myPaintBallGun.ChargeurEstVide())
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }
        /// <summary>
        /// Pour voir notre nombre de balles en poche et dans le chargeur
        /// </summary>
        /// <returns></returns>
        public string VerifPoche()
        {
            return "\ncartouches en poches : "+ _nbCartouchesEnPoche +" , balles dans le chargeur : " + _myPaintBallGun.NbBallesChargeur;
        }
    }
}
