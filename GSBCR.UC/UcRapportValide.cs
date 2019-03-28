using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSBCR.modele;

namespace GSBCR.UC
{
    public partial class UcRapportValide : UserControl
    {
        private RAPPORT_VISITE leRapportVisite = null;
        public UcRapportValide()
        {
            InitializeComponent();
        }
        public RAPPORT_VISITE LeRapportVisite
        {
            get { return leRapportVisite; }
            set
            {
                leRapportVisite = value;
                if (leRapportVisite != null)
                {
                    voirrapval_actualiser();
                }
            }
        }
        private void voirrapval_actualiser()
        {
            txtBoxNumRapport.Text = Convert.ToString(leRapportVisite.RAP_NUM);
            txtBoxCodePra.Text = leRapportVisite.RAP_MATRICULE;
            txtBoxDate.Text = Convert.ToString(leRapportVisite.RAP_DATE);
            txtBoxMotif.Text = leRapportVisite.RAP_MOTIF;
            txtBoxAutreMotif.Text = leRapportVisite.RAP_MOTIFAUTRE;
            txtBoxEtatRapport.Text = leRapportVisite.RAP_ETAT;
            txtBoxCodeMed.Text = leRapportVisite.RAP_MED1 + Environment.NewLine + leRapportVisite.RAP_MED2;
        }
    }
}
