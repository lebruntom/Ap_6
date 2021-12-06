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
    public partial class frm_medicaments_parFamille : Form
    {
        public frm_medicaments_parFamille()
        {
            InitializeComponent();
        }

        private void frm_medicaments_parFamille_Load(object sender, EventArgs e)
        {
             
            foreach(Famille laFamille in Globale.lesFamilles)
            {
                ListViewItem ligne = new ListViewItem();

                ligne.Text = laFamille.getCode().ToString();
                ligne.SubItems.Add(laFamille.getLibelle());
                ligne.SubItems.Add(laFamille.getNbMediAmm().ToString());


                lvMedFam.Items.Add(ligne);
            }
            
        }
    }
}
