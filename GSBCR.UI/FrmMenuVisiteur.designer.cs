namespace GSBCR.UI
{
    partial class FrmMenuVisiteur
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnVoirRapVal = new System.Windows.Forms.Button();
            this.btnVoirNouvRap = new System.Windows.Forms.Button();
            this.btnVoirVisEq = new System.Windows.Forms.Button();
            this.btnGererVisDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion rapports de visite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // btnNouveau
            // 
            this.btnNouveau.Location = new System.Drawing.Point(154, 122);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(200, 23);
            this.btnNouveau.TabIndex = 2;
            this.btnNouveau.Text = "Nouveau rapport de visite";
            this.btnNouveau.UseVisualStyleBackColor = true;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(154, 333);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(200, 23);
            this.btnQuitter.TabIndex = 6;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(154, 151);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(200, 23);
            this.btnModifier.TabIndex = 7;
            this.btnModifier.Text = "Modifier un rapport de visite";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnVoirRapVal
            // 
            this.btnVoirRapVal.Location = new System.Drawing.Point(154, 180);
            this.btnVoirRapVal.Name = "btnVoirRapVal";
            this.btnVoirRapVal.Size = new System.Drawing.Size(200, 23);
            this.btnVoirRapVal.TabIndex = 8;
            this.btnVoirRapVal.Text = "Voir ses rapports validés";
            this.btnVoirRapVal.UseVisualStyleBackColor = true;
            // 
            // btnVoirNouvRap
            // 
            this.btnVoirNouvRap.Location = new System.Drawing.Point(154, 209);
            this.btnVoirNouvRap.Name = "btnVoirNouvRap";
            this.btnVoirNouvRap.Size = new System.Drawing.Size(200, 23);
            this.btnVoirNouvRap.TabIndex = 9;
            this.btnVoirNouvRap.Text = "Voir les nouveaux rapports de visite";
            this.btnVoirNouvRap.UseVisualStyleBackColor = true;
            // 
            // btnVoirVisEq
            // 
            this.btnVoirVisEq.Location = new System.Drawing.Point(154, 238);
            this.btnVoirVisEq.Name = "btnVoirVisEq";
            this.btnVoirVisEq.Size = new System.Drawing.Size(200, 23);
            this.btnVoirVisEq.TabIndex = 10;
            this.btnVoirVisEq.Text = "Voir les visiteurs de son équipe";
            this.btnVoirVisEq.UseVisualStyleBackColor = true;
            // 
            // btnGererVisDel
            // 
            this.btnGererVisDel.Location = new System.Drawing.Point(154, 267);
            this.btnGererVisDel.Name = "btnGererVisDel";
            this.btnGererVisDel.Size = new System.Drawing.Size(200, 23);
            this.btnGererVisDel.TabIndex = 11;
            this.btnGererVisDel.Text = "Gérer les visiteurs et les délégués";
            this.btnGererVisDel.UseVisualStyleBackColor = true;
            // 
            // FrmMenuVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 411);
            this.Controls.Add(this.btnGererVisDel);
            this.Controls.Add(this.btnVoirVisEq);
            this.Controls.Add(this.btnVoirNouvRap);
            this.Controls.Add(this.btnVoirRapVal);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNouveau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmMenuVisiteur";
            this.Load += new System.EventHandler(this.FrmMenuVisiteur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnVoirRapVal;
        private System.Windows.Forms.Button btnVoirNouvRap;
        private System.Windows.Forms.Button btnVoirVisEq;
        private System.Windows.Forms.Button btnGererVisDel;
    }
}