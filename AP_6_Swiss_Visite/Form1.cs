﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AP_6_Swiss_Visite.BD;

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
            lireLesEtapesNormees();
        }

        private void miseÀJourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_EtapeNorme_maj etape_norme_maj = new frm_EtapeNorme_maj();
            etape_norme_maj.Show();
        }
    }
}
