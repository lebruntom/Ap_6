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
    public partial class MedicamentEnCoursDeValidation : Form
    {
        public MedicamentEnCoursDeValidation()
        {
            InitializeComponent();
        }

        private void MedicamentEnCoursDeValidation_Load(object sender, EventArgs e)
        {
            foreach(Medicament unMedicament in Medicament.lesMedicaments.Values)
            {
                ListViewItem ligne = new ListViewItem();

                ligne.Text = unMedicament.getDepotLegal();
                ligne.SubItems.Add(unMedicament.getNomCommercial());
                ligne.SubItems.Add(unMedicament.getlaFamille().getLibelleFamille());

                lvMedicament.Items.Add(ligne);
            }
        }

        private void lvMedicament_SelectedIndexChanged(object sender, EventArgs e)
        {
/*            Medicament unMedicament = Medicament.lesMedicaments[lvMedicament.SelectedItems];
*/
                //affichage du workflow pour le medicament selectionné
        }
    }
}
