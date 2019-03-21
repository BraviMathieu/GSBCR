namespace GSBCR.UI
{
    partial class FrmSaisir
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
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtDateVisite = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumPraticien = new System.Windows.Forms.TextBox();
            this.cbxNomPraticien = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxMotif = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBilan = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nupCoef = new System.Windows.Forms.NumericUpDown();
            this.txtAutre = new System.Windows.Forms.TextBox();
            this.chbDefinitif = new System.Windows.Forms.CheckBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.txtCodeMotif = new System.Windows.Forms.TextBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMed2 = new System.Windows.Forms.TextBox();
            this.txtMed1 = new System.Windows.Forms.TextBox();
            this.cbxMed2 = new System.Windows.Forms.ComboBox();
            this.cbxMed1 = new System.Windows.Forms.ComboBox();
            this.txtMatricule = new System.Windows.Forms.TextBox();
            this.btnVoirPatricien = new System.Windows.Forms.Button();
            this.btnVoirMed1 = new System.Windows.Forms.Button();
            this.btnVoirMed2 = new System.Windows.Forms.Button();
            this.bsPraticien = new System.Windows.Forms.BindingSource(this.components);
            this.bsMotif = new System.Windows.Forms.BindingSource(this.components);
            this.bsMed1 = new System.Windows.Forms.BindingSource(this.components);
            this.bsMed2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nupCoef)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPraticien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMotif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMed1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMed2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "numéro de rapport";
            // 
            // txtNum
            // 
            this.txtNum.Enabled = false;
            this.txtNum.Location = new System.Drawing.Point(253, 64);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 1;
            this.txtNum.TabStop = false;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.CausesValidation = false;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(249, 22);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(160, 20);
            this.lblTitre.TabIndex = 2;
            this.lblTitre.Text = "Saisie d\'un rapport";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "date Visite";
            // 
            // dtDateVisite
            // 
            this.dtDateVisite.Location = new System.Drawing.Point(134, 90);
            this.dtDateVisite.Name = "dtDateVisite";
            this.dtDateVisite.Size = new System.Drawing.Size(200, 20);
            this.dtDateVisite.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Praticien visité";
            // 
            // txtNumPraticien
            // 
            this.txtNumPraticien.Location = new System.Drawing.Point(282, 117);
            this.txtNumPraticien.Name = "txtNumPraticien";
            this.txtNumPraticien.Size = new System.Drawing.Size(100, 20);
            this.txtNumPraticien.TabIndex = 6;
            this.txtNumPraticien.TabStop = false;
            // 
            // cbxNomPraticien
            // 
            this.cbxNomPraticien.FormattingEnabled = true;
            this.cbxNomPraticien.Location = new System.Drawing.Point(134, 116);
            this.cbxNomPraticien.Name = "cbxNomPraticien";
            this.cbxNomPraticien.Size = new System.Drawing.Size(121, 21);
            this.cbxNomPraticien.TabIndex = 7;
            this.cbxNomPraticien.SelectedIndexChanged += new System.EventHandler(this.cbxNomPraticien_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Motif";
            // 
            // cbxMotif
            // 
            this.cbxMotif.FormattingEnabled = true;
            this.cbxMotif.Location = new System.Drawing.Point(134, 143);
            this.cbxMotif.Name = "cbxMotif";
            this.cbxMotif.Size = new System.Drawing.Size(121, 21);
            this.cbxMotif.TabIndex = 9;
            this.cbxMotif.SelectedIndexChanged += new System.EventHandler(this.cbxMotif_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Bilan";
            // 
            // txtBilan
            // 
            this.txtBilan.Location = new System.Drawing.Point(134, 200);
            this.txtBilan.Name = "txtBilan";
            this.txtBilan.Size = new System.Drawing.Size(308, 101);
            this.txtBilan.TabIndex = 11;
            this.txtBilan.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "coef. confiance";
            // 
            // nupCoef
            // 
            this.nupCoef.Location = new System.Drawing.Point(134, 170);
            this.nupCoef.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nupCoef.Name = "nupCoef";
            this.nupCoef.Size = new System.Drawing.Size(76, 20);
            this.nupCoef.TabIndex = 13;
            // 
            // txtAutre
            // 
            this.txtAutre.Location = new System.Drawing.Point(470, 148);
            this.txtAutre.Name = "txtAutre";
            this.txtAutre.Size = new System.Drawing.Size(100, 20);
            this.txtAutre.TabIndex = 14;
            // 
            // chbDefinitif
            // 
            this.chbDefinitif.AutoSize = true;
            this.chbDefinitif.Location = new System.Drawing.Point(22, 455);
            this.chbDefinitif.Name = "chbDefinitif";
            this.chbDefinitif.Size = new System.Drawing.Size(99, 17);
            this.chbDefinitif.TabIndex = 16;
            this.chbDefinitif.Text = "Saisie définitive";
            this.chbDefinitif.UseVisualStyleBackColor = true;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(367, 492);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 17;
            this.btnValider.Text = "Enregistrer";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // txtCodeMotif
            // 
            this.txtCodeMotif.Location = new System.Drawing.Point(282, 146);
            this.txtCodeMotif.Name = "txtCodeMotif";
            this.txtCodeMotif.Size = new System.Drawing.Size(100, 20);
            this.txtCodeMotif.TabIndex = 18;
            this.txtCodeMotif.TabStop = false;
            // 
            // btnQuitter
            // 
            this.btnQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuitter.Location = new System.Drawing.Point(470, 492);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 20;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(396, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Autre Motif";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVoirMed2);
            this.groupBox1.Controls.Add(this.btnVoirMed1);
            this.groupBox1.Controls.Add(this.txtMed2);
            this.groupBox1.Controls.Add(this.txtMed1);
            this.groupBox1.Controls.Add(this.cbxMed2);
            this.groupBox1.Controls.Add(this.cbxMed1);
            this.groupBox1.Location = new System.Drawing.Point(15, 327);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 100);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Médicaments présentés";
            // 
            // txtMed2
            // 
            this.txtMed2.Location = new System.Drawing.Point(153, 52);
            this.txtMed2.Name = "txtMed2";
            this.txtMed2.Size = new System.Drawing.Size(100, 20);
            this.txtMed2.TabIndex = 3;
            this.txtMed2.TabStop = false;
            // 
            // txtMed1
            // 
            this.txtMed1.Location = new System.Drawing.Point(153, 20);
            this.txtMed1.Name = "txtMed1";
            this.txtMed1.Size = new System.Drawing.Size(100, 20);
            this.txtMed1.TabIndex = 2;
            this.txtMed1.TabStop = false;
            // 
            // cbxMed2
            // 
            this.cbxMed2.FormattingEnabled = true;
            this.cbxMed2.Location = new System.Drawing.Point(6, 52);
            this.cbxMed2.Name = "cbxMed2";
            this.cbxMed2.Size = new System.Drawing.Size(121, 21);
            this.cbxMed2.TabIndex = 1;
            this.cbxMed2.SelectedIndexChanged += new System.EventHandler(this.cbxMed2_SelectedIndexChanged);
            // 
            // cbxMed1
            // 
            this.cbxMed1.FormattingEnabled = true;
            this.cbxMed1.Location = new System.Drawing.Point(6, 19);
            this.cbxMed1.Name = "cbxMed1";
            this.cbxMed1.Size = new System.Drawing.Size(121, 21);
            this.cbxMed1.TabIndex = 0;
            this.cbxMed1.SelectedIndexChanged += new System.EventHandler(this.cbxMed1_SelectedIndexChanged);
            // 
            // txtMatricule
            // 
            this.txtMatricule.Enabled = false;
            this.txtMatricule.Location = new System.Drawing.Point(134, 64);
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.Size = new System.Drawing.Size(100, 20);
            this.txtMatricule.TabIndex = 23;
            this.txtMatricule.TabStop = false;
            // 
            // btnVoirPatricien
            // 
            this.btnVoirPatricien.Location = new System.Drawing.Point(399, 117);
            this.btnVoirPatricien.Name = "btnVoirPatricien";
            this.btnVoirPatricien.Size = new System.Drawing.Size(99, 23);
            this.btnVoirPatricien.TabIndex = 24;
            this.btnVoirPatricien.Text = "voir le praticien";
            this.btnVoirPatricien.UseVisualStyleBackColor = true;
            // 
            // btnVoirMed1
            // 
            this.btnVoirMed1.Location = new System.Drawing.Point(267, 17);
            this.btnVoirMed1.Name = "btnVoirMed1";
            this.btnVoirMed1.Size = new System.Drawing.Size(121, 23);
            this.btnVoirMed1.TabIndex = 4;
            this.btnVoirMed1.Text = "voir le médicament";
            this.btnVoirMed1.UseVisualStyleBackColor = true;
            this.btnVoirMed1.Click += new System.EventHandler(this.btnVoirmed1_Click);
            // 
            // btnVoirMed2
            // 
            this.btnVoirMed2.Location = new System.Drawing.Point(267, 49);
            this.btnVoirMed2.Name = "btnVoirMed2";
            this.btnVoirMed2.Size = new System.Drawing.Size(121, 23);
            this.btnVoirMed2.TabIndex = 5;
            this.btnVoirMed2.Text = "voir le médicament";
            this.btnVoirMed2.UseVisualStyleBackColor = true;
            this.btnVoirMed2.Click += new System.EventHandler(this.btnVoirMed2_Click);
            // 
            // FrmSaisir
            // 
            this.AcceptButton = this.btnValider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnQuitter;
            this.ClientSize = new System.Drawing.Size(653, 586);
            this.Controls.Add(this.btnVoirPatricien);
            this.Controls.Add(this.txtMatricule);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.txtCodeMotif);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.chbDefinitif);
            this.Controls.Add(this.txtAutre);
            this.Controls.Add(this.nupCoef);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBilan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxMotif);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxNomPraticien);
            this.Controls.Add(this.txtNumPraticien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtDateVisite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label1);
            this.Name = "FrmSaisir";
            this.Text = "FrmSaisir";
            this.Load += new System.EventHandler(this.FrmSaisir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupCoef)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPraticien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMotif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMed1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMed2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtDateVisite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumPraticien;
        private System.Windows.Forms.ComboBox cbxNomPraticien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxMotif;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtBilan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nupCoef;
        private System.Windows.Forms.TextBox txtAutre;
        private System.Windows.Forms.CheckBox chbDefinitif;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.BindingSource bsPraticien;
        private System.Windows.Forms.BindingSource bsMotif;
        private System.Windows.Forms.TextBox txtCodeMotif;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMed2;
        private System.Windows.Forms.TextBox txtMed1;
        private System.Windows.Forms.ComboBox cbxMed2;
        private System.Windows.Forms.ComboBox cbxMed1;
        private System.Windows.Forms.BindingSource bsMed1;
        private System.Windows.Forms.BindingSource bsMed2;
        private System.Windows.Forms.TextBox txtMatricule;
        private System.Windows.Forms.Button btnVoirMed2;
        private System.Windows.Forms.Button btnVoirMed1;
        private System.Windows.Forms.Button btnVoirPatricien;
    }
}