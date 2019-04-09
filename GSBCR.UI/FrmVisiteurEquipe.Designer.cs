namespace GSBCR.UI
{
    partial class FrmVisiteurEquipe
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bsVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.VIS_MAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VIS_NOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VIS_PRENOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VIS_DATEEMBAUCHE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JJMMAA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NBRAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VIS_MAT,
            this.VIS_NOM,
            this.VIS_PRENOM,
            this.VIS_DATEEMBAUCHE,
            this.JJMMAA,
            this.NBRAP});
            this.dataGridView1.DataSource = this.bsVisiteur;
            this.dataGridView1.Location = new System.Drawing.Point(12, 277);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(651, 190);
            this.dataGridView1.TabIndex = 0;
            // 
            // VIS_MAT
            // 
            this.VIS_MAT.DataPropertyName = "VIS_MAT";
            this.VIS_MAT.HeaderText = "VIS_MAT";
            this.VIS_MAT.Name = "VIS_MAT";
            // 
            // VIS_NOM
            // 
            this.VIS_NOM.DataPropertyName = "VIS_NOM";
            this.VIS_NOM.HeaderText = "VIS_NOM";
            this.VIS_NOM.Name = "VIS_NOM";
            // 
            // VIS_PRENOM
            // 
            this.VIS_PRENOM.DataPropertyName = "VIS_PRENOM";
            this.VIS_PRENOM.HeaderText = "VIS_PRENOM";
            this.VIS_PRENOM.Name = "VIS_PRENOM";
            // 
            // VIS_DATEEMBAUCHE
            // 
            this.VIS_DATEEMBAUCHE.DataPropertyName = "VIS_DATEEMBAUCHE";
            this.VIS_DATEEMBAUCHE.HeaderText = "VIS_DATEEMBAUCHE";
            this.VIS_DATEEMBAUCHE.Name = "VIS_DATEEMBAUCHE";
            // 
            // JJMMAA
            // 
            this.JJMMAA.DataPropertyName = "JJMMAA";
            this.JJMMAA.HeaderText = "JJMMAA";
            this.JJMMAA.Name = "JJMMAA";
            // 
            // NBRAP
            // 
            this.NBRAP.HeaderText = "NBRAP";
            this.NBRAP.Name = "NBRAP";
            // 
            // FrmVisiteurEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 479);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmVisiteurEquipe";
            this.Text = "FrmVisiteurEquipe";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bsVisiteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn VIS_MAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn VIS_NOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn VIS_PRENOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn VIS_DATEEMBAUCHE;
        private System.Windows.Forms.DataGridViewTextBoxColumn JJMMAA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NBRAP;
    }
}