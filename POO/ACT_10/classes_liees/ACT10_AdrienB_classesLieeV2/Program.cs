using ACT10_AdrienB_classesLieeV2.Classes;

namespace ACT10_AdrienB_classesLieeV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bibliotheque biblioth = new Bibliotheque();

            biblioth.Livres.Add(new Livre("premier", "premier", 5));
            biblioth.Livres.Add(new Livre("Second", "Second", 5));
            biblioth.Livres.Add(new Livre("Gogole", "Gogole", 5));

            string question = "[A] New Book | [B] See One Book | [C] Degrade Book | [D] Remove Degraded Book | [E] See Library\n\n[F] Add Book in library | [G] Emprunt | [H] Fin Emprunt | [I] See Emprunt";
            Console.WriteLine(question);
            while (true)
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.A:
                        Console.Clear();
                        Console.WriteLine(question + "\n ");
                        break;
                }
            }
        }
    }
}
