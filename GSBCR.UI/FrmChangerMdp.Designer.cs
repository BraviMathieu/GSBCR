namespace GSBCR.UI
{
    partial class FrmChangerMdp
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
            this.txt_ancien = new System.Windows.Forms.TextBox();
            this.txt_nouveau = new System.Windows.Forms.TextBox();
            this.txt_nouveau2 = new System.Windows.Forms.TextBox();
            this.btnAccepter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_ancien
            // 
            this.txt_ancien.Location = new System.Drawing.Point(166, 41);
            this.txt_ancien.Name = "txt_ancien";
            this.txt_ancien.Size = new System.Drawing.Size(141, 20);
            this.txt_ancien.TabIndex = 0;
            this.txt_ancien.UseSystemPasswordChar = true;
            // 
            // txt_nouveau
            // 
            this.txt_nouveau.Location = new System.Drawing.Point(166, 87);
            this.txt_nouveau.Name = "txt_nouveau";
            this.txt_nouveau.Size = new System.Drawing.Size(141, 20);
            this.txt_nouveau.TabIndex = 1;
            this.txt_nouveau.UseSystemPasswordChar = true;
            // 
            // txt_nouveau2
            // 
            this.txt_nouveau2.Location = new System.Drawing.Point(166, 137);
            this.txt_nouveau2.Name = "txt_nouveau2";
            this.txt_nouveau2.Size = new System.Drawing.Size(141, 20);
            this.txt_nouveau2.TabIndex = 2;
            this.txt_nouveau2.UseSystemPasswordChar = true;
            // 
            // btnAccepter
            // 
            this.btnAccepter.Location = new System.Drawing.Point(181, 189);
            this.btnAccepter.Name = "btnAccepter";
            this.btnAccepter.Size = new System.Drawing.Size(75, 23);
            this.btnAccepter.TabIndex = 3;
            this.btnAccepter.Text = "Accepter";
            this.btnAccepter.UseVisualStyleBackColor = true;
            this.btnAccepter.Click += new System.EventHandler(this.btnAccepter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ancien mot de passe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nouveau mot de passe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nouveau mot de passe bis";
            // 
            // FrmChangerMdp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 239);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAccepter);
            this.Controls.Add(this.txt_nouveau2);
            this.Controls.Add(this.txt_nouveau);
            this.Controls.Add(this.txt_ancien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmChangerMdp";
            this.Text = "Changer mon mot de passe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ancien;
        private System.Windows.Forms.TextBox txt_nouveau;
        private System.Windows.Forms.TextBox txt_nouveau2;
        private System.Windows.Forms.Button btnAccepter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}