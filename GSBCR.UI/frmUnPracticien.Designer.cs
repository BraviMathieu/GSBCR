namespace GSBCR.UI
{
    partial class FrmUnPracticien
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
            this.bsPrac = new System.Windows.Forms.BindingSource(this.components);
            this.ucPraticien1 = new GSBCR.UC.UcPraticien();
            this.btnRetour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsPrac)).BeginInit();
            this.SuspendLayout();
            // 
            // ucPraticien1
            // 
            this.ucPraticien1.LePraticien = null;
            this.ucPraticien1.Location = new System.Drawing.Point(-38, -18);
            this.ucPraticien1.Name = "ucPraticien1";
            this.ucPraticien1.Size = new System.Drawing.Size(582, 460);
            this.ucPraticien1.TabIndex = 0;
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(441, 384);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 1;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // FrmUnPracticien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 431);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.ucPraticien1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmUnPracticien";
            this.Text = "Consulter un praticien";
            ((System.ComponentModel.ISupportInitialize)(this.bsPrac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UC.UcPraticien ucPraticien1;
        private System.Windows.Forms.BindingSource bsPrac;
        private System.Windows.Forms.Button btnRetour;
    }
}