
namespace AP_6_Swiss_Visite
{
    partial class MedicamentEnCoursDeValidation
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
            this.lvMedicament = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvEtape = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvDecision = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvMedicament
            // 
            this.lvMedicament.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvMedicament.FullRowSelect = true;
            this.lvMedicament.HideSelection = false;
            this.lvMedicament.Location = new System.Drawing.Point(26, 43);
            this.lvMedicament.Name = "lvMedicament";
            this.lvMedicament.Size = new System.Drawing.Size(887, 484);
            this.lvMedicament.TabIndex = 0;
            this.lvMedicament.UseCompatibleStateImageBehavior = false;
            this.lvMedicament.View = System.Windows.Forms.View.Details;
            this.lvMedicament.SelectedIndexChanged += new System.EventHandler(this.lvMedicament_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Dépot Légal";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nom Commercial";
            this.columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Famille";
            this.columnHeader3.Width = 330;
            // 
            // lvEtape
            // 
            this.lvEtape.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader7});
            this.lvEtape.HideSelection = false;
            this.lvEtape.Location = new System.Drawing.Point(919, 43);
            this.lvEtape.Name = "lvEtape";
            this.lvEtape.Size = new System.Drawing.Size(402, 305);
            this.lvEtape.TabIndex = 1;
            this.lvEtape.UseCompatibleStateImageBehavior = false;
            this.lvEtape.View = System.Windows.Forms.View.Details;
            this.lvEtape.SelectedIndexChanged += new System.EventHandler(this.lvEtape_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Numero";
            this.columnHeader4.Width = 103;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Norme";
            this.columnHeader5.Width = 118;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Date Norme";
            this.columnHeader7.Width = 194;
            // 
            // lvDecision
            // 
            this.lvDecision.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader8});
            this.lvDecision.HideSelection = false;
            this.lvDecision.Location = new System.Drawing.Point(1346, 43);
            this.lvDecision.Name = "lvDecision";
            this.lvDecision.Size = new System.Drawing.Size(349, 305);
            this.lvDecision.TabIndex = 2;
            this.lvDecision.UseCompatibleStateImageBehavior = false;
            this.lvDecision.View = System.Windows.Forms.View.Details;
            this.lvDecision.SelectedIndexChanged += new System.EventHandler(this.lvDecision_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Decision";
            this.columnHeader6.Width = 103;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Date";
            this.columnHeader8.Width = 118;
            // 
            // btRetour
            // 
            this.btRetour.Location = new System.Drawing.Point(1259, 439);
            this.btRetour.Name = "btRetour";
            this.btRetour.Size = new System.Drawing.Size(346, 88);
            this.btRetour.TabIndex = 3;
            this.btRetour.Text = "Retour";
            this.btRetour.UseVisualStyleBackColor = true;
            this.btRetour.Click += new System.EventHandler(this.btRetour_Click);
            // 
            // MedicamentEnCoursDeValidation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 568);
            this.Controls.Add(this.btRetour);
            this.Controls.Add(this.lvDecision);
            this.Controls.Add(this.lvEtape);
            this.Controls.Add(this.lvMedicament);
            this.Name = "MedicamentEnCoursDeValidation";
            this.Text = "MedicamentEnCoursDeValidation";
            this.Load += new System.EventHandler(this.MedicamentEnCoursDeValidation_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvMedicament;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lvEtape;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ListView lvDecision;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btRetour;
    }
}