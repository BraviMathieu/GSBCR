namespace GSBCR.UI
{
    partial class FrmVisiteurEquipe
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
            this.bsVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.tbxMatricule = new System.Windows.Forms.TextBox();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.tbxPrenom = new System.Windows.Forms.TextBox();
            this.cbxVisiteurs = new System.Windows.Forms.ComboBox();
            this.dtpEmbauche = new System.Windows.Forms.DateTimePicker();
            this.dtpRegion = new System.Windows.Forms.DateTimePicker();
            this.tbxRapport = new System.Windows.Forms.TextBox();
            this.Matricule = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnpas0 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxMatricule
            // 
            this.tbxMatricule.Location = new System.Drawing.Point(78, 56);
            this.tbxMatricule.Name = "tbxMatricule";
            this.tbxMatricule.Size = new System.Drawing.Size(100, 20);
            this.tbxMatricule.TabIndex = 1;
            // 
            // tbxNom
            // 
            this.tbxNom.Location = new System.Drawing.Point(100, 97);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(100, 20);
            this.tbxNom.TabIndex = 2;
            // 
            // tbxPrenom
            // 
            this.tbxPrenom.Location = new System.Drawing.Point(221, 97);
            this.tbxPrenom.Name = "tbxPrenom";
            this.tbxPrenom.Size = new System.Drawing.Size(100, 20);
            this.tbxPrenom.TabIndex = 3;
            // 
            // cbxVisiteurs
            // 
            this.cbxVisiteurs.FormattingEnabled = true;
            this.cbxVisiteurs.Location = new System.Drawing.Point(234, 12);
            this.cbxVisiteurs.Name = "cbxVisiteurs";
            this.cbxVisiteurs.Size = new System.Drawing.Size(121, 21);
            this.cbxVisiteurs.TabIndex = 4;
            this.cbxVisiteurs.SelectedIndexChanged += new System.EventHandler(this.cbxVisiteurs_SelectedIndexChanged);
            // 
            // dtpEmbauche
            // 
            this.dtpEmbauche.Location = new System.Drawing.Point(137, 144);
            this.dtpEmbauche.Name = "dtpEmbauche";
            this.dtpEmbauche.Size = new System.Drawing.Size(200, 20);
            this.dtpEmbauche.TabIndex = 5;
            // 
            // dtpRegion
            // 
            this.dtpRegion.Location = new System.Drawing.Point(137, 181);
            this.dtpRegion.Name = "dtpRegion";
            this.dtpRegion.Size = new System.Drawing.Size(200, 20);
            this.dtpRegion.TabIndex = 6;
            // 
            // tbxRapport
            // 
            this.tbxRapport.Location = new System.Drawing.Point(137, 229);
            this.tbxRapport.Name = "tbxRapport";
            this.tbxRapport.Size = new System.Drawing.Size(100, 20);
            this.tbxRapport.TabIndex = 7;
            // 
            // Matricule
            // 
            this.Matricule.AutoSize = true;
            this.Matricule.Location = new System.Drawing.Point(16, 62);
            this.Matricule.Name = "Matricule";
            this.Matricule.Size = new System.Drawing.Size(50, 13);
            this.Matricule.TabIndex = 8;
            this.Matricule.Text = "Matricule";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Date Embauche";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Date affectation region";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre rapport etat 3";
            // 
            // btnpas0
            // 
            this.btnpas0.Location = new System.Drawing.Point(456, 65);
            this.btnpas0.Name = "btnpas0";
            this.btnpas0.Size = new System.Drawing.Size(140, 52);
            this.btnpas0.TabIndex = 14;
            this.btnpas0.Text = "Voir les rapports de visites consultés";
            this.btnpas0.UseVisualStyleBackColor = true;
            this.btnpas0.Click += new System.EventHandler(this.btnpas0_Click);
            // 
            // FrmVisiteurEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 317);
            this.Controls.Add(this.btnpas0);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Matricule);
            this.Controls.Add(this.tbxRapport);
            this.Controls.Add(this.dtpRegion);
            this.Controls.Add(this.dtpEmbauche);
            this.Controls.Add(this.cbxVisiteurs);
            this.Controls.Add(this.tbxPrenom);
            this.Controls.Add(this.tbxNom);
            this.Controls.Add(this.tbxMatricule);
            this.Name = "FrmVisiteurEquipe";
            this.Text = "FrmVisiteurEquipe";
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bsVisiteur;
        private System.Windows.Forms.TextBox tbxMatricule;
        private System.Windows.Forms.TextBox tbxNom;
        private System.Windows.Forms.TextBox tbxPrenom;
        private System.Windows.Forms.ComboBox cbxVisiteurs;
        private System.Windows.Forms.DateTimePicker dtpEmbauche;
        private System.Windows.Forms.DateTimePicker dtpRegion;
        private System.Windows.Forms.TextBox tbxRapport;
        private System.Windows.Forms.Label Matricule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnpas0;
    }
}