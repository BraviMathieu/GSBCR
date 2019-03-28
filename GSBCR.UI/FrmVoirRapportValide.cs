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
    public partial class FrmVoirRapportValide : Form
    {
        private string matricule;
        public FrmVoirRapportValide(string mat)
        {
            InitializeComponent();
            matricule = mat;
            bsRapports.DataSource = Manager.ChargerRapportVisiteurFinis(mat);
            cbxRapport.DataSource = bsRapports;
            cbxRapport.DisplayMember = "RAP_NUM";
        }
        private void cbxRapport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxRapport.SelectedIndex != -1)
            {
                RAPPORT_VISITE r = (RAPPORT_VISITE)cbxRapport.SelectedItem;
                ucRapportValide1.LeRapportVisite = r;
                ucRapportValide1.Visible = true;
                List<RAPPORT_VISITE> v;
                v = Manager.ChargerRapportVisiteurFinis(matricule);
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
