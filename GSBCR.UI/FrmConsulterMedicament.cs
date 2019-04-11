using GSBCR.BLL;
using GSBCR.modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSBCR.UI
{
    public partial class FrmConsulterMedicament : Form
    {
        private string UserId;
        public FrmConsulterMedicament(string userId)
        {
            InitializeComponent();
            bsMedicament.DataSource = Manager.ChargerMedicaments();
            cbxMedicament.DataSource = bsMedicament;
            cbxMedicament.DisplayMember = "MED_NOMCOMMERCIAL";
            btn_voirRapport.Hide();
        }

        private void cbxMedicament_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMedicament.SelectedIndex != -1)
            {
                MEDICAMENT m = (MEDICAMENT)cbxMedicament.SelectedItem;
                ucMedicament1.LeMedicament = m;
                ucMedicament1.Visible = true;
                string idMedicament = m.MED_DEPOTLEGAL;
                List<RAPPORT_VISITE> a;
                a = Manager.ChargerSiRapportsExistentMedicaments(UserId , idMedicament);
                if (a.Count != 0)
                {
                    btn_voirRapport.Show();
                }
                else
                {
                    btn_voirRapport.Hide();
                }
            }
            
        }

        private void FrmConsulterMedicament_Load(object sender, EventArgs e)
        {
            ucMedicament1.Visible = false;
            cbxMedicament.SelectedIndex = -1;
        }

        private void btn_voirRapport_Click(object sender, EventArgs e)
        {
            String unDepot = ucMedicament1.LeMedicament.MED_DEPOTLEGAL;
            FrmDetailRapport f = new FrmDetailRapport(UserId,unDepot);
            f.ShowDialog();
        }
    }
}
