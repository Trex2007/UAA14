using ACT10_AdrienB_classesLiee.Classes;
using System.Data.SqlTypes;
using System.Globalization;

namespace ACT10_AdrienB_classesLiee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bibliotheque biblioth = new Bibliotheque();

            biblioth.Livres.Add(new Livre("premier", "premier", 5));
            biblioth.Livres.Add(new Livre("Second", "Second", 5));
            biblioth.Livres.Add(new Livre("Gogole", "Gogole", 5));

            string question = "[A] = New Book | [B] See One Book | [C] Degrade Book | [D] Delete Degraded Book | [E] See Library | [F] Add Book in library";
            Console.WriteLine(question);
            while (true)
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.A:
                        Console.Clear();
                        Console.WriteLine(question+"\n ");


                        string titre = "";
                        string auteur = "";
                        bool existe = false;
                        Console.Write("\nTitre du livre : ");
                        titre = Console.ReadLine();
                        Console.Write("\nauteur du livre : ");
                        auteur = Console.ReadLine();

                        foreach (var item in biblioth.Livres)
                        {
                            if (item.Titre == titre)
                            {
                                existe = true;
                            }
                        }
                        if (!existe)
                        {
                            biblioth.Livres.Add(new Livre(titre, auteur, 5));
                            Console.WriteLine("\nLe livre a été crée avec succès");
                        }
                        else
                        {
                            Console.WriteLine("\nCe livre exist déjà");
                        }


                        break;
                    case ConsoleKey.B:
                        Console.Clear();
                        Console.WriteLine(question+"\n ");
                        


                        Console.WriteLine("Liste Des Livres :");
                        foreach (var item in biblioth.Livres)
                        {
                            Console.WriteLine($"- {item.Titre}");
                        }

                        bool trouve = false;
                        while (trouve == false)
                        {
                            Console.Write("\nQuelle livre voulez-vous voir ? (Titre) : ");
                            titre = Console.ReadLine();

                            foreach (var item in biblioth.Livres)
                            {
                                if (item.Titre == titre)
                                {
                                    trouve = true;

                                    Console.Clear();
                                    Console.WriteLine(question + "\n ");

                                    Console.WriteLine($"Titre : {item.Titre}");
                                    Console.WriteLine($"Auteur : {item.Auteur}");
                                    Console.WriteLine($"Etat : {item.Etat}/5");
                                }
                            }
                            if (trouve == false)
                            {
                                Console.WriteLine("Livre non trouver");
                            }
                        }


                        break;
                    case ConsoleKey.C:
                        Console.Clear();
                        Console.WriteLine(question + "\n ");

                        Console.WriteLine("Liste Des Livres :");
                        foreach (var item in biblioth.Livres)
                        {
                            Console.WriteLine($"- {item.Titre}");
                        }

                        trouve = false;
                        while (trouve == false)
                        {
                            Console.Write("\nQuelle livre voulez-vous dégrader ? (Titre) : ");
                            titre = Console.ReadLine();

                            foreach (var item in biblioth.Livres)
                            {
                                if (item.Titre == titre)
                                {
                                    trouve = true;

                                    Console.Clear();
                                    Console.WriteLine(question + "\n ");

                                    Console.Write($"Etat passe de {item.Etat} à ");
                                    item.Degrade();
                                    Console.Write($"{item.Etat}");
                                }
                            }
                            if (trouve == false)
                            {
                                Console.WriteLine("Livre non trouver");
                            }
                        }

                        break;
                    case ConsoleKey.D:
                        Console.Clear();
                        Console.WriteLine(question + "\n ");

                        Console.WriteLine("Les livres suivants ont été supprimé :");
                        biblioth.SupprimerLivreAbimes();

                        break;
                    case ConsoleKey.E:
                        Console.Clear();
                        Console.WriteLine(question + "\n ");

                        biblioth.Inventaire();

                        break;
                    case ConsoleKey.F:
                        Console.Clear();
                        Console.WriteLine(question + "\n ");

                        Console.WriteLine("Liste Des Livres :");
                        foreach (var item in biblioth.Livres)
                        {
                            Console.WriteLine($"- {item.Titre}");
                        }

                        trouve = false;
                        while (trouve == false)
                        {
                            Console.Write("\nQuelle livre voulez-vous Ajouter a la bibliothèque ? (Titre) : ");
                            titre = Console.ReadLine();

                            for (int i = 0; i < biblioth.Livres.Count; i++)
                            {
                                var item = biblioth.Livres[i];

                                if (item.Titre == titre)
                                {
                                    trouve = true;

                                    Console.Clear();
                                    Console.WriteLine(question + "\n ");

                                    biblioth.Ajoute(item);
                                }
                            }
                            if (trouve == false)
                            {
                                Console.WriteLine("Livre non trouver");
                            }
                        }

                        break;
                }
            }
        }
    }
}