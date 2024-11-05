using ACT_6_Heritage.Class;

namespace ACT_6_Heritage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicule mon1Vehicule = new Vehicule("Su7","Xiaomi","Cyan",36000);
            Console.WriteLine(mon1Vehicule.Afficher());

            Voiture ma1Voiture = new Voiture("Diesel", true, "Karoq", "Skoda", "Gris", 33000);
            Console.WriteLine(ma1Voiture.Afficher());

            Velo mon1Velo = new Velo("VTT", true, "Q17", "Trek", "Noir", 4200);
            Console.WriteLine(mon1Velo.Afficher());
        }
    }
}
