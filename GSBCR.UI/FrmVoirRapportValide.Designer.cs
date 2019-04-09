namespace GSBCR.UI
{
    partial class FrmVoirRapportValide
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxRapport = new System.Windows.Forms.ComboBox();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnAfficherPracticien = new System.Windows.Forms.Button();
            this.bsRapports = new System.Windows.Forms.BindingSource(this.components);
            this.btnAfficherMed1 = new System.Windows.Forms.Button();
            this.btnAfficherMed2 = new System.Windows.Forms.Button();
            this.ucRapportValide1 = new GSBCR.UC.UcRapportValide();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapports)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Rapports validés";
            // 
            // cbxRapport
            // 
            this.cbxRapport.FormattingEnabled = true;
            this.cbxRapport.Location = new System.Drawing.Point(276, 6);
            this.cbxRapport.Name = "cbxRapport";
            this.cbxRapport.Size = new System.Drawing.Size(121, 21);
            this.cbxRapport.TabIndex = 18;
            this.cbxRapport.SelectedIndexChanged += new System.EventHandler(this.cbxRapport_SelectedIndexChanged);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(262, 298);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 35;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnAfficherPracticien
            // 
            this.btnAfficherPracticien.Location = new System.Drawing.Point(250, 86);
            this.btnAfficherPracticien.Name = "btnAfficherPracticien";
            this.btnAfficherPracticien.Size = new System.Drawing.Size(147, 37);
            this.btnAfficherPracticien.TabIndex = 37;
            this.btnAfficherPracticien.Text = "Afficher les renseignements sur le practicien";
            this.btnAfficherPracticien.UseVisualStyleBackColor = true;
            this.btnAfficherPracticien.Click += new System.EventHandler(this.btnAfficherPracticien_Click);
            // 
            // btnAfficherMed1
            // 
            this.btnAfficherMed1.Location = new System.Drawing.Point(508, 227);
            this.btnAfficherMed1.Name = "btnAfficherMed1";
            this.btnAfficherMed1.Size = new System.Drawing.Size(144, 37);
            this.btnAfficherMed1.TabIndex = 38;
            this.btnAfficherMed1.Text = "Afficher les renseignements sur le medicament 1";
            this.btnAfficherMed1.UseVisualStyleBackColor = true;
            this.btnAfficherMed1.Click += new System.EventHandler(this.btnAfficherMed1_Click);
            // 
            // btnAfficherMed2
            // 
            this.btnAfficherMed2.Location = new System.Drawing.Point(508, 270);
            this.btnAfficherMed2.Name = "btnAfficherMed2";
            this.btnAfficherMed2.Size = new System.Drawing.Size(144, 37);
            this.btnAfficherMed2.TabIndex = 39;
            this.btnAfficherMed2.Text = "Afficher les renseignements sur le medicament 2";
            this.btnAfficherMed2.UseVisualStyleBackColor = true;
            this.btnAfficherMed2.Click += new System.EventHandler(this.btnAfficherMed2_Click);
            // 
            // ucRapportValide1
            // 
            this.ucRapportValide1.LeRapportVisite = null;
            this.ucRapportValide1.Location = new System.Drawing.Point(12, 33);
            this.ucRapportValide1.Name = "ucRapportValide1";
            this.ucRapportValide1.Size = new System.Drawing.Size(589, 259);
            this.ucRapportValide1.TabIndex = 36;
            // 
            // FrmVoirRapportValide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 333);
            this.Controls.Add(this.btnAfficherMed2);
            this.Controls.Add(this.btnAfficherMed1);
            this.Controls.Add(this.btnAfficherPracticien);
            this.Controls.Add(this.ucRapportValide1);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxRapport);
            this.Name = "FrmVoirRapportValide";
            this.Text = "FrmVoirRapportValide";
            ((System.ComponentModel.ISupportInitialize)(this.bsRapports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxRapport;
        private System.Windows.Forms.BindingSource bsRapports;
        private System.Windows.Forms.Button btnRetour;
        private UC.UcRapportValide ucRapportValide1;
        private System.Windows.Forms.Button btnAfficherPracticien;
        private System.Windows.Forms.Button btnAfficherMed1;
        private System.Windows.Forms.Button btnAfficherMed2;
    }
}