namespace GSBCR.UI
{
    partial class FrmConsulterRapportConsulte
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
            this.ucRapportValide1 = new GSBCR.UC.UcRapportValide();
            this.SuspendLayout();
            // 
            // ucRapportValide1
            // 
            this.ucRapportValide1.LeRapportVisite = null;
            this.ucRapportValide1.Location = new System.Drawing.Point(12, 71);
            this.ucRapportValide1.Name = "ucRapportValide1";
            this.ucRapportValide1.Size = new System.Drawing.Size(586, 273);
            this.ucRapportValide1.TabIndex = 0;
            // 
            // FrmConsulterRapportConsulte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 356);
            this.Controls.Add(this.ucRapportValide1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmConsulterRapportConsulte";
            this.Text = "Consulter un rapport consulté";
            this.ResumeLayout(false);

        }

        #endregion

        private UC.UcRapportValide ucRapportValide1;
    }
}