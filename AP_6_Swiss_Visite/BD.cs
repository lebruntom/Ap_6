using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AP_6_Swiss_Visite
{
    public static class BD
    {
        private static string Connexionstring = @"Data Source=BTS2020-31\SQLEXPRESS;Initial Catalog=DB_gesAMM;Integrated Security=True";
        public static SqlConnection Connexion = new SqlConnection(Connexionstring);

        public static void lireWorkflow()
        {
            Connexion.Open();
            SqlCommand commande = new SqlCommand("prc_afficher_workflow", Connexion);
            commande.CommandType = CommandType.StoredProcedure;
            SqlDataReader resultat = commande.ExecuteReader();



            while (resultat.Read())
            {
                string med_depot = (string)resultat["MED_DEPOTLEGAL"];
                int etp_num = (int)resultat["ETP_NUM"];
                int dcs_id = (int)resultat["DCS_ID"];
                DateTime datedecision = (DateTime)resultat["dateDecision"];

                new Workflow(med_depot, etp_num, dcs_id, datedecision);

            }
            Connexion.Close();
        }
    }
}
