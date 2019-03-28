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
        private string UserId;
        public FrmConsulterPraticien(string UserId)
        {
            InitializeComponent();
            bsPraticien.DataSource = Manager.ChargerPraticiens();
            cbxPraticien.DataSource = bsPraticien;
            cbxPraticien.DisplayMember = "PRA_NOM";
            this.UserId = UserId;
        }

        private void cbxPraticien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPraticien.SelectedIndex != -1)
            {
                PRATICIEN p = (PRATICIEN)cbxPraticien.SelectedItem;
                ucPraticien1.LePraticien = p;
                ucPraticien1.Visible = true;
                
                Int16 Idpraticient = Int16.Parse(ucPraticien1.txtNUM.Text.ToString());
                List<RAPPORT_VISITE> a;
                a = Manager.ChargerSiRapportsExistent(UserId, Idpraticient);
                TYPE_PRATICIEN type = Manager.ChargerTypeParticien(ucPraticien1.txtCODE.Text.ToString());
                tbxType.Text = type.TYP_LIBELLE.ToString();
                tbxLieu.Text = type.TYP_LIEU.ToString();
                if (a.Count != 0)
                {
                    btn_voirRapport.Show();
                }
                else
                {
                    btn_voirRapport.Hide();
                }
                if (cbxPraticien.SelectedIndex > 1)
                    panelPraticien.Visible = true;

            }
        }

        private void FrmConsulterPraticien_Load(object sender, EventArgs e)
        {
            ucPraticien1.Visible = false;
            cbxPraticien.SelectedIndex = -1;
        }

        private void btn_voirRapport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test");
        }
    }
}
