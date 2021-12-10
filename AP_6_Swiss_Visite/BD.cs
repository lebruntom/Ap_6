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
        //connection à la base de données
        private static string Connexionstring = @"Data Source=BTS2020-20\SQLEXPRESS;Initial Catalog=DB_gesAMM;Integrated Security=True";
        public static SqlConnection Connexion = new SqlConnection(Connexionstring);

        
        //Appel de la procedure pour afficher les étapes normées
        public static void lireLesEtapesNormees()
        {
            Globale.lesEtapes.Clear();
            Globale.lesEtapesNormee.Clear();

            Connexion.Open();
            SqlCommand commande = new SqlCommand("prc_listeEtapeNormee", Connexion);
            commande.CommandType = CommandType.StoredProcedure;
            SqlDataReader resultat = commande.ExecuteReader();

            while (resultat.Read())
            {
                int numEtapeNormee = (int)resultat["ETP_NUM"];
                string EtapeLibelle = resultat["ETP_LIBELLE"].ToString();
                string EtapeNormeLibelle = resultat["ETP_NORME"].ToString().Trim(' ');
                DateTime EtapeDateNorme = (DateTime)resultat["ETP_DATE_NORME"];

                new EtapeNormee(numEtapeNormee, EtapeLibelle, EtapeNormeLibelle, EtapeDateNorme);
            }
            Connexion.Close();
        }

        //Appel procédure pour afficher toutes les familles
        public static void lireAllFamiles()
        {
            if(Famille.LesFamilles.Count == 0)
            {
                Connexion.Open();

                SqlCommand commande = new SqlCommand("prc_select_med_fam", Connexion);
                commande.CommandType = CommandType.StoredProcedure;
                SqlDataReader resultat = commande.ExecuteReader();


                while (resultat.Read())
                {
                    string numFamille = (string)resultat["FAM_CODE"];
                    string libelleFamille = resultat["FAM_LIBELLE"].ToString();

                    Famille laFamille = new Famille(numFamille, libelleFamille);

                    Globale.famille.Add(laFamille.getCodeFamille(), laFamille);
                }
                Connexion.Close();
            }
        }

        //Appel procedure pour afficher les médicaments par famille
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

        //Appel procédure pour modifer une étape normée
        public static bool ModifierEtapeNorme(int etp_num, string etp_norme, DateTime etp_date)
        {
            Connexion.Open();
         

            SqlCommand maRequete = new SqlCommand("prc_update_etape_normee", Connexion);
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

            maRequete.ExecuteNonQuery();

            SqlCommand commande = new SqlCommand("prc_listeEtapeNormee", Connexion);
            commande.CommandType = CommandType.StoredProcedure;
            SqlDataReader resultat = commande.ExecuteReader();
            Globale.lesEtapes.Clear();
            Globale.lesEtapesNormee.Clear();
            while (resultat.Read())
            {
                int numEtapeNormee = (int)resultat["ETP_NUM"];
                string EtapeLibelle = resultat["ETP_LIBELLE"].ToString();
                string EtapeNormeLibelle = resultat["ETP_NORME"].ToString();
                DateTime EtapeDateNorme = (DateTime)resultat["ETP_DATE_NORME"];

                new EtapeNormee(numEtapeNormee, EtapeLibelle, EtapeNormeLibelle, EtapeDateNorme);
            }

            Connexion.Close();

            return true;
        }
        public static void getMedicaments()
        {

            Medicament.lesMedicaments.Clear();

            Connexion.Open();

            SqlCommand commande = new SqlCommand("prc_get_medicament", Connexion);
            commande.CommandType = CommandType.StoredProcedure;
            SqlDataReader resultat = commande.ExecuteReader();





            while (resultat.Read())
            {
                string depotLegalMed = resultat["MED_DEPOTLEGAL"].ToString();
                string nomCommercialMed = resultat["MED_NOMCOMMERCIAL"].ToString();
                string familleCode = resultat["FAM_CODE"].ToString();
                string compositionMed = resultat["MED_COMPOSITION"].ToString();
                string effetsMed = resultat["MED_EFFETS"].ToString();
                string contreIndicationMed = resultat["MED_CONTREINDIC"].ToString();




                object prix = resultat["MED_PRIXECHANTILLON"];
                float prixEchantillonMed = 0.0f;
                if (prix.GetType() != typeof(DBNull))
                    prixEchantillonMed = (float)resultat["MED_PRIXECHANTILLON"];



                object derEtape = resultat["Derniere_etape"];
                int derniereEtape = 0;
                if (derEtape.GetType() != typeof(DBNull))
                    derniereEtape = (int)resultat["Derniere_etape"];




                new Medicament(depotLegalMed, nomCommercialMed, familleCode, compositionMed, effetsMed, contreIndicationMed, prixEchantillonMed, derniereEtape);
            }
            Connexion.Close();
        }
    }
}
