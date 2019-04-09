namespace GSBCR.UI
{
    partial class FrmUnMedicamment
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
            this.btnFermer = new System.Windows.Forms.Button();
            this.bsMed = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsMed)).BeginInit();
            this.SuspendLayout();
            // 
            // ucMedicament1
            // 
            this.ucMedicament1.LeMedicament = null;
            this.ucMedicament1.Location = new System.Drawing.Point(0, -1);
            this.ucMedicament1.Name = "ucMedicament1";
            this.ucMedicament1.Size = new System.Drawing.Size(587, 645);
            this.ucMedicament1.TabIndex = 0;
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(454, 598);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(113, 23);
            this.btnFermer.TabIndex = 1;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // FrmUnMedicamment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 633);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.ucMedicament1);
            this.Name = "FrmUnMedicamment";
            this.Text = "FrmUnMedicamment";
            ((System.ComponentModel.ISupportInitialize)(this.bsMed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UC.UcMedicament ucMedicament1;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.BindingSource bsMed;
    }
}