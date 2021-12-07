using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace AP_6_Swiss_Visite
{
    public partial class frm_EtapeNorme_maj : Form
    {
        public frm_EtapeNorme_maj()
        {
            InitializeComponent();
        }
        private void chargerListe()
        {
            lvEtapeNormee.Items.Clear();


            foreach (EtapeNormee uneEtapeNormee in Globale.lesEtapesNormee)
            {
                ListViewItem ligne = new ListViewItem();

                ligne.Text = uneEtapeNormee.getNum().ToString();
                ligne.SubItems.Add(uneEtapeNormee.getNorme());
                ligne.SubItems.Add(uneEtapeNormee.getDateNorme().ToString().Substring(0, 10));

                lvEtapeNormee.Items.Add(ligne);
            }
        }

        private void chargerHistorique()
        {
            lvhistorique.Items.Clear();

            BD.Connexion.Open();
            SqlCommand maRequete = new SqlCommand("prc_liste_historique", BD.Connexion);
            maRequete.CommandType = CommandType.StoredProcedure;




            SqlDataReader allData = maRequete.ExecuteReader();


            while (allData.Read())
            {
                ListViewItem ligne = new ListViewItem();


                ligne.Text = allData.GetValue(0).ToString();
                ligne.SubItems.Add(allData.GetValue(1).ToString());
                ligne.SubItems.Add(allData.GetValue(2).ToString());
                ligne.SubItems.Add(allData.GetValue(3).ToString());
                ligne.SubItems.Add(allData.GetValue(4).ToString());
                ligne.SubItems.Add(allData.GetValue(5).ToString());
                ligne.SubItems.Add(allData.GetValue(6).ToString());


                lvhistorique.Items.Add(ligne);
            }
            BD.Connexion.Close();
        }
        private void frm_EtapeNorme_maj_Load(object sender, EventArgs e)
        {

            lvhistorique.Items.Clear();
            chargerHistorique();


            lvEtapeNormee.Items.Clear();

            chargerListe();
            btModifEtapeNorme.Enabled = false;
           
        }

        private void lvEtapeNormee_SelectedIndexChanged(object sender, EventArgs e)
        {
            btModifEtapeNorme.Enabled = true;
            if (lvEtapeNormee.SelectedIndices.Count <= 0)
            {
                return;
            }
            int idx = lvEtapeNormee.SelectedIndices[0];

            if (idx >= 0)
            {
                string norm = lvEtapeNormee.Items[idx].SubItems[1].Text;
                string date = lvEtapeNormee.Items[idx].SubItems[2].Text;

                tbEtapeNorme.Text = norm;
                tbDateNorme.Text = date;
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btModifEtapeNorme_Click(object sender, EventArgs e)
        {
            if (tbEtapeNorme.Text != "" && tbEtapeNorme.Text != "")
            {
                try
                {
                  
                    if (BD.ModifierEtapeNorme(3, tbEtapeNorme.Text, DateTime.Parse(tbDateNorme.Text)))
                    {
                        MessageBox.Show("L'étape normée a bien été mise à jour");
                        chargerListe();
                    }
                    else
                    {
                        MessageBox.Show("Erreur dans la mise à jour de l'étape normée");
                    }
                }
                catch
                {
                    MessageBox.Show("Erreur, le n° de l'étape doit être un entier");
                }
            }
            else
            {
                MessageBox.Show("Erreur, il faut renseigner tous les champs");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 etape_norme_maj = new Form1();
            etape_norme_maj.Show();
        }
    }
}
