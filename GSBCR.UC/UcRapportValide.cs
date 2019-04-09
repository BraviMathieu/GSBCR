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
            listCodeMed.Items.Clear();
            txtBoxNumRapport.Text = Convert.ToString(leRapportVisite.RAP_NUM);
            txtBoxCodePra.Text = Convert.ToString(leRapportVisite.RAP_PRANUM);
            txtBoxDate.Text = Convert.ToString(leRapportVisite.RAP_DATE);
            txtBoxMotif.Text = leRapportVisite.RAP_MOTIF;
            txtBoxAutreMotif.Text = leRapportVisite.RAP_MOTIFAUTRE;
            txtBoxEtatRapport.Text = leRapportVisite.RAP_ETAT;
            if(leRapportVisite.RAP_MED1 != null)
            {
                listCodeMed.Items.Add(leRapportVisite.RAP_MED1);
            }
            if (leRapportVisite.RAP_MED2 != null)
            {
                listCodeMed.Items.Add(leRapportVisite.RAP_MED2);
            }
        }
    }
}
