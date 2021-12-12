
namespace AP_6_Swiss_Visite
{
    partial class AjoutWorkflow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.lvMedicament = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvWorkflow = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvDecision = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1000, 749);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lvMedicament
            // 
            this.lvMedicament.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvMedicament.FullRowSelect = true;
            this.lvMedicament.HideSelection = false;
            this.lvMedicament.Location = new System.Drawing.Point(36, 71);
            this.lvMedicament.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvMedicament.Name = "lvMedicament";
            this.lvMedicament.Size = new System.Drawing.Size(1164, 325);
            this.lvMedicament.TabIndex = 1;
            this.lvMedicament.UseCompatibleStateImageBehavior = false;
            this.lvMedicament.View = System.Windows.Forms.View.Details;
            this.lvMedicament.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Depot";
            this.columnHeader1.Width = 98;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Medicament";
            this.columnHeader2.Width = 133;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "FamilleCode";
            this.columnHeader3.Width = 137;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Composition";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Effet";
            this.columnHeader5.Width = 82;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Contreindic";
            this.columnHeader6.Width = 105;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "PrixEchantillon";
            this.columnHeader7.Width = 141;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Dernière-Etape";
            this.columnHeader8.Width = 166;
            // 
            // lvWorkflow
            // 
            this.lvWorkflow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader13,
            this.columnHeader14});
            this.lvWorkflow.HideSelection = false;
            this.lvWorkflow.Location = new System.Drawing.Point(36, 473);
            this.lvWorkflow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvWorkflow.Name = "lvWorkflow";
            this.lvWorkflow.Size = new System.Drawing.Size(657, 242);
            this.lvWorkflow.TabIndex = 2;
            this.lvWorkflow.UseCompatibleStateImageBehavior = false;
            this.lvWorkflow.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "N° Etape";
            this.columnHeader9.Width = 91;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Libellé";
            this.columnHeader10.Width = 117;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Norme";
            this.columnHeader13.Width = 201;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Date Norme";
            this.columnHeader14.Width = 187;
            // 
            // lvDecision
            // 
            this.lvDecision.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12});
            this.lvDecision.HideSelection = false;
            this.lvDecision.Location = new System.Drawing.Point(776, 473);
            this.lvDecision.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvDecision.Name = "lvDecision";
            this.lvDecision.Size = new System.Drawing.Size(424, 242);
            this.lvDecision.TabIndex = 3;
            this.lvDecision.UseCompatibleStateImageBehavior = false;
            this.lvDecision.View = System.Windows.Forms.View.Details;
            this.lvDecision.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Décision";
            this.columnHeader11.Width = 131;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Date de la décision";
            this.columnHeader12.Width = 251;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(447, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Affichage des Médicaments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(437, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Affichage des Etapes et des Normes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(852, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Affichage de la décision";
            // 
            // AjoutWorkflow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 831);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvDecision);
            this.Controls.Add(this.lvWorkflow);
            this.Controls.Add(this.lvMedicament);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AjoutWorkflow";
            this.Text = "AjoutWorkflow";
            this.Load += new System.EventHandler(this.AjoutWorkflow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lvMedicament;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ListView lvWorkflow;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ListView lvDecision;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}