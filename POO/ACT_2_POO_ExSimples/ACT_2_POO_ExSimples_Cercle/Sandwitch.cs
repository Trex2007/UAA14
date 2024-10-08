using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT_2_POO_ExSimples_Cercle
{
    internal class Sandwitch
    {
        private string[] _proteine = new string[] { "Viande", "Fromage", "Jambon", "Poulet" };
        private string[] _condiment = new string[] { "Moutarde", "Ketchup", "Mayonnaise", "Tabasco" };
        private string[] _pain = new string[] { "Blanc", "Gris", "Noir", "Complet" };
        private string[] _crudite = new string[] { "Salade", "Tomate", "Carotte", "Radis" };
        public string[] Proteine
        {
            get
            {
                return _proteine;
            }
        }
        public string[] Condiment
        {
            get
            {
                return _condiment;
            }
        }
        public string[] Pain
        {
            get
            {
                return _pain;
            }
        }
        public string[] Crudite
        {
            get
            {
                return _crudite;
            }
        }
        public string SandwitchMaker()
        {
            Random random = new Random();
            string message = "Votre sandwitch est composer de :";

            int rand = random.Next(0, 3);
            message += "\n- Pain " + _pain[rand];

            rand = random.Next(0, 3);
            message += "\n- " + _proteine[rand];

            rand = random.Next(0, 3);
            message += "\n- " + _condiment[rand];

            rand = random.Next(0, 3);
            message += "\n- " + _crudite[rand];

            return message;
        }
    }
}
