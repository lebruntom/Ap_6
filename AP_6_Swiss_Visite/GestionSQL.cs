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
        private static string Connexionstring = @"Data Source=BTS2020-31\SQLEXPRESS;Initial Catalog=DB_gesAMM;Integrated Security=True";
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
        //pour lire les médicaments 
        public static void lireMedicament()
        {
            Connexion.Open();

            Medicament.lesMedicaments.Clear();



            SqlCommand commande = new SqlCommand("prc_lireMedicament", Connexion);//nom de la procédure pour récupérer les données de la table
            commande.CommandType = CommandType.StoredProcedure;
            SqlDataReader resultat = commande.ExecuteReader();

            while (resultat.Read())
            {
                string med_depot = (string)resultat["MED_DEPOTLEGAL"];
                string med_nom = (string)resultat["MED_NOMCOMMERCIAL"];
                string familleCode = (string)resultat["FAM_CODE"];
                string med_compo = (string)resultat["MED_COMPOSITION"];
                string med_effet = (string)resultat["MED_EFFETS"];
                string med_cont = (string)resultat["MED_CONTREINDIC"];
                object prix = resultat["MED_PRIXECHANTILLON"];

                float prixEchantillonMed = 0.0f;
                if (prix.GetType() != typeof(DBNull))
                    prixEchantillonMed = (float)resultat["MED_PRIXECHANTILLON"];

                object derEtape = resultat["Derniere_etape"];
                int derniereEtape = 0;
                if (derEtape.GetType() != typeof(DBNull))
                    derniereEtape = (int)resultat["Derniere_etape"];


                Medicament medic = new Medicament(med_depot, med_nom, familleCode, med_compo, med_effet, med_cont, prixEchantillonMed, derniereEtape);
                Globale.lesMedicaments.Add(med_depot, medic);
            }
            Connexion.Close();
        }
    }
}
