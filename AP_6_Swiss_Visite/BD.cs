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

        public static void lireAllFamiles()
        {
            Connexion.Open();
            SqlCommand commande = new SqlCommand("prc_select_med_fam", Connexion);
            commande.CommandType = CommandType.StoredProcedure;
            SqlDataReader resultat = commande.ExecuteReader();

            
            while (resultat.Read())
            {
                string numFamille = (string)resultat["FAM_CODE"];
                string libelleFamille = resultat["FAM_LIBELLE"].ToString();
                int NombreMedicament = 0;

                Famille laFamille = new Famille(numFamille, libelleFamille, NombreMedicament);

                Globale.lesFamilles.Add(laFamille);
            }
            Connexion.Close();
           
        }
        public static void medparfam(string fam_code)
        {
            Connexion.Open();
            SqlCommand maRequete = new SqlCommand("prc_medicament_famille", Connexion);
            maRequete.CommandType = CommandType.StoredProcedure;

            // Ajouter les parameters à la procédure stockée
            SqlParameter paramFamCode = new SqlParameter("@fam_code", SqlDbType.Int, 5);
            paramFamCode.Value = fam_code;

            maRequete.Parameters.Add(paramFamCode);

            maRequete.ExecuteNonQuery();
            Connexion.Close();

        }

        public static bool ModifierEtapeNorme(int etp_num, string etp_norme, DateTime etp_date)
        {
            SqlCommand maRequete = new SqlCommand("prc_update_etape_normee", Globale.cnx);
            // Il s’agit d’une procédure stockée:
            maRequete.CommandType = CommandType.StoredProcedure;

            // Ajouter les parameters à la procédure stockée
            SqlParameter paramEtpNum = new SqlParameter("@etp_num", SqlDbType.Int, 5);
            paramEtpNum.Value = etp_num;
            SqlParameter paramEtpNorme = new SqlParameter("@etp_norme", SqlDbType.Char, 30);
            paramEtpNorme.Value = etp_norme;
            SqlParameter paramEtpDate = new SqlParameter("@etp_date", SqlDbType.Date, 30);
            paramEtpDate.Value = etp_date;
            maRequete.Parameters.Add(paramEtpNum);
            maRequete.Parameters.Add(paramEtpNorme);
            maRequete.Parameters.Add(paramEtpDate);
            // exécuter la procedure stockée
            try
            {
                maRequete.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
