using ACT6_HERITAGE_3.Class;

namespace ACT6_HERITAGE_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Création d'un bateau
            Boat monBateau = new Boat("Yamaha", 120, 15);
            Console.WriteLine(monBateau.Infos());

            // Création d'une voiture
            Car maVoiture = new Car("Toyota", 50, 15000);
            Console.WriteLine(maVoiture.Infos());

            // Création d'un camion
            Truck monCamion = new Truck("Volvo", 200, 30000, 10000);
            Console.WriteLine(monCamion.Infos());

            // Création d'un avion
            Plane monAvion = new Plane("Boeing", 5000, 15000);
            Console.WriteLine(monAvion.Infos());
        }
    }
}
