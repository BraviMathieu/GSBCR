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
    public partial class FrmModifRapport : Form
    {
        public FrmModifRapport()
        {
            InitializeComponent();
            bsRapports.DataSource = Manager.ChargerRapportVisiteursEncours(1);
            cbxRapport.DataSource = bsRapports;
            cbxRapport.DisplayMember = "RAP_NUM";
        }
        private void cbxRapport_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
