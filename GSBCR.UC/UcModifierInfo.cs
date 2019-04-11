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
    public partial class UcModifierInfo : UserControl
    {
        private VISITEUR leVisiteur = null;
        public UcModifierInfo()
        {
            InitializeComponent();
        }
        public VISITEUR LeVisiteur
        {
            get { return leVisiteur; }
            set
            {
                leVisiteur = value;
                if (leVisiteur != null)
                {
                    modinfo_actualiser();
                }
            }
        }
        private void modinfo_actualiser()
        {
            txtAdr.Text = leVisiteur.VIS_ADRESSE;
            txtCP.Text = leVisiteur.VIS_CP;
            txtVille.Text = leVisiteur.VIS_VILLE;
        }

        private void txtCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                ToolTip erreur = new ToolTip();
                erreur.Show("Charactère invalide. Veuillez entrer uniquement des chiffres", txtCP);
            }
        }

        private void txtVille_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                ToolTip erreur = new ToolTip();
                erreur.Show("Charactère invalide. Veuillez entrer uniquement des lettres", txtVille);
            }
        }
    }
}