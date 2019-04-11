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
        private string medicament;
        public FrmDetailRapport(string UserId, Int16 matricule)
        {
            InitializeComponent();
            this.UserId = UserId;
            this.matricule = matricule;
            bsDetailRapport.DataSource = Manager.ChargerSiRapportsExistent(UserId, matricule);
        }
        public FrmDetailRapport(string UserId, string medicament)
        {
            InitializeComponent();
            this.UserId = UserId;
            this.medicament = medicament;
            bsDetailRapport.DataSource = Manager.ChargerSiRapportsExistentMedicaments(UserId, medicament);
        }
    }
}
