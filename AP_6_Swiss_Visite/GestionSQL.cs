using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AP_6_Swiss_Visite
{
    public static class GestionSQL
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

            foreach(Medicament unMedicament in Medicament.lesMedicaments.Values)
            {
                getWorkflow(unMedicament);
            }
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

        public static void getDecision()
        {
            Decision.lesDecisions.Clear();
            Connexion.Open();
            SqlCommand commande = new SqlCommand("prc_get_decision", Connexion);
            commande.CommandType = CommandType.StoredProcedure;
            SqlDataReader resultat = commande.ExecuteReader();

            while (resultat.Read())
            {
                int idDecision = (int)resultat["DCS_ID"];
                string libelleDecision = resultat["DCS_LIBELLE"].ToString();

                Decision.lesDecisions.Add(new Decision(idDecision, libelleDecision));
            }
            Connexion.Close();
        }

        public static void getEtapes()
        {
            Etape.lesEtapes.Clear();

            Connexion.Open();
            SqlCommand commande = new SqlCommand("prc_get_etape", Connexion);
            commande.CommandType = CommandType.StoredProcedure;
            SqlDataReader resultat = commande.ExecuteReader();

            while (resultat.Read())
            {
                int numEtape = (int)resultat["ETP_NUM"];
                string libelleEtape = resultat["ETP_LIBELLE"].ToString();
                string normeEtape = resultat["ETP_NORME"].ToString();
                DateTime dateNormeEtape = (DateTime)resultat["ETP_DATE_NORME"];

                Etape.lesEtapes.Add(new Etape(numEtape, libelleEtape));
                Etape.lesEtapes.Add(new EtapeNormee(numEtape, libelleEtape, normeEtape, dateNormeEtape));
            }
            Connexion.Close();
        }

        public static void getWorkflow(Medicament unMedicament)
        {
            Connexion.Open();
            SqlCommand commande = new SqlCommand("prc_get_workflow", Connexion);
            commande.CommandType = CommandType.StoredProcedure;
            SqlParameter param = new SqlParameter("@depotLegal", SqlDbType.VarChar, 10)
            {
                Value = unMedicament.getDepotLegal()
            };
            commande.Parameters.Add(param);
            
            SqlDataReader resultat = commande.ExecuteReader();

            List<Workflow> lesEtapes = new List<Workflow>();

            while (resultat.Read())
            {
                string depotLegalMed = resultat["MED_DEPOTLEGAL"].ToString();
                int numEtape = int.Parse(resultat["ETP_NUM"].ToString());
                int idDecision = int.Parse(resultat["DCS_ID"].ToString());
                DateTime dateDecision = DateTime.Parse(resultat["dateDecision"].ToString());

                Workflow unWorkflow = new Workflow(depotLegalMed, numEtape, idDecision, dateDecision);
                lesEtapes.Add(unWorkflow);
            }
            unMedicament.setLesEtapes(lesEtapes);
            Connexion.Close();
        }
    }
}
