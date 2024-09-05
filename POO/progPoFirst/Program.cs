namespace progPoFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat premierGogole = new Cat(2, "Reaver", 5.2, 50, "Mencoon", true);
            while (true)
            {
                Console.WriteLine("\nQue voulez-vous faire ?\n[A]=Infos | [Z]=Manger | [E]=Boire\n[Q]=Viellir | [S]=Blessé | [D]=Mourir");

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.A:
                        Console.Clear();
                        Console.WriteLine(premierGogole.InfosCat());
                        break;
                    case ConsoleKey.Z:
                        Console.Clear();
                        Console.WriteLine(premierGogole.Manger());
                        break;
                    case ConsoleKey.E:
                        Console.Clear();
                        Console.WriteLine(premierGogole.Boire());
                        break;
                    case ConsoleKey.Q:
                        Console.Clear();
                        Console.WriteLine(premierGogole.Viellir());
                        break;
                    case ConsoleKey.S:
                        Console.Clear();
                        Console.WriteLine(premierGogole.SeBlesse());
                        break;
                    case ConsoleKey.D:
                        Console.Clear();
                        Console.WriteLine(premierGogole.Mort());
                        break;

                }


            }
        }
    }
}
