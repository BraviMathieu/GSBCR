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
    public partial class FrmChangerMdp : Form
    {
        private string UserId;
        public FrmChangerMdp(string UserId)
        {
            InitializeComponent();
            this.UserId = UserId;
        }

        private void btnAccepter_Click(object sender, EventArgs e)
        {
            string dictionnaire = "abcdefghijklmnopqrstuvwxyz";
            string dictionnaireMaj = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string chiffre = "1234567890";
            if (txt_ancien.Text.Equals("") || txt_nouveau.Text.Equals("") || txt_nouveau2.Text.Equals(""))
            {
                MessageBox.Show("Un champ n'est pas renseigné", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                VISITEUR vis = null;
                vis = Manager.ChargerVisiteur(UserId, txt_ancien.Text);
                if (vis == null)
                {
                    MessageBox.Show("Mot de passe actuel faux", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txt_nouveau.Text != txt_nouveau2.Text)
                    {
                        MessageBox.Show("Les 2 nouveaux mots de passe ne sont pas identiques ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (txt_ancien.Text == txt_nouveau.Text)
                        {
                            MessageBox.Show("Le nouveau mot de passe est identique à l'ancien ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (txt_nouveau.Text.Length < 6)
                            {
                                MessageBox.Show("La longueur du nouveau mot de passe est inférieure à 6 caractères", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string[] dico = dictionnaire.Split();
                                string[] dicoMaj = dictionnaireMaj.Split();
                                string[] dicochiffre = chiffre.Split();

                                for (int i = 0; i < dictionnaire.Length; i++)
                                {
                                    if (txt_nouveau.Text.Contains(dico[i]))
                                    {
                                        for (int j = 0; j < dictionnaireMaj.Length; j++)
                                        {
                                            if (txt_nouveau.Text.Contains(dicoMaj[j]))
                                            {
                                                for (int k = 0; k < dicochiffre.Length; k++)
                                                {
                                                    if (txt_nouveau.Text.Contains(dicochiffre[k]))
                                                    {
                                                        Manager.UpdateVisiteurMdp(UserId, txt_nouveau.Text);
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("erreur");
                                                    }

                                                }

                                            }
                                            else
                                            {
                                                MessageBox.Show("erreur");
                                            }
                                        }

                                    }
                                    else
                                    {
                                        MessageBox.Show("erreur");
                                    }
                                }
                            }

                        }

                    }
                }
            }

        }
    }
}
