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
        public FrmConsulterMedicament()
        {
            InitializeComponent();
            bsMedicament.DataSource = Manager.ChargerMedicaments();
            cbxMedicament.DataSource = bsMedicament;
            cbxMedicament.DisplayMember = "MED_NOMCOMMERCIAL";
        }

        private void cbxMedicament_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMedicament.SelectedIndex != -1)
            {
                MEDICAMENT m = (MEDICAMENT)cbxMedicament.SelectedItem;
                ucMedicament1.LeMedicament = m;
                ucMedicament1.Visible = true;
            }
        }

        private void FrmConsulterMedicament_Load(object sender, EventArgs e)
        {
            ucMedicament1.Visible = false;
            cbxMedicament.SelectedIndex = -1;
        }
    }
}
