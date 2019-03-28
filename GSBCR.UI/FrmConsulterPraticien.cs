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
    public partial class FrmConsulterPraticien : Form
    {
        public FrmConsulterPraticien()
        {
            InitializeComponent();
            bsPraticien.DataSource = Manager.ChargerPraticiens();
            cbxPraticien.DataSource = bsPraticien;
            cbxPraticien.DisplayMember = "PRA_NOM";
        }

        private void cbxPraticien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPraticien.SelectedIndex != -1)
            {
                PRATICIEN p = (PRATICIEN)cbxPraticien.SelectedItem;
                ucPraticien1.LePraticien = p;
                ucPraticien1.Visible = true;
                List<RAPPORT_VISITE> a;
                //a = Manager.ChargerSiRapportsExistent();

            }
        }

        private void FrmConsulterPraticien_Load(object sender, EventArgs e)
        {
            ucPraticien1.Visible = false;
            cbxPraticien.SelectedIndex = -1;
        }
    }
}
