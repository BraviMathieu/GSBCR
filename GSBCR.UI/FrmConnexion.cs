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
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace GSBCR.UI
{
    public partial class FrmConnexion : Form
    {
        public FrmConnexion()
        {
            InitializeComponent();
        }

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            VISITEUR vis = null;
            string id = txtId.Text;
            string mdp = txtMdp.Text;
            vis = Manager.ChargerVisiteur(txtId.Text, txtMdp.Text);
            if (vis != null)
            {
                this.Hide();
                FrmMenuVisiteur obj = new FrmMenuVisiteur(id, mdp);
                obj.Show();
            }
            else
            {
                MessageBox.Show("Le nom d'utilisateur ou le mot de passe est incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
