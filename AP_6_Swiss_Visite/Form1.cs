using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AP_6_Swiss_Visite.GestionSQL;


namespace AP_6_Swiss_Visite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getFamilles();
            lireMedicament();
            lireEtapes();
            lireDecision();
        }

        private void ajoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void enCoursDeValidationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AjoutWorkflow ajoutWorkflow = new AjoutWorkflow();
            ajoutWorkflow.Show();
        }
    }
}
