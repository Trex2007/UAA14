using ACT6_HERITAGE_1.Class;
using System;

namespace ACT6_HERITAGE_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chien monChien = new Chien("Max", new DateTime(2019, 5, 12), 12345, 50.5f, true);
            Console.WriteLine(monChien.Aboyer());

            Chat monChat = new Chat("Mimi", new DateTime(2020, 8, 1), 54321, 30.2f, false);
            Console.WriteLine(monChat.Miauler());

            Lapin monLapin = new Lapin("Fluffy", new DateTime(2021, 3, 15), 11223, 20.1f, false, 12.3f);
            Console.WriteLine(monLapin.Bondir());
        }
    }
}
