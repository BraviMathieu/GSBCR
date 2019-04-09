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
    public partial class FrmVisiteurEquipe : Form
    {
        private string UserId;
        public FrmVisiteurEquipe(string UserId)
        {
            InitializeComponent();
            this.UserId = UserId;

            VAFFECTATION leProfil = Manager.ChargerAffectationVisiteur(UserId);
            
            if(leProfil.TRA_ROLE == "Délégué")
            {
                bsVisiteur.DataSource = Manager.ChargerVisiteurByRegion(leProfil.REG_CODE);
                //VAFFECTATION v = Manager.
            }
            else if (leProfil.TRA_ROLE == "Responsable")
            {
                VISITEUR v = Manager.ChargerVisiteurById(UserId);
                bsVisiteur.DataSource = Manager.ChargerVisiteurBySecteur(v.SEC_CODE);
            }
        }
    }
}
