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
            this.components = new System.ComponentModel.Container();
            this.ucRapportValide1 = new GSBCR.UC.UcRapportValide();
            this.cbxRapport = new System.Windows.Forms.ComboBox();
            this.bsRapport = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsRapport)).BeginInit();
            this.SuspendLayout();
            // 
            // ucRapportValide1
            // 
            this.ucRapportValide1.LeRapportVisite = null;
            this.ucRapportValide1.Location = new System.Drawing.Point(28, 71);
            this.ucRapportValide1.Name = "ucRapportValide1";
            this.ucRapportValide1.Size = new System.Drawing.Size(586, 273);
            this.ucRapportValide1.TabIndex = 0;
            // 
            // cbxRapport
            // 
            this.cbxRapport.FormattingEnabled = true;
            this.cbxRapport.Location = new System.Drawing.Point(269, 12);
            this.cbxRapport.Name = "cbxRapport";
            this.cbxRapport.Size = new System.Drawing.Size(121, 21);
            this.cbxRapport.TabIndex = 1;
            this.cbxRapport.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FrmConsulterRapportConsulte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 356);
            this.Controls.Add(this.cbxRapport);
            this.Controls.Add(this.ucRapportValide1);
            this.Name = "FrmConsulterRapportConsulte";
            this.Text = "FrmConsulterRapportConsulte";
            ((System.ComponentModel.ISupportInitialize)(this.bsRapport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UC.UcRapportValide ucRapportValide1;
        private System.Windows.Forms.ComboBox cbxRapport;
        private System.Windows.Forms.BindingSource bsRapport;
    }
}