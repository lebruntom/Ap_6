﻿
namespace AP_6_Swiss_Visite
{
    partial class frm_EtapeNorme_maj
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
            this.lvEtapeNormee = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btModifEtapeNorme = new System.Windows.Forms.Button();
            this.tbEtapeNorme = new System.Windows.Forms.TextBox();
            this.tbDateNorme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvEtapeNormee
            // 
            this.lvEtapeNormee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvEtapeNormee.HideSelection = false;
            this.lvEtapeNormee.Location = new System.Drawing.Point(24, 21);
            this.lvEtapeNormee.Name = "lvEtapeNormee";
            this.lvEtapeNormee.Size = new System.Drawing.Size(387, 317);
            this.lvEtapeNormee.TabIndex = 0;
            this.lvEtapeNormee.UseCompatibleStateImageBehavior = false;
            this.lvEtapeNormee.View = System.Windows.Forms.View.Details;
            this.lvEtapeNormee.SelectedIndexChanged += new System.EventHandler(this.lvEtapeNormee_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ETP_NUM";
            this.columnHeader1.Width = 92;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ETP_NORME";
            this.columnHeader2.Width = 106;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ETP_DATE_NORME";
            this.columnHeader3.Width = 151;
            // 
            // btModifEtapeNorme
            // 
            this.btModifEtapeNorme.Location = new System.Drawing.Point(502, 203);
            this.btModifEtapeNorme.Name = "btModifEtapeNorme";
            this.btModifEtapeNorme.Size = new System.Drawing.Size(157, 56);
            this.btModifEtapeNorme.TabIndex = 1;
            this.btModifEtapeNorme.Text = "Modifier";
            this.btModifEtapeNorme.UseVisualStyleBackColor = true;
            this.btModifEtapeNorme.Click += new System.EventHandler(this.btModifEtapeNorme_Click);
            // 
            // tbEtapeNorme
            // 
            this.tbEtapeNorme.Location = new System.Drawing.Point(569, 54);
            this.tbEtapeNorme.Name = "tbEtapeNorme";
            this.tbEtapeNorme.Size = new System.Drawing.Size(174, 22);
            this.tbEtapeNorme.TabIndex = 2;
            this.tbEtapeNorme.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbDateNorme
            // 
            this.tbDateNorme.Location = new System.Drawing.Point(569, 115);
            this.tbDateNorme.Name = "tbDateNorme";
            this.tbDateNorme.Size = new System.Drawing.Size(173, 22);
            this.tbDateNorme.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "ETP_NORME :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "ETP_DATE_NORME :";
            // 
            // frm_EtapeNorme_maj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDateNorme);
            this.Controls.Add(this.tbEtapeNorme);
            this.Controls.Add(this.btModifEtapeNorme);
            this.Controls.Add(this.lvEtapeNormee);
            this.Name = "frm_EtapeNorme_maj";
            this.Text = "frm_EtapeNorme_maj";
            this.Load += new System.EventHandler(this.frm_EtapeNorme_maj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvEtapeNormee;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btModifEtapeNorme;
        private System.Windows.Forms.TextBox tbEtapeNorme;
        private System.Windows.Forms.TextBox tbDateNorme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}