namespace ACT11_ClassesLieeHeritage_AdrienB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            int m = 0;
            while (true)
            {
                string afffich = "";
                s++;
                if (s == 60)
                {
                    m++;
                    s = 0;
                }
                Console.CursorVisible = false;
                Console.SetCursorPosition(0, 0);

                if(m < 10)
                {
                    afffich += "0";
                }
                afffich += m.ToString() + ":";
                if (s < 10)
                {
                    afffich += "0";
                }
                afffich += s.ToString();
                Console.WriteLine(afffich);



                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
