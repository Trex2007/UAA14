using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using Google.Protobuf.WellKnownTypes;
using System.Reflection.Metadata.Ecma335;
using System.Data.Common;
using System.Net;
using System.Runtime.ConstrainedExecution;

namespace ACT_7_AdrienB_CRUDetBDD
{
    public struct method
    {
        static string DefinirCheminBD() // détermine la chaîne de connexion
        {
            return "server=localhost;database=poo-test;port=3306;User Id=root;password=root";
        }
        public bool allUser(out DataSet infos)
        {
            bool ok = false;
            try
            {
                MySqlConnection allUsers = new MySqlConnection(DefinirCheminBD());
                infos = new DataSet();

                allUsers.Open();

                string query = "SELECT * FROM utilisateurs;";

                MySqlDataAdapter da = new MySqlDataAdapter(query, allUsers);

                da.Fill(infos, "mesDonnees");


                allUsers.Close();

                if(infos.Tables[0].Rows.Count > 0)
                {
                    ok = true;
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
            return ok;
        }
        public bool allBiens(out DataSet infos)
        {
            bool ok = false;
            try
            {
                MySqlConnection allUsers = new MySqlConnection(DefinirCheminBD());
                infos = new DataSet();

                allUsers.Open();

                string query = "SELECT * FROM biens;";

                MySqlDataAdapter da = new MySqlDataAdapter(query, allUsers);

                da.Fill(infos, "mesDonnees");


                allUsers.Close();

                if (infos.Tables[0].Rows.Count > 0)
                {
                    ok = true;
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
            return ok;
        }
        public bool allOptionBiens(int id,out DataSet infos)
        {
            bool ok = false;
            try
            {
                MySqlConnection allUsers = new MySqlConnection(DefinirCheminBD());
                infos = new DataSet();

                allUsers.Open();

                string query = "SELECT * FROM options WHERE optionId IN(Select optionId from biens_options Where bienId = "+id+");" ;

                MySqlDataAdapter da = new MySqlDataAdapter(query, allUsers);

                da.Fill(infos, "mesDonnees");


                allUsers.Close();

                if (infos.Tables[0].Rows.Count > 0)
                {
                    ok = true;
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
            return ok;
        }

        public bool AddBien(string[] donnee)
        {
            try
            {
                MySqlConnection allUsers = new MySqlConnection(DefinirCheminBD());

                allUsers.Open();

                string query = "INSERT INTO biens(nom,taille,prix,ville,userId,description,chambres,imageBien) VALUES(@nom, @taille, @prix, @ville, @userId, @description, @chambres, @imageBien)";



                MySqlCommand da = new MySqlCommand(query, allUsers);

                da.Parameters.AddWithValue("@nom", donnee[0]);
                da.Parameters.AddWithValue("@taille", donnee[1]);
                da.Parameters.AddWithValue("@prix", donnee[2]);
                da.Parameters.AddWithValue("@ville", donnee[3]);
                da.Parameters.AddWithValue("@userId", 1);
                da.Parameters.AddWithValue("@description", donnee[5]);
                da.Parameters.AddWithValue("@chambres", donnee[6]);
                da.Parameters.AddWithValue("@imageBien", 43);

                da.ExecuteNonQuery();

                allUsers.Close();

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
            return true;
        }
        public bool DeleteBien(int bienid)
        {
            try
            {
                MySqlConnection allUsers = new MySqlConnection(DefinirCheminBD());

                allUsers.Open();

                string query = "DELETE FROM biens WHERE bienId=" + bienid;

                MySqlCommand da = new MySqlCommand(query, allUsers);

                da.ExecuteNonQuery();

                allUsers.Close();

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
            return true;
        }
        public bool UpdateBien(int bienid, string[] donneeEdit)
        {
            try
            {
                MySqlConnection allUsers = new MySqlConnection(DefinirCheminBD());

                allUsers.Open();

                string query = "UPDATE biens SET nom=@nom,taille=@taille,prix=@prix,ville=@ville,userId=@userId,description=@description,chambres=@chambres,imageBien=@imageBien WHERE bienId =" + bienid + ";";

                MySqlCommand da = new MySqlCommand(query, allUsers);

                da.Parameters.AddWithValue("@nom", donneeEdit[0]);
                da.Parameters.AddWithValue("@taille", donneeEdit[1]);
                da.Parameters.AddWithValue("@prix", donneeEdit[2]);
                da.Parameters.AddWithValue("@ville", donneeEdit[3]);
                da.Parameters.AddWithValue("@userId", 1);
                da.Parameters.AddWithValue("@description", donneeEdit[5]);
                da.Parameters.AddWithValue("@chambres", donneeEdit[6]);
                da.Parameters.AddWithValue("@imageBien", 43);

                da.ExecuteNonQuery();

                allUsers.Close();

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
            return true;
        }
    }
}
