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
    public partial class FrmUnPracticien : Form
    {
        public FrmUnPracticien(short pr)
        {
            InitializeComponent();
            bsPrac.DataSource = Manager.ChargerLePraticien(pr);
            ucPraticien1.LePraticien = (PRATICIEN)bsPrac.DataSource;
        }
    }
}
