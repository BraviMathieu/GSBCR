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
            this.cbxPraticien = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bsPraticien = new System.Windows.Forms.BindingSource(this.components);
            this.btn_voirRapport = new System.Windows.Forms.Button();
            this.tbxType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxLieu = new System.Windows.Forms.TextBox();
            this.panelPraticien = new System.Windows.Forms.Panel();
            this.ucPraticien1 = new GSBCR.UC.UcPraticien();
            ((System.ComponentModel.ISupportInitialize)(this.bsPraticien)).BeginInit();
            this.panelPraticien.SuspendLayout();
            this.SuspendLayout();
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
            // btn_voirRapport
            // 
            this.btn_voirRapport.Location = new System.Drawing.Point(561, 39);
            this.btn_voirRapport.Name = "btn_voirRapport";
            this.btn_voirRapport.Size = new System.Drawing.Size(144, 65);
            this.btn_voirRapport.TabIndex = 4;
            this.btn_voirRapport.Text = "Voir les rapports de visite";
            this.btn_voirRapport.UseVisualStyleBackColor = true;
            this.btn_voirRapport.Visible = false;
            this.btn_voirRapport.Click += new System.EventHandler(this.btn_voirRapport_Click);
            // 
            // tbxType
            // 
            this.tbxType.Location = new System.Drawing.Point(39, 7);
            this.tbxType.Name = "tbxType";
            this.tbxType.Size = new System.Drawing.Size(144, 20);
            this.tbxType.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Lieu";
            // 
            // tbxLieu
            // 
            this.tbxLieu.Location = new System.Drawing.Point(39, 43);
            this.tbxLieu.Name = "tbxLieu";
            this.tbxLieu.Size = new System.Drawing.Size(144, 20);
            this.tbxLieu.TabIndex = 7;
            // 
            // panelPraticien
            // 
            this.panelPraticien.Controls.Add(this.tbxType);
            this.panelPraticien.Controls.Add(this.label2);
            this.panelPraticien.Controls.Add(this.label3);
            this.panelPraticien.Controls.Add(this.tbxLieu);
            this.panelPraticien.Location = new System.Drawing.Point(522, 120);
            this.panelPraticien.Name = "panelPraticien";
            this.panelPraticien.Size = new System.Drawing.Size(200, 100);
            this.panelPraticien.TabIndex = 9;
            this.panelPraticien.Visible = false;
            // 
            // ucPraticien1
            // 
            this.ucPraticien1.LePraticien = null;
            this.ucPraticien1.Location = new System.Drawing.Point(18, 49);
            this.ucPraticien1.Name = "ucPraticien1";
            this.ucPraticien1.Size = new System.Drawing.Size(714, 464);
            this.ucPraticien1.TabIndex = 3;
            // 
            // FrmConsulterPraticien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 535);
            this.Controls.Add(this.panelPraticien);
            this.Controls.Add(this.btn_voirRapport);
            this.Controls.Add(this.ucPraticien1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxPraticien);
            this.Name = "FrmConsulterPraticien";
            this.Text = "FrmConsulterPraticien";
            this.Load += new System.EventHandler(this.FrmConsulterPraticien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsPraticien)).EndInit();
            this.panelPraticien.ResumeLayout(false);
            this.panelPraticien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxPraticien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bsPraticien;
        private UC.UcPraticien ucPraticien1;
        private System.Windows.Forms.Button btn_voirRapport;
        private System.Windows.Forms.TextBox tbxType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxLieu;
        private System.Windows.Forms.Panel panelPraticien;
    }
}