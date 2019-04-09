using GSBCR.BLL;
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
    public partial class FrmDetailRapport : Form
    {
        private string UserId;
        private Int16 matricule;
        public FrmDetailRapport(string UserId, Int16 matricule)
        {
            InitializeComponent();
            this.UserId = UserId;
            this.matricule = matricule;
            bsDetailRapport.DataSource = Manager.ChargerSiRapportsExistent(UserId, matricule);
        }
    }
}
