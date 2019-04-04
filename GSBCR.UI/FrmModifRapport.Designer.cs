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
            this.cbxRapport = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxNumRapport = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxCodePra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateRapport = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxMotif = new System.Windows.Forms.ComboBox();
            this.txtBoxAutreMotif = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxEtatRapport = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBoxSaisieDef = new System.Windows.Forms.CheckBox();
            this.btxConfirm = new System.Windows.Forms.Button();
            this.bsRapports = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsRapports)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxRapport
            // 
            this.cbxRapport.FormattingEnabled = true;
            this.cbxRapport.Location = new System.Drawing.Point(255, 25);
            this.cbxRapport.Name = "cbxRapport";
            this.cbxRapport.Size = new System.Drawing.Size(121, 21);
            this.cbxRapport.TabIndex = 0;
            this.cbxRapport.SelectedIndexChanged += new System.EventHandler(this.cbxRapport_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rapports en cours";
            // 
            // txtBoxNumRapport
            // 
            this.txtBoxNumRapport.Location = new System.Drawing.Point(149, 77);
            this.txtBoxNumRapport.Name = "txtBoxNumRapport";
            this.txtBoxNumRapport.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNumRapport.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero de rapport";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Code practicien";
            // 
            // txtBoxCodePra
            // 
            this.txtBoxCodePra.Location = new System.Drawing.Point(124, 113);
            this.txtBoxCodePra.Name = "txtBoxCodePra";
            this.txtBoxCodePra.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCodePra.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date";
            // 
            // dateRapport
            // 
            this.dateRapport.Location = new System.Drawing.Point(105, 151);
            this.dateRapport.Name = "dateRapport";
            this.dateRapport.Size = new System.Drawing.Size(200, 20);
            this.dateRapport.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Motif visite";
            // 
            // cbxMotif
            // 
            this.cbxMotif.FormattingEnabled = true;
            this.cbxMotif.Location = new System.Drawing.Point(105, 193);
            this.cbxMotif.Name = "cbxMotif";
            this.cbxMotif.Size = new System.Drawing.Size(121, 21);
            this.cbxMotif.TabIndex = 9;
            // 
            // txtBoxAutreMotif
            // 
            this.txtBoxAutreMotif.Location = new System.Drawing.Point(374, 193);
            this.txtBoxAutreMotif.Name = "txtBoxAutreMotif";
            this.txtBoxAutreMotif.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAutreMotif.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(301, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "si autre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Etat rapport";
            // 
            // txtBoxEtatRapport
            // 
            this.txtBoxEtatRapport.Location = new System.Drawing.Point(105, 260);
            this.txtBoxEtatRapport.Name = "txtBoxEtatRapport";
            this.txtBoxEtatRapport.Size = new System.Drawing.Size(100, 20);
            this.txtBoxEtatRapport.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(263, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Code Medicament";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(398, 260);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 163);
            this.textBox1.TabIndex = 15;
            // 
            // checkBoxSaisieDef
            // 
            this.checkBoxSaisieDef.AutoSize = true;
            this.checkBoxSaisieDef.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSaisieDef.Location = new System.Drawing.Point(208, 361);
            this.checkBoxSaisieDef.Name = "checkBoxSaisieDef";
            this.checkBoxSaisieDef.Size = new System.Drawing.Size(125, 22);
            this.checkBoxSaisieDef.TabIndex = 16;
            this.checkBoxSaisieDef.Text = "saisie définitive";
            this.checkBoxSaisieDef.UseVisualStyleBackColor = true;
            // 
            // btxConfirm
            // 
            this.btxConfirm.Location = new System.Drawing.Point(222, 413);
            this.btxConfirm.Name = "btxConfirm";
            this.btxConfirm.Size = new System.Drawing.Size(75, 23);
            this.btxConfirm.TabIndex = 17;
            this.btxConfirm.Text = "confirmer";
            this.btxConfirm.UseVisualStyleBackColor = true;
            // 
            // FrmModifRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 464);
            this.Controls.Add(this.btxConfirm);
            this.Controls.Add(this.checkBoxSaisieDef);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBoxEtatRapport);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxAutreMotif);
            this.Controls.Add(this.cbxMotif);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateRapport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxCodePra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxNumRapport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxRapport);
            this.Name = "FrmModifRapport";
            this.Text = "modification rapport de visite";
            ((System.ComponentModel.ISupportInitialize)(this.bsRapports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxRapport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxNumRapport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxCodePra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateRapport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxMotif;
        private System.Windows.Forms.TextBox txtBoxAutreMotif;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxEtatRapport;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBoxSaisieDef;
        private System.Windows.Forms.Button btxConfirm;
        private System.Windows.Forms.BindingSource bsRapports;
    }
}