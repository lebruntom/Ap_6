using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP_6_Swiss_Visite
{
    public partial class AjoutWorkflow : Form
    {
        public AjoutWorkflow()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AjoutWorkflow_Load(object sender, EventArgs e)
        {
            lvMedicament.Items.Clear();

            Dictionary<string, Medicament>.KeyCollection lesCles = Globale.lesMedicaments.Keys;
            foreach (string code in lesCles)//pour parcourrir le dictionnaire
            {
                Medicament unMedicament = Globale.lesMedicaments[code]; //pour récupérer l'élément par rapport a la clés

                ListViewItem laLigne = new ListViewItem();
                laLigne.Text = unMedicament.getDepotLegal().ToString();
                laLigne.SubItems.Add(unMedicament.getNomCommercial().ToString());
                laLigne.SubItems.Add(unMedicament.getlaFamille().getCodeFamille().ToString());
                laLigne.SubItems.Add(unMedicament.getComposition().ToString());
                laLigne.SubItems.Add(unMedicament.getEffet().ToString());
                laLigne.SubItems.Add(unMedicament.getContreIndication().ToString());
                laLigne.SubItems.Add(unMedicament.getPrixEchantillon().ToString());
                laLigne.SubItems.Add(unMedicament.getDerniereEtape().ToString());

                lvMedicament.Items.Add(laLigne);
            }
        }
    }
}
