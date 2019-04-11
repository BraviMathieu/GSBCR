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
    public partial class FrmConsulterRapportConsulte : Form
    {
        private List<RAPPORT_VISITE> Nbrapports;
        private string UserId;
        public FrmConsulterRapportConsulte(List<RAPPORT_VISITE> Nbrapports, string UserId)
        {
            InitializeComponent();
            this.Nbrapports = Nbrapports;
            this.UserId = UserId;
            bsRapport.DataSource = Nbrapports;
            cbxRapport.DataSource = bsRapport;
            cbxRapport.DisplayMember = "RAP_NUM";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
