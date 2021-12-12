using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace AP_6_Swiss_Visite
{
    class GestionSQL
    {
        private static string Connexionstring = @"Data Source=BTS2020-31\SQLEXPRESS;Initial Catalog=DB_gesAMM;Integrated Security=True";
        public static SqlConnection Connexion = new SqlConnection(Connexionstring);

        public static void getFamilles()//procédure qui permet de récupérer les informations de la table famille
        {
            Globale.LesFamilles.Clear();

            Connexion.Open();
            SqlCommand commande = new SqlCommand("prc_get_familles", Connexion);//appel de la procedure stocké
            commande.CommandType = CommandType.StoredProcedure; //le type d'objet donc ici une procédure stocké
            SqlDataReader resultat = commande.ExecuteReader();//excécution de la procédure

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

            Globale.lesMedicaments.Clear();

            SqlCommand commande = new SqlCommand("prc_lireMedicament", Connexion);//nom de la procédure pour récupérer les données de la table
            commande.CommandType = CommandType.StoredProcedure;//le type d'objet donc ici une procédure stocké
            SqlDataReader resultat = commande.ExecuteReader();//excécution de la procédure

            while (resultat.Read())
            {
                string med_depot = resultat["MED_DEPOTLEGAL"].ToString();
                string med_nom = resultat["MED_NOMCOMMERCIAL"].ToString();
                string familleCode = resultat["FAM_CODE"].ToString();
                string med_compo = resultat["MED_COMPOSITION"].ToString();
                string med_effet = resultat["MED_EFFETS"].ToString();
                string med_cont = resultat["MED_CONTREINDIC"].ToString();
                object prix = resultat["MED_PRIXECHANTILLON"];

                float prixEchantillonMed = 0.0f;
                if (prix.GetType() != typeof(DBNull))
                    prixEchantillonMed = (float)resultat["MED_PRIXECHANTILLON"];
                //pour afficher 0 si c'est null et éviter les erreurs possible avec un null dans notre base de donnée
                object derEtape = resultat["Derniere_etape"];
                int derniereEtape = 0;
                if (derEtape.GetType() != typeof(DBNull))
                    derniereEtape = (int)resultat["Derniere_etape"];

                new Medicament(med_depot, med_nom, familleCode, med_compo, med_effet, med_cont, prixEchantillonMed, derniereEtape);
            }
            Connexion.Close();
            foreach (Medicament M in Globale.lesMedicaments.Values)
            {
                GetWorkflowMedicament(M);
            }

        }
        public static void lireDecision()/*pour récuperer la table decision*/
        {
            Connexion.Open();

            SqlCommand command = new SqlCommand("prc_afficher_decision", Connexion) { CommandType = CommandType.StoredProcedure };
            SqlDataReader result = command.ExecuteReader();

            while (result.Read())
            {
                int id = int.Parse(result["DCS_ID"].ToString());
                string libelle = result["DCS_LIBELLE"].ToString();

                new Decision(id, libelle);
                
            }
            Connexion.Close();
        }
        public static void lireEtapes()/*pour récuperer la table Etape et Etape normé vu que c'est un héritage*/
        {
            Globale.lesEtapes.Clear();

            Connexion.Open();

            SqlCommand command = new SqlCommand("prc_lire_Etapes", Connexion);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataReader result = command.ExecuteReader();


            while (result.Read())
            {
                int numEtape = int.Parse(result["ETP_NUM"].ToString());
                string etapeLibelle = result["ETP_LIBELLE"].ToString();
                string norme = result["ETP_NORME"].ToString();
                DateTime dateNorme = DateTime.Parse(result["ETP_DATE_NORME"].ToString());

                Globale.lesEtapes.Add(new Etape(numEtape, etapeLibelle));//Ajout dans Etape

                Globale.lesEtapes.Add(new Etape_norme(numEtape, etapeLibelle, norme, dateNorme));//Ajout dans Etape_Normée
            }
            Connexion.Close();
        }
        public static void GetWorkflowMedicament(Medicament Medic)//lire la table Workflow
        {
            Connexion.Open();

            SqlCommand command = new SqlCommand("prc_afficher_workflow", Connexion) { CommandType = CommandType.StoredProcedure };
            SqlParameter param = new SqlParameter("@depotLegal", SqlDbType.VarChar, 10) { Value = Medic.getDepotLegal() };
            //car il y a un paramètre dans notre procédure donc il indique qu'il y a un paramètre ici depotLegal
            command.Parameters.Add(param);// ajout du paramètre

            SqlDataReader result = command.ExecuteReader();

            List<Workflow> lesEtapes = new List<Workflow>();

            while (result.Read())
            {
                string depotlegal = result["MED_DEPOTLEGAL"].ToString();
                int etapeNum = int.Parse(result["ETP_NUM"].ToString());
                int decisionID = int.Parse(result["DCS_ID"].ToString());
                DateTime dateDecision = DateTime.Parse(result["dateDecision"].ToString());

                Workflow unWorkflow = new Workflow(depotlegal, etapeNum, decisionID, dateDecision);
                lesEtapes.Add(unWorkflow);//ajout
            }
            Medic.setlesEtapes(lesEtapes);//permet de lire Workflow à partir de la classe médicament
            Connexion.Close();
        }
    }
}
