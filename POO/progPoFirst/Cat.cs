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

        public Cat(short age, string name, double weight, double height, string race, bool puce) {
            _age = age;
            _name = name;
            _weight = weight;
            _height = height;
            _race = race;
            _puce = puce;
        }
        public string Manger(){ return "QUELLE BON STEAK !"; }
        public string Boire() { return "QUELLE BONNE EAU !"; }
        public string Viellir() {
            _age++;
            return "O NON JE VIELLI !\nJ'ai maintenant "+_age+" ans !"; 
        }
        public string SeBlesse() { return "O NON JE SUIS BLESSE !"; }
        public string Mort() { return "X.X"; }
        public string InfosCat()
        {
            return "Nom : " + _name + "\nAge : " + _age + " ans\nPoid : " + _weight + " Kilo\nTaille : " + _height + " cm\nRace : " + _race +"\nPuce : " + _puce;
        }
    }
}

