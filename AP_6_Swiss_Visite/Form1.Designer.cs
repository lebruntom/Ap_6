
namespace AP_6_Swiss_Visite
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.familleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicamentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etapeNorméeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miseÀJourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.décisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workflowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parFamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.familleToolStripMenuItem,
            this.médicamentsToolStripMenuItem,
            this.etapeToolStripMenuItem,
            this.etapeNorméeToolStripMenuItem,
            this.décisionToolStripMenuItem,
            this.workflowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // familleToolStripMenuItem
            // 
            this.familleToolStripMenuItem.Name = "familleToolStripMenuItem";
            this.familleToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.familleToolStripMenuItem.Text = "Famille";
            // 
            // médicamentsToolStripMenuItem
            // 
            this.médicamentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parFamilleToolStripMenuItem});
            this.médicamentsToolStripMenuItem.Name = "médicamentsToolStripMenuItem";
            this.médicamentsToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.médicamentsToolStripMenuItem.Text = "Médicaments";
            // 
            // etapeToolStripMenuItem
            // 
            this.etapeToolStripMenuItem.Name = "etapeToolStripMenuItem";
            this.etapeToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.etapeToolStripMenuItem.Text = "Etape";
            // 
            // etapeNorméeToolStripMenuItem
            // 
            this.etapeNorméeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miseÀJourToolStripMenuItem});
            this.etapeNorméeToolStripMenuItem.Name = "etapeNorméeToolStripMenuItem";
            this.etapeNorméeToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.etapeNorméeToolStripMenuItem.Text = "Etape normée";
            // 
            // miseÀJourToolStripMenuItem
            // 
            this.miseÀJourToolStripMenuItem.Name = "miseÀJourToolStripMenuItem";
            this.miseÀJourToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.miseÀJourToolStripMenuItem.Text = "Mise à jour";
            this.miseÀJourToolStripMenuItem.Click += new System.EventHandler(this.miseÀJourToolStripMenuItem_Click);
            // 
            // décisionToolStripMenuItem
            // 
            this.décisionToolStripMenuItem.Name = "décisionToolStripMenuItem";
            this.décisionToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.décisionToolStripMenuItem.Text = "Décision";
            // 
            // workflowToolStripMenuItem
            // 
            this.workflowToolStripMenuItem.Name = "workflowToolStripMenuItem";
            this.workflowToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.workflowToolStripMenuItem.Text = "Workflow";
            // 
            // parFamilleToolStripMenuItem
            // 
            this.parFamilleToolStripMenuItem.Name = "parFamilleToolStripMenuItem";
            this.parFamilleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.parFamilleToolStripMenuItem.Text = "Par famille";
            this.parFamilleToolStripMenuItem.Click += new System.EventHandler(this.parFamilleToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem familleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médicamentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etapeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etapeNorméeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem décisionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workflowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miseÀJourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parFamilleToolStripMenuItem;
    }
}

