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
    public partial class UcPraticien : UserControl
    {
        private PRATICIEN lePraticien = null;
        public UcPraticien()
        {
            InitializeComponent();
        }
        public PRATICIEN LePraticien
        {
            get { return lePraticien; }
            set
            {
                lePraticien = value;
                if (lePraticien != null)
                {
                    ucPraticien_actualiser();
                }

            }
        }
        private void ucPraticien_actualiser()
        {
            txtNUM.Text = Convert.ToString(lePraticien.PRA_NUM);
            txtNOM.Text = lePraticien.PRA_NOM;
            txtPRENOM.Text = lePraticien.PRA_PRENOM;
            txtADRESSE.Text = lePraticien.PRA_ADRESSE;
            txtCP.Text = lePraticien.PRA_CP;
            txtVILLE.Text = lePraticien.PRA_VILLE;
            txtCOEFF.Text =  Convert.ToString(lePraticien.PRA_COEFNOTORIETE);
            txtCODE.Text = lePraticien.TYP_CODE;
        }
    }
}
