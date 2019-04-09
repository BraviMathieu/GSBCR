namespace GSBCR.UI
{
    partial class FrmModifRapport
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
            this.bsRapports = new System.Windows.Forms.BindingSource(this.components);
            this.cbxRapport = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoirPatricien = new System.Windows.Forms.Button();
            this.txtMatricule = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVoirMed2 = new System.Windows.Forms.Button();
            this.btnVoirMed1 = new System.Windows.Forms.Button();
            this.txtMed2 = new System.Windows.Forms.TextBox();
            this.txtMed1 = new System.Windows.Forms.TextBox();
            this.cbxMed2 = new System.Windows.Forms.ComboBox();
            this.cbxMed1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCodeMotif = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.chbDefinitif = new System.Windows.Forms.CheckBox();
            this.txtAutre = new System.Windows.Forms.TextBox();
            this.nupCoef = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBilan = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxMotif = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxNomPraticien = new System.Windows.Forms.ComboBox();
            this.txtNumPraticien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtDateVisite = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bsPraticien = new System.Windows.Forms.BindingSource(this.components);
            this.bsMotif = new System.Windows.Forms.BindingSource(this.components);
            this.bsMed1 = new System.Windows.Forms.BindingSource(this.components);
            this.bsMed2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsRapports)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCoef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPraticien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMotif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMed1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMed2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxRapport
            // 
            this.cbxRapport.FormattingEnabled = true;
            this.cbxRapport.Location = new System.Drawing.Point(223, 21);
            this.cbxRapport.Name = "cbxRapport";
            this.cbxRapport.Size = new System.Drawing.Size(121, 21);
            this.cbxRapport.TabIndex = 0;
            this.cbxRapport.SelectedIndexChanged += new System.EventHandler(this.cbxRapport_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rapports en cours";
            // 
            // btnVoirPatricien
            // 
            this.txtBoxNumRapport.Location = new System.Drawing.Point(105, 73);
            this.txtBoxNumRapport.Name = "txtBoxNumRapport";
            this.txtBoxNumRapport.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNumRapport.TabIndex = 2;
            // 
            // txtMatricule
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "numero de rapport";
            // 
            // groupBox1
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "code practicien";
            // 
            // btnVoirMed2
            // 
            this.txtBoxCodePra.Location = new System.Drawing.Point(105, 112);
            this.txtBoxCodePra.Name = "txtBoxCodePra";
            this.txtBoxCodePra.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCodePra.TabIndex = 5;
            // 
            // btnVoirMed1
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "date";
            // 
            // txtBilan
            // 
            this.txtBilan.Location = new System.Drawing.Point(246, 212);
            this.txtBilan.Name = "txtBilan";
            this.txtBilan.Size = new System.Drawing.Size(308, 101);
            this.txtBilan.TabIndex = 57;
            this.txtBilan.Text = "";
            // 
            // label6
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "motif visite";
            // 
            // cbxMotif
            // 
            this.cbxMotif.FormattingEnabled = true;
            this.cbxMotif.Location = new System.Drawing.Point(246, 155);
            this.cbxMotif.Name = "cbxMotif";
            this.cbxMotif.Size = new System.Drawing.Size(121, 21);
            this.cbxMotif.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Motif";
            // 
            // cbxNomPraticien
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(299, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "si autre";
            // 
            // txtNumPraticien
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "etat rapport";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Praticien visité";
            // 
            // dtDateVisite
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(299, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Code Medicament";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "date Visite";
            // 
            // txtNum
            // 
            this.checkBoxSaisieDef.AutoSize = true;
            this.checkBoxSaisieDef.Location = new System.Drawing.Point(200, 340);
            this.checkBoxSaisieDef.Name = "checkBoxSaisieDef";
            this.checkBoxSaisieDef.Size = new System.Drawing.Size(97, 17);
            this.checkBoxSaisieDef.TabIndex = 16;
            this.checkBoxSaisieDef.Text = "saisie définitive";
            this.checkBoxSaisieDef.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "numéro de rapport";
            // 
            // FrmModifRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 552);
            this.Controls.Add(this.btnVoirPatricien);
            this.Controls.Add(this.txtMatricule);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
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
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxRapport);
            this.Name = "FrmModifRapport";
            this.Text = "modification rapport de visite";
            ((System.ComponentModel.ISupportInitialize)(this.bsRapports)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCoef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPraticien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMotif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMed1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMed2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bsRapports;
        private System.Windows.Forms.ComboBox cbxRapport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoirPatricien;
        private System.Windows.Forms.TextBox txtMatricule;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVoirMed2;
        private System.Windows.Forms.Button btnVoirMed1;
        private System.Windows.Forms.TextBox txtMed2;
        private System.Windows.Forms.TextBox txtMed1;
        private System.Windows.Forms.ComboBox cbxMed2;
        private System.Windows.Forms.ComboBox cbxMed1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCodeMotif;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.CheckBox chbDefinitif;
        private System.Windows.Forms.TextBox txtAutre;
        private System.Windows.Forms.NumericUpDown nupCoef;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtBilan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxMotif;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxNomPraticien;
        private System.Windows.Forms.TextBox txtNumPraticien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtDateVisite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bsPraticien;
        private System.Windows.Forms.BindingSource bsMotif;
        private System.Windows.Forms.BindingSource bsMed1;
        private System.Windows.Forms.BindingSource bsMed2;
    }
}