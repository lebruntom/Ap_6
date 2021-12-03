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
    public partial class frm_EtapeNorme_maj : Form
    {
        public frm_EtapeNorme_maj()
        {
            InitializeComponent();
        }

        private void frm_EtapeNorme_maj_Load(object sender, EventArgs e)
        {
            foreach (EtapeNormee uneEtapeNormee in Globale.lesEtapesNormee)
            {
                ListViewItem ligne = new ListViewItem();

                ligne.Text = uneEtapeNormee.getNum().ToString();
                ligne.SubItems.Add(uneEtapeNormee.getNorme());
                ligne.SubItems.Add(uneEtapeNormee.getDateNorme().ToString().Substring(0, 10));

                lvEtapeNormee.Items.Add(ligne);
            }
        }

        private void lvEtapeNormee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
