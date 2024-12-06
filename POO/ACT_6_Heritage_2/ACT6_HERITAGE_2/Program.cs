using ACT6_HERITAGE_2.Class;

namespace ACT6_HERITAGE_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle monRectangle = new Rectangle("Rouge", new float[] { 5, 10 });
            Console.WriteLine(monRectangle.CalculerSurface());

            Carre monCarre = new Carre("Bleu", 6);
            Console.WriteLine(monCarre.CalculerSurface());
        }
    }
}
