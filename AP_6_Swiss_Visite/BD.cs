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
        private static string Connexionstring = @"Data Source=BTS2020-20\SQLEXPRESS;Initial Catalog=DB_gesAMM;Integrated Security=True";
        public static SqlConnection Connexion = new SqlConnection(Connexionstring);

        public static void lireLesEtapesNormees()
        {
            Connexion.Open();
            SqlCommand commande = new SqlCommand("prc_listeEtapeNormee", Connexion);
            commande.CommandType = CommandType.StoredProcedure;
            SqlDataReader resultat = commande.ExecuteReader();

            while (resultat.Read())
            {
                int numEtapeNormee = (int)resultat["ETP_NUM"];
                string EtapeLibelle = resultat["ETP_LIBELLE"].ToString();
                string EtapeNormeLibelle = resultat["ETP_NORME"].ToString();
                DateTime EtapeDateNorme = (DateTime)resultat["ETP_DATE_NORME"];

                new EtapeNormee(numEtapeNormee, EtapeLibelle, EtapeNormeLibelle, EtapeDateNorme);
            }
            Connexion.Close();
        }

        public static void lireLesMedFam()
        {
            Connexion.Open();
            SqlCommand commande = new SqlCommand("prc_select_med_fam", Connexion);
            commande.CommandType = CommandType.StoredProcedure;
            SqlDataReader resultat = commande.ExecuteReader();

            
            while (resultat.Read())
            {
                string numFamille = (string)resultat["FAM_CODE"];
                string libelleFamille = resultat["FAM_LIBELLE"].ToString();
                int NombreMedicament = (int)resultat["NombreMed"];

                Famille laFamille = new Famille(numFamille, libelleFamille, NombreMedicament);

                Globale.lesFamilles.Add(laFamille);
            }
            Connexion.Close();
           
        }
    }
}
