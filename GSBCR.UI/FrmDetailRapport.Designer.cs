namespace GSBCR.UI
{
    partial class FrmDetailRapport
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
            this.RAP_NUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAP_DATVISIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAP_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAP_BILAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAP_MOTIF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsDetailRapport = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetailRapport)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RAP_NUM,
            this.RAP_DATVISIT,
            this.RAP_DATE,
            this.RAP_BILAN,
            this.RAP_MOTIF});
            this.dataGridView1.DataSource = this.bsDetailRapport;
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(666, 282);
            this.dataGridView1.TabIndex = 0;
            // 
            // RAP_NUM
            // 
            this.RAP_NUM.DataPropertyName = "RAP_NUM";
            this.RAP_NUM.HeaderText = "Numéro Rapport";
            this.RAP_NUM.Name = "RAP_NUM";
            // 
            // RAP_DATVISIT
            // 
            this.RAP_DATVISIT.DataPropertyName = "RAP_DATVISIT";
            this.RAP_DATVISIT.HeaderText = "Date Visite";
            this.RAP_DATVISIT.Name = "RAP_DATVISIT";
            // 
            // RAP_DATE
            // 
            this.RAP_DATE.DataPropertyName = "RAP_DATE";
            this.RAP_DATE.HeaderText = "Date Rapport";
            this.RAP_DATE.Name = "RAP_DATE";
            // 
            // RAP_BILAN
            // 
            this.RAP_BILAN.DataPropertyName = "RAP_BILAN";
            this.RAP_BILAN.HeaderText = "Bilan";
            this.RAP_BILAN.Name = "RAP_BILAN";
            // 
            // RAP_MOTIF
            // 
            this.RAP_MOTIF.DataPropertyName = "RAP_MOTIF";
            this.RAP_MOTIF.HeaderText = "Motif";
            this.RAP_MOTIF.Name = "RAP_MOTIF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rapport de visite";
            // 
            // FrmDetailRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 360);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmDetailRapport";
            this.Text = "FrmDetailRapport";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetailRapport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bsDetailRapport;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAP_NUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAP_DATVISIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAP_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAP_BILAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAP_MOTIF;
    }
}