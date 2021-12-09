using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using static AP_6_Swiss_Visite.GestionSQL;

namespace AP_6_Swiss_Visite
{
    class GestionSQL
    {
        private static string Connexionstring = @"Data Source=BTS2020-13\SQLEXPRESS;Initial Catalog=test;Integrated Security=True";
        public static SqlConnection Connexion = new SqlConnection(Connexionstring);


        public static void getFamilles()
        {
            Famille.LesFamilles.Clear();

            Connexion.Open();
            SqlCommand commande = new SqlCommand("prc_get_familles", Connexion);
            commande.CommandType = CommandType.StoredProcedure;
            SqlDataReader resultat = commande.ExecuteReader();

            while (resultat.Read())
            {
                string codeFamille = resultat["FAM_CODE"].ToString();
                string libelleFamille = resultat["FAM_LIBELLE"].ToString();
                new Famille(codeFamille, libelleFamille);
            }
            Connexion.Close();
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

        public static Boolean ajouterMedicament(string depotLegal, string nomCommercialMed, string familleCode, string compositionMed, string effetMed, string contreIndicationMed, float prixUnitaire)
        {
            Connexion.Open();

            //appel de la procedure
            SqlCommand maRequete = new SqlCommand("prc_ajouter_medicament", Connexion);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            //affectation des paramètres pour la procedure stockée
            SqlParameter paramDepotLegal = new SqlParameter("@DepotLegal", System.Data.SqlDbType.NVarChar, 10);
            paramDepotLegal.Value = depotLegal;

            SqlParameter paramNomCommercial = new SqlParameter("@NomCommercial", System.Data.SqlDbType.NVarChar, 25);
            paramNomCommercial.Value = nomCommercialMed;

            SqlParameter paramFamilleCode= new SqlParameter("@FamilleCode", System.Data.SqlDbType.NVarChar, 3);
            paramFamilleCode.Value = familleCode;

            SqlParameter paramComposition = new SqlParameter("@Composition", System.Data.SqlDbType.NVarChar, 255);
            paramComposition.Value = compositionMed;

            SqlParameter paramEffet = new SqlParameter("@Effet", System.Data.SqlDbType.NVarChar, 255);
            paramEffet.Value = effetMed;

            SqlParameter paramContreIndication = new SqlParameter("@ContreIndication", System.Data.SqlDbType.NVarChar, 255);
            paramContreIndication.Value = contreIndicationMed;

            SqlParameter paramPrixUnitaire = new SqlParameter("@PrixUnitaire", System.Data.SqlDbType.Float, 255);
            paramPrixUnitaire.Value = prixUnitaire;

            maRequete.Parameters.Add(paramDepotLegal);
            maRequete.Parameters.Add(paramNomCommercial);
            maRequete.Parameters.Add(paramFamilleCode);
            maRequete.Parameters.Add(paramComposition);
            maRequete.Parameters.Add(paramEffet);
            maRequete.Parameters.Add(paramContreIndication);
            maRequete.Parameters.Add(paramPrixUnitaire);

            //éxécuter la procedure stockée
            try
            {
                maRequete.ExecuteNonQuery();
                Connexion.Close();
                return true;
            }
            catch
            {
                Connexion.Close();
                return false;
            }
        }
    }
}
