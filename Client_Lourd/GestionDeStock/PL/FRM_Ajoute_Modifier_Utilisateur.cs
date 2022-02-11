using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeStock.PL
{
    public partial class FRM_Ajoute_Modifier_Utilisateur : Form
    {
        private UserControl ususer;
        public FRM_Ajoute_Modifier_Utilisateur(UserControl userU)
        {
            InitializeComponent();
            this.ususer = userU;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (lblTitre.Text == "Créer un Utilisateur")
            {
                BL.CLS_Utilisateurs cluser = new BL.CLS_Utilisateurs();
                if (cluser.Ajouter_Utilisateur(txtNom.Text, txtmotdepass.Text) == true)
                {
                    MessageBox.Show("Utilisateur créé avec succès", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    (ususer as USER_Utilisateurs).Actualisedatagrid();
                }
                else
                {
                    MessageBox.Show("L'utilisateur existe déjà", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            /* else // si lbltitre = Modifier un utilistateur
            {
                BL.CLS_Utilisateurs cluser = new BL.CLS_Utilisateurs();
                DialogResult R = MessageBox.Show("Voulez-vous vraiment modifier cet utilisateur ?", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    cluser.Modifier_Utilisateur(txtNom.Text, txtmotdepass.Text);

                    //**************************** POUR ACTUALISER LE DATAGRID ************************************
                    (ususer as USER_Utilisateurs).Actualisedatagrid();
                    MessageBox.Show("Utilisateur modifié avec succès", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Modification annulée", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }*/
        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
