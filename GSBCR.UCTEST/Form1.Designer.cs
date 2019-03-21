namespace GSBCR.UCTEST
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
            this.components = new System.ComponentModel.Container();
            this.ucMedicament1 = new GSBCR.UC.UcMedicament();
            this.titre = new System.Windows.Forms.Label();
            this.cbxMedoc = new System.Windows.Forms.ComboBox();
            this.bsMedoc = new System.Windows.Forms.BindingSource(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.ucPraticien1 = new GSBCR.UC.UcPraticien();
            this.cbxPraticien = new System.Windows.Forms.ComboBox();
            this.bsPraticien = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPraticien)).BeginInit();
            this.SuspendLayout();
            // 
            // ucMedicament1
            // 
            this.ucMedicament1.LeMedicament = null;
            this.ucMedicament1.Location = new System.Drawing.Point(113, 40);
            this.ucMedicament1.Name = "ucMedicament1";
            this.ucMedicament1.Size = new System.Drawing.Size(681, 705);
            this.ucMedicament1.TabIndex = 0;
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.Location = new System.Drawing.Point(13, 13);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(277, 24);
            this.titre.TabIndex = 1;
            this.titre.Text = "Consultation Médicament";
            // 
            // cbxMedoc
            // 
            this.cbxMedoc.DataSource = this.bsMedoc;
            this.cbxMedoc.FormattingEnabled = true;
            this.cbxMedoc.Location = new System.Drawing.Point(296, 16);
            this.cbxMedoc.Name = "cbxMedoc";
            this.cbxMedoc.Size = new System.Drawing.Size(121, 21);
            this.cbxMedoc.TabIndex = 2;
            this.cbxMedoc.SelectedIndexChanged += new System.EventHandler(this.cbxMedoc_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(793, 650);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 38);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Quitter";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ucPraticien1
            // 
            this.ucPraticien1.LePraticien = null;
            this.ucPraticien1.Location = new System.Drawing.Point(113, 40);
            this.ucPraticien1.Name = "ucPraticien1";
            this.ucPraticien1.Size = new System.Drawing.Size(654, 623);
            this.ucPraticien1.TabIndex = 4;
            // 
            // cbxPraticien
            // 
            this.cbxPraticien.DataSource = this.bsPraticien;
            this.cbxPraticien.FormattingEnabled = true;
            this.cbxPraticien.Location = new System.Drawing.Point(423, 16);
            this.cbxPraticien.Name = "cbxPraticien";
            this.cbxPraticien.Size = new System.Drawing.Size(121, 21);
            this.cbxPraticien.TabIndex = 5;
            this.cbxPraticien.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Consultation Praticien";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 719);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxPraticien);
            this.Controls.Add(this.ucPraticien1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cbxMedoc);
            this.Controls.Add(this.titre);
            this.Controls.Add(this.ucMedicament1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsMedoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPraticien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UC.UcMedicament ucMedicament1;
        private System.Windows.Forms.Label titre;
        private System.Windows.Forms.ComboBox cbxMedoc;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.BindingSource bsMedoc;
        private UC.UcPraticien ucPraticien1;
        private System.Windows.Forms.ComboBox cbxPraticien;
        private System.Windows.Forms.BindingSource bsPraticien;
        private System.Windows.Forms.Label label1;
    }
}

