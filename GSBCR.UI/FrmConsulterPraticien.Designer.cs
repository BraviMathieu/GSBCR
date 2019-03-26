namespace GSBCR.UI
{
    partial class FrmConsulterPraticien
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
            this.ucPraticien1 = new GSBCR.UC.UcPraticien();
            this.cbxPraticien = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bsPraticien = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsPraticien)).BeginInit();
            this.SuspendLayout();
            // 
            // ucPraticien1
            // 
            this.ucPraticien1.LePraticien = null;
            this.ucPraticien1.Location = new System.Drawing.Point(18, 49);
            this.ucPraticien1.Name = "ucPraticien1";
            this.ucPraticien1.Size = new System.Drawing.Size(714, 464);
            this.ucPraticien1.TabIndex = 0;
            // 
            // cbxPraticien
            // 
            this.cbxPraticien.FormattingEnabled = true;
            this.cbxPraticien.Location = new System.Drawing.Point(289, 22);
            this.cbxPraticien.Name = "cbxPraticien";
            this.cbxPraticien.Size = new System.Drawing.Size(212, 21);
            this.cbxPraticien.TabIndex = 1;
            this.cbxPraticien.SelectedIndexChanged += new System.EventHandler(this.cbxPraticien_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Praticien";
            // 
            // FrmConsulterPraticien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 535);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxPraticien);
            this.Controls.Add(this.ucPraticien1);
            this.Name = "FrmConsulterPraticien";
            this.Text = "FrmConsulterPraticien";
            this.Load += new System.EventHandler(this.FrmConsulterPraticien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsPraticien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UC.UcPraticien ucPraticien1 = null;
        private System.Windows.Forms.ComboBox cbxPraticien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bsPraticien;
    }
}