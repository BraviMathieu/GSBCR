namespace GSBCR.UI
{
    partial class FrmConsulterMedicament
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
            this.ucMedicament1 = new GSBCR.UC.UcMedicament();
            this.cbxMedicament = new System.Windows.Forms.ComboBox();
            this.bsMedicament = new System.Windows.Forms.BindingSource(this.components);
            this.btn_voirRapport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedicament)).BeginInit();
            this.SuspendLayout();
            // 
            // ucMedicament1
            // 
            this.ucMedicament1.LeMedicament = null;
            this.ucMedicament1.Location = new System.Drawing.Point(66, 37);
            this.ucMedicament1.Name = "ucMedicament1";
            this.ucMedicament1.Size = new System.Drawing.Size(664, 645);
            this.ucMedicament1.TabIndex = 0;
            // 
            // cbxMedicament
            // 
            this.cbxMedicament.FormattingEnabled = true;
            this.cbxMedicament.Location = new System.Drawing.Point(303, 10);
            this.cbxMedicament.Name = "cbxMedicament";
            this.cbxMedicament.Size = new System.Drawing.Size(197, 21);
            this.cbxMedicament.TabIndex = 1;
            this.cbxMedicament.SelectedIndexChanged += new System.EventHandler(this.cbxMedicament_SelectedIndexChanged);
            // 
            // btn_voirRapport
            // 
            this.btn_voirRapport.Location = new System.Drawing.Point(573, 66);
            this.btn_voirRapport.Name = "btn_voirRapport";
            this.btn_voirRapport.Size = new System.Drawing.Size(144, 65);
            this.btn_voirRapport.TabIndex = 5;
            this.btn_voirRapport.Text = "Voir les rapports de visite";
            this.btn_voirRapport.UseVisualStyleBackColor = true;
            this.btn_voirRapport.Visible = false;
            this.btn_voirRapport.Click += new System.EventHandler(this.btn_voirRapport_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(658, 596);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 59);
            this.button1.TabIndex = 6;
            this.button1.Text = "Quitter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmConsulterMedicament
            // 
            this.ClientSize = new System.Drawing.Size(796, 667);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_voirRapport);
            this.Controls.Add(this.cbxMedicament);
            this.Controls.Add(this.ucMedicament1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmConsulterMedicament";
            this.Text = "Consulter un medicament";
            this.Load += new System.EventHandler(this.FrmConsulterMedicament_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsMedicament)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UC.UcMedicament ucMedicament1;
        private System.Windows.Forms.ComboBox cbxMedicament;
        private System.Windows.Forms.BindingSource bsMedicament;
        private System.Windows.Forms.Button btn_voirRapport;
        private System.Windows.Forms.Button button1;
    }
}