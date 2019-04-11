using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSBCR.modele;
using GSBCR.BLL;

namespace GSBCR.UI
{
    public partial class FrmModifierInfo : Form
    {
        private string matricule;
        private string adr;
        private string CP;
        private string ville;
        public FrmModifierInfo(string mat)
        {
            InitializeComponent();
            matricule = mat;
            bsInfo.DataSource = Manager.ChargerVisiteurById(matricule);
            ucModifierInfo1.LeVisiteur = (VISITEUR)bsInfo.DataSource;
            adr = ucModifierInfo1.txtAdr.Text;
            CP = ucModifierInfo1.txtCP.Text;
            ville = ucModifierInfo1.txtVille.Text;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            string new_adr;
            string new_CP;
            string new_ville;
            new_adr = ucModifierInfo1.txtAdr.Text;
            new_CP = ucModifierInfo1.txtCP.Text;
            new_ville = ucModifierInfo1.txtVille.Text;
            if (ucModifierInfo1.txtCP.Text.Length < 5)
            {
                MessageBox.Show("Le code postal doit contenir 5 chiffres.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Manager.UpdateVisiteur(matricule, adr, CP, ville, new_adr, new_CP, new_ville);
                this.Close();
            }
        }
    }
}
