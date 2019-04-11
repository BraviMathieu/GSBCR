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
        private List<RAPPORT_VISITE> Nbrapports;
        public FrmVisiteurEquipe(string UserId)
        {
            InitializeComponent();
            this.UserId = UserId;
            VAFFECTATION leProfil = Manager.ChargerAffectationVisiteur(UserId);

            if (leProfil.TRA_ROLE == "Délégué")
            {
                bsVisiteur.DataSource = Manager.ChargerVisiteurByRegion(leProfil.REG_CODE);

            }
            else if (leProfil.TRA_ROLE == "Responsable")
            {
                VISITEUR v = Manager.ChargerVisiteurById(UserId);
                bsVisiteur.DataSource = Manager.ChargerVisiteurBySecteur(UserId,v.SEC_CODE);
            }

            cbxVisiteurs.DataSource = bsVisiteur;
            cbxVisiteurs.DisplayMember = "VIS_NOM";
        }

        private void cbxVisiteurs_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbxVisiteurs.SelectedIndex != -1)
            {
                VAFFECTATION leProfil = Manager.ChargerAffectationVisiteur(UserId);
                VISITEUR v = (VISITEUR)cbxVisiteurs.SelectedItem;
                Nbrapports = Manager.ChargerRapportRegionLusVisiteur(leProfil.REG_CODE, v.VIS_MATRICULE);
                VAFFECTATION jmmaa = Manager.ChargerAffectationVisiteur(v.VIS_MATRICULE); ;

                tbxMatricule.Text = v.VIS_MATRICULE;
                tbxNom.Text = v.VIS_NOM;
                tbxPrenom.Text = v.Vis_PRENOM;
                dtpEmbauche.Value = v.VIS_DATEEMBAUCHE;
                dtpRegion.Value = jmmaa.JJMMAA;
                tbxRapport.Text = Nbrapports.Count.ToString();
            
                if(Nbrapports.Count == 0)
                {
                    btnpas0.Hide();
                }
                else
                {
                    btnpas0.Show();
                }
            }
        }

        private void btnpas0_Click(object sender, EventArgs e)
        {
            FrmConsulterRapportConsulte f = new FrmConsulterRapportConsulte(Nbrapports, UserId);
            f.ShowDialog();
        }
    }
}
