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
        public FrmVoirRapportValide(string mat)
        {
            InitializeComponent();
            bsRapports.DataSource = Manager.ChargerRapportVisiteurFinis(mat);
            cbxRapport.DataSource = bsRapports;
            cbxRapport.DisplayMember = "RAP_NUM";
        }
    }
}
