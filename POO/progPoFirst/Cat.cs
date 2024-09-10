using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progPoFirst
{
    internal class Cat
    {
        private short _age;
        private string _name;
        private double _weight;
        private double _height;
        private string _race;
        private bool _puce;
        private bool _mort;

        public Cat(short age, string name, double weight, double height, string race, bool puce, bool mort)
        {
            this._age = age;
            this._name = name;
            this._weight = weight;
            this._height = height;
            this._race = race;
            this._puce = puce;
            this._mort = mort;
        }
        public string Manger(){
            if (this._mort == true)
            {
                return "O NON JE NE PEUX MANGER JE SUIS MORT A " + this._age + " ANS !";
            }
            else
            {
                if (this._weight > 17 || this._weight < 2)
                {
                    this._mort = true;
                    return "OH NON JE SUIS MORT OBESE !";
                }
                else
                {
                    this._weight++;
                    return "QUELLE BON STEAK !";
                }
            }
        }
        public string Boire() {
            if (this._mort == true)
            {
                return "O NON JE NE PEUX BOIRE JE SUIS MORT A " + this._age + " ANS !";
            }
            else
            {
                if (this._weight > 17 || this._weight < 2)
                {
                    this._mort = true;
                    return "OH NON JE SUIS MORT OBESE !";
                }
                else
                {
                    this._weight++;
                    return "QUELLE BONNE EAU !";
                }
            }
            
        }
        public string Viellir() {
            if(this._mort == true){
                return "O NON JE NE VIELLI PLUS SUIS MORT A " + this._age + " ANS !";
            } else if (this._weight > 17 || this._weight < 2)
            {
                this._mort = true;
                return "OH NON JE SUIS MORT OBESE !";
            } else if (this._age > 17)
            {
                this._mort = true;
                return "OH NON JE SUIS MORT DE VIELLEISSE !";
            }
            else
            {
                this._age++;
                return "O NON JE VIELLI !\nJ'AI MAINTENANT " + this._age + " ANS !";
            }
        }
        public string SeBlesse() {
            if (this._mort == true)
            {
                return "O NON JE NE PEUX ME BLESSER JE SUIS MORT A " + this._age + " ANS !";
            }
            else
            {
                this._weight--;
                return "O NON JE ME BLESSE !";
            }
        }
        public string Mort() { 
            this._mort = true;
            return "JE SUIS MORT A " + this._age + " ANS !";
        }
        public string InfosCat()
        {
            if (this._weight > 17 || this._weight < 2)
            {
                this._mort = true;
            }
            if (this._mort == false)
            {
                this._weight--;
                return "Nom : " + this._name + "\nAge : " + this._age + " ans\nPoid : " + this._weight + 1 + " Kilo\nTaille : " + this._height + " cm\nRace : " + this._race + "\nPuce : " + this._puce;
            }
            else
            {
                return "Nom : " + this._name + "\nAge : " + this._age + " ans\nPoid : " + this._weight + 1 + " Kilo\nTaille : " + this._height + " cm\nRace : " + this._race + "\nPuce : " + this._puce +"\nJE SUIS MORT !";
            }
            
        }
    }
}

