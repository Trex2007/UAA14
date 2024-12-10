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
            Console.WriteLine("[A] = All User | [B] All Biens | [C] Add Biens | Edit/Update -> AllBiens ");
            while (true)
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.A:
                        Console.Clear();
                        Console.WriteLine("[A] = All User | [B] All Biens | [C] Add Biens\n ");
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
                        Console.WriteLine("[A] = All User | [B] All Biens | [C] Add Biens | [D] Edit Bien | [E] Delete Bien");
                        if (methodes.allBiens(out infos))
                        {
                            for (int i = 0; i < infos.Tables[0].Rows.Count; i++)
                            {
                                Console.Write("\n["+infos.Tables[0].Rows[i]["bienid"] + "] ");
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
                                Console.Write("\n");
                            }
                        }

                        break;
                    case ConsoleKey.C:
                        Console.Clear();
                        Console.WriteLine("[A] = All User | [B] All Biens | [C] Add Biens");
                        string[] donnee = new string[8];

                        Console.Write("\nNom du bien : ");
                        donnee[0] = Console.ReadLine();
                        Console.Write("\nTaille du bien : ");
                        donnee[1] = Console.ReadLine();
                        Console.Write("\nPrix du bien : ");
                        donnee[2] = Console.ReadLine();
                        Console.Write("\nVille du bien : ");
                        donnee[3] = Console.ReadLine();
                        Console.Write("\nUtilisateur du bien (1) : ");
                        donnee[1] = Console.ReadLine();
                        Console.Write("\nDescription du bien : ");
                        donnee[5] = Console.ReadLine();
                        Console.Write("\nNombre de chambre(s) du bien : ");
                        donnee[6] = Console.ReadLine();
                        Console.Write("\nImage du bien (43) : ");
                        donnee[7] = Console.ReadLine();

                        if (methodes.AddBien(donnee))
                        {
                            Console.WriteLine("\nAction réalisé avec succès, changer de page.");
                        }
                        break;

                    case ConsoleKey.D:

                        int thisbienid = 0;

                        Console.Write("\n[ID] du bien : ");
                        thisbienid = int.Parse(Console.ReadLine());
                        Console.WriteLine(thisbienid);

                        Console.Clear();
                        Console.WriteLine("[A] = All User | [B] All Biens | [C] Add Biens");
                        string[] donneeEdit = new string[8];

                        Console.Write("\nNom du bien : ");
                        donneeEdit[0] = Console.ReadLine();
                        Console.Write("\nTaille du bien : ");
                        donneeEdit[1] = Console.ReadLine();
                        Console.Write("\nPrix du bien : ");
                        donneeEdit[2] = Console.ReadLine();
                        Console.Write("\nVille du bien : ");
                        donneeEdit[3] = Console.ReadLine();
                        Console.Write("\nUtilisateur du bien (1) : ");
                        donneeEdit[1] = Console.ReadLine();
                        Console.Write("\nDescription du bien : ");
                        donneeEdit[5] = Console.ReadLine();
                        Console.Write("\nNombre de chambre(s) du bien : ");
                        donneeEdit[6] = Console.ReadLine();
                        Console.Write("\nImage du bien (43) : ");
                        donneeEdit[7] = Console.ReadLine();

                        if (methodes.UpdateBien(thisbienid, donneeEdit))
                        {
                            Console.Clear();
                            Console.WriteLine("[A] = All User | [B] All Biens | [C] Add Biens");
                            Console.WriteLine("\nAction réalisé avec succès, changer de page.");
                        }

                        break;
                
                    case ConsoleKey.E:

                        int bienid = 0;

                        Console.Write("\n[ID] du bien : ");
                        bienid = int.Parse(Console.ReadLine());

                        if (methodes.DeleteBien(bienid))
                        {
                            Console.Clear();
                            Console.WriteLine("[A] = All User | [B] All Biens | [C] Add Biens");
                            Console.WriteLine("\nAction réalisé avec succès, changer de page.");
                        }

                        break;
                }
            }
        }
    }
}
