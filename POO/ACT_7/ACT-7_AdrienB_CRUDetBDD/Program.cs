using Google.Protobuf.WellKnownTypes;
using System.Data;

namespace ACT_7_AdrienB_CRUDetBDD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            method methodes = new method(); // isntanciation d ela structure

            DataSet infos;

            while (true)
            {
                Console.WriteLine("\n [A] = All User | [B] All Biens");
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.A:
                        Console.Clear();

                        if (methodes.allUser(out infos))
                        {
                            for (int i = 0; i < infos.Tables[0].Rows.Count; i++)
                            {
                                Console.Write(infos.Tables[0].Rows[i]["id"] + ", ");
                                Console.Write(infos.Tables[0].Rows[i]["nomUser"] + ", ");
                                Console.Write(infos.Tables[0].Rows[i]["prenomUser"] + ", ");
                                Console.Write(infos.Tables[0].Rows[i]["loginUser"] + ", ");
                                Console.Write(infos.Tables[0].Rows[i]["passWordUser"] + ", ");
                                Console.Write(infos.Tables[0].Rows[i]["role"] + "\n\n");
                            }
                        }
                        
                        break;
                    case ConsoleKey.B:
                        Console.Clear();

                        if (methodes.allBiens(out infos))
                        {
                            for (int i = 0; i < infos.Tables[0].Rows.Count; i++)
                            {
                                Console.Write("\n\n" + infos.Tables[0].Rows[i]["bienid"] + ", ");
                                Console.Write(infos.Tables[0].Rows[i]["nom"] + ", ");
                                Console.Write(infos.Tables[0].Rows[i]["taille"] + ", ");
                                Console.Write(infos.Tables[0].Rows[i]["prix"] + ", ");
                                Console.Write(infos.Tables[0].Rows[i]["ville"] + ", ");
                                Console.Write(infos.Tables[0].Rows[i]["userId"] + ", ");
                                Console.Write(infos.Tables[0].Rows[i]["description"] + ", ");
                                Console.Write(infos.Tables[0].Rows[i]["chambres"] + ", ");
                                Console.Write(infos.Tables[0].Rows[i]["imageBien"] + "\n");
                                int idDuBien = (int)infos.Tables[0].Rows[i]["bienid"];
                                if (methodes.allOptionBiens(idDuBien, out DataSet options))
                                {
                                    for (int y = 0; y < options.Tables[0].Rows.Count; y++)
                                    {
                                        Console.Write(options.Tables[0].Rows[y]["optionNom"] + ", ");
                                    }
                                }
                            }
                        }

                        break;
                }
                
            }
        }
    }
}
