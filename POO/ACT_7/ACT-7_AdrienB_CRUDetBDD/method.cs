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
    }
}
