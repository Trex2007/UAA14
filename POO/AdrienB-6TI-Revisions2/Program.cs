namespace AdrienB_6TI_Revisions2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MethodesDuProjet outilPro = new MethodesDuProjet(); // instanciation d ela structure

            double nombreCouleur;
            string question = "Quelle couleurs voulez-vous ?\nRouge = 1\nBleu = 2\nVert = 3";
            outilPro.lireDouble(question, out nombreCouleur);

            Console.WriteLine(nombreCouleur);
        }
    }
}
