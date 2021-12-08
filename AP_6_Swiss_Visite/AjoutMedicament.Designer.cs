
namespace AP_6_Swiss_Visite
{
    partial class AjoutMedicament
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rtbComposition = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNomCommercial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbEffets = new System.Windows.Forms.RichTextBox();
            this.tbDepotLegal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbContreIndication = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbPrix = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(229, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(77, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // rtbComposition
            // 
            this.rtbComposition.Location = new System.Drawing.Point(168, 224);
            this.rtbComposition.Name = "rtbComposition";
            this.rtbComposition.Size = new System.Drawing.Size(224, 174);
            this.rtbComposition.TabIndex = 1;
            this.rtbComposition.Text = "";
            this.rtbComposition.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choisir la Famille :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom commercial :";
            // 
            // tbNomCommercial
            // 
            this.tbNomCommercial.Location = new System.Drawing.Point(168, 74);
            this.tbNomCommercial.Name = "tbNomCommercial";
            this.tbNomCommercial.Size = new System.Drawing.Size(224, 22);
            this.tbNomCommercial.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Composition :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(545, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Effets :";
            // 
            // rtbEffets
            // 
            this.rtbEffets.Location = new System.Drawing.Point(603, 224);
            this.rtbEffets.Name = "rtbEffets";
            this.rtbEffets.Size = new System.Drawing.Size(224, 174);
            this.rtbEffets.TabIndex = 6;
            this.rtbEffets.Text = "";
            // 
            // tbDepotLegal
            // 
            this.tbDepotLegal.Location = new System.Drawing.Point(168, 102);
            this.tbDepotLegal.Name = "tbDepotLegal";
            this.tbDepotLegal.Size = new System.Drawing.Size(224, 22);
            this.tbDepotLegal.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Depot legal :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // rtbContreIndication
            // 
            this.rtbContreIndication.Location = new System.Drawing.Point(603, 34);
            this.rtbContreIndication.Name = "rtbContreIndication";
            this.rtbContreIndication.Size = new System.Drawing.Size(224, 174);
            this.rtbContreIndication.TabIndex = 10;
            this.rtbContreIndication.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(468, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Contre Indications :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(360, 58);
            this.button1.TabIndex = 15;
            this.button1.Text = "Ajouter le medicament";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbPrix
            // 
            this.tbPrix.Location = new System.Drawing.Point(168, 130);
            this.tbPrix.Name = "tbPrix";
            this.tbPrix.Size = new System.Drawing.Size(224, 22);
            this.tbPrix.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Prix unitaire : ";
            // 
            // btRetour
            // 
            this.btRetour.Location = new System.Drawing.Point(698, 455);
            this.btRetour.Name = "btRetour";
            this.btRetour.Size = new System.Drawing.Size(105, 57);
            this.btRetour.TabIndex = 19;
            this.btRetour.Text = "Retour";
            this.btRetour.UseVisualStyleBackColor = true;
            this.btRetour.Click += new System.EventHandler(this.btRetour_Click);
            // 
            // AjoutMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 559);
            this.Controls.Add(this.btRetour);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbPrix);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtbContreIndication);
            this.Controls.Add(this.tbDepotLegal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtbEffets);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNomCommercial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbComposition);
            this.Controls.Add(this.comboBox1);
            this.Name = "AjoutMedicament";
            this.Text = "AjoutMedicament";
            this.Load += new System.EventHandler(this.AjoutMedicament_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox rtbComposition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNomCommercial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbEffets;
        private System.Windows.Forms.TextBox tbDepotLegal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbContreIndication;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbPrix;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btRetour;
    }
}