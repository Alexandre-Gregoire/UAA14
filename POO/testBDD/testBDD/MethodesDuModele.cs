using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testBDD
{
    public struct MethodesDuModele
    {
        public string DefinirCheminBD() // détermine la chaîne de connexion
        {
            return "server=10.10.51.98;database=immo;port=3306;User Id=alexandre6t;password=root";
        }
        public bool ChercheUtilisateurs(out DataSet infos)
        {
            bool ok = false;
            MySqlConnection maConnexion = new MySqlConnection(DefinirCheminBD());
            string query = "SELECT * FROM utilisateurs WHERE id=" + "1" + ";";
            infos = new DataSet();

            try
            {
                maConnexion.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(query, maConnexion);
                da.Fill(infos, "mesDonnees");
                if (infos.Tables[0].Rows.Count >= 1)
                {
                    ok = true;
                }
                maConnexion.Close();

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
            return ok;

        }
        public string AfficheDataUsers(DataSet donnees)
        {
            string infos = "";
            for (int i = 0; i < donnees.Tables[0].Rows.Count; i++)
            {
                infos += donnees.Tables[0].Rows[i]["nomUser"].ToString() + " | " +
                         donnees.Tables[0].Rows[i]["prenomUser"].ToString() + " | " +
                         donnees.Tables[0].Rows[i]["loginUser"].ToString() + " | " +
                         donnees.Tables[0].Rows[i]["passWordUser"].ToString() + " | " + "\n";
            }
            return infos;
        }
    }
}
