using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GSBCR.modele;
using GSBCR.BLL;

namespace GSBCR.UI
{
    public partial class FrmSaisir : Form
    {
        /// <summary>
        /// Consultation/création/modification d'un rapport de visite
        /// </summary>
        /// <param name="r">rapport de visite</param>
        /// <param name="maj">code maj</param>
        /// <returns></returns>
        private RAPPORT_VISITE r;
        //maj = vrai si création/modification
        //maj = faux si consultation
        public FrmSaisir(RAPPORT_VISITE r, bool maj)
        {
            InitializeComponent();
            this.r = r;
            //Initialisation de la liste déroulante praticien
            List<PRATICIEN> lp = Manager.ChargerPraticiens();
            bsPraticien.DataSource = lp;
            cbxNomPraticien.DataSource = bsPraticien;
            cbxNomPraticien.DisplayMember = "PRA_NOM";
            cbxNomPraticien.ValueMember = "PRA_NUM";
            cbxNomPraticien.SelectedIndex = -1;
            
            //Initialisation de la liste déroulante motif de visite
            List<MOTIF_VISITE> lmot = Manager.ChargerMotifVisites();
            bsMotif.DataSource = lmot;
            cbxMotif.DataSource = bsMotif;
            cbxMotif.DisplayMember = "MOT_LIBEL";
            cbxMotif.ValueMember = "MOT_CODE";
            cbxMotif.SelectedIndex = -1;
            //initialisation des listes déroulantes médicaments et échantillons
            List<MEDICAMENT> lmed = Manager.ChargerMedicaments();
            bsMed1.DataSource = lmed;
            cbxMed1.DataSource = bsMed1;
            cbxMed1.DisplayMember = "MED_NOMCOMMERCIAL";
            cbxMed1.ValueMember = "MED_DEPOTLEGAL";
            cbxMed1.SelectedIndex = -1;
            bsMed2.DataSource = lmed;
            cbxMed2.DataSource = bsMed2;
            cbxMed2.DisplayMember = "MED_NOMCOMMERCIAL";
            cbxMed2.ValueMember = "MED_DEPOTLEGAL";
            cbxMed2.SelectedIndex = -1;
            txtMatricule.Text = r.RAP_MATRICULE;
            // Initialisation des contrôles du formulaire avec les valeurs du rapport de visite 
            if (r.RAP_NUM != 0)
            {
                //si le rapport existe déjà, initialisation des contrôles avec les valeurs des propriétés du rapport
                InitRapport();
            }
            dtDateVisite.Focus();
            if (!maj)
            {
                btnValider.Enabled = false;
                btnValider.Visible = false;
                lblTitre.Text = "Consultation d'un rapport";
            }
                       
        }

        private void InitRapport()
        {
            txtNum.Text = r.RAP_NUM.ToString();
            dtDateVisite.Value = r.RAP_DATVISIT;
            txtNumPraticien.Text = r.RAP_PRANUM.ToString();
            txtCodeMotif.Text = r.RAP_MOTIF;
            txtAutre.Text = r.RAP_MOTIFAUTRE;
            nupCoef.Value = Convert.ToDecimal(r.RAP_CONFIANCE);
            txtBilan.Text = r.RAP_BILAN;
            if (r.RAP_ETAT == "1")
            {
                chbDefinitif.Checked = false;
            }
            else
            {
                chbDefinitif.Checked = true;
            }
            //n° praticien non null
            cbxNomPraticien.SelectedValue = r.RAP_PRANUM;
            //motif visite non null
            cbxMotif.SelectedValue = r.RAP_MOTIF;
            //Les médicaments présentés peuvent être null
            if (String.IsNullOrEmpty(r.RAP_MED1))
            {
                //cbxMed1.SelectedIndex = -1;
                txtMed1.Text = String.Empty;
            }
            else
            {
                cbxMed1.SelectedValue = r.RAP_MED1;
                
            }
            if (String.IsNullOrEmpty(r.RAP_MED2))
            {
                //cbxMed2.SelectedIndex = -1;
                txtMed2.Text = String.Empty;
            }
            else
            {
                cbxMed2.SelectedValue = r.RAP_MED2;
                
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            bool ajout;
            if (String.IsNullOrEmpty(txtNum.Text))
            {
                ajout = true;
            }
            else
            {
                ajout = false;
            }
                      
            r.RAP_DATVISIT = dtDateVisite.Value;
            r.RAP_MOTIF = cbxMotif.SelectedValue.ToString();
            r.RAP_MOTIFAUTRE = txtAutre.Text;
            r.RAP_CONFIANCE = nupCoef.Value.ToString();
            r.RAP_PRANUM= Convert.ToInt16(cbxNomPraticien.SelectedValue);
            r.RAP_BILAN = txtBilan.Text;
            r.RAP_MED1 = txtMed1.Text;
            r.RAP_MED2 = txtMed2.Text;
            if (chbDefinitif.Checked)
                r.RAP_ETAT = "2";
            else
                r.RAP_ETAT = "1";
            try
            {
                if (ajout)
                {
                    Manager.CreateRapport(r);
                    txtNum.Text = r.RAP_NUM.ToString();
                }
                else
                {
                    Manager.MajRapport(r);
                }

                MessageBox.Show("Rapport de visite n° " + r.RAP_NUM + " enregistré", "Mise à Jour des données", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Abandon traitement : " + ex.GetBaseException().Message, "Erreur base de données", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                      
            btnValider.Enabled = true;
        }

        private void cbxNomPraticien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxNomPraticien.SelectedIndex != -1)
                txtNumPraticien.Text = cbxNomPraticien.SelectedValue.ToString();
            else
                txtNumPraticien.Text = String.Empty;
        }

        private void cbxMotif_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMotif.SelectedIndex != -1)
                txtCodeMotif.Text = cbxMotif.SelectedValue.ToString();
            else
                txtCodeMotif.Text = String.Empty;
        }

        private void chbDefinitif_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void cbxMed1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMed1.SelectedIndex != -1)
            {
                txtMed1.Text = cbxMed1.SelectedValue.ToString();
                btnVoirMed1.Enabled = true;
            }
            else
            {
                txtMed1.Text = String.Empty;
                btnVoirMed1.Enabled = false;
            }
                
        }

        private void cbxMed2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMed2.SelectedIndex != -1)
            {
                txtMed2.Text = cbxMed2.SelectedValue.ToString();
                btnVoirMed2.Enabled = true;
            }
            else
            {
                txtMed2.Text = String.Empty;
                btnVoirMed2.Enabled = false;
            }
        }

        private void FrmSaisir_Load(object sender, EventArgs e)
        {
            // Initialisation des contrôles du formulaire avec les valeurs du rapport de visite 
            
        }

        private void btnVoirmed1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnVoirMed2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
