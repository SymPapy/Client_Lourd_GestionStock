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
        string testobligatoire()
        {
            if (txtNom.Text == "" || txtNom.Text == "Nom de l'utilisateur")
            {
                return "Entrer votre nom d'utilisateur";
            }
            if (txtmotdepass.Text == "" || txtmotdepass.Text == "Mot de Passe")
            {
                return "Entrer un Mot de Passe";
            }
            // si les conditions sont remplies alors :
            return null;
        }
        private void txtmotdepass_Enter(object sender, EventArgs e)
        {
            // Pour vider le TextBox
            if (txtmotdepass.Text == "Mot de Passe")
            {
                txtmotdepass.Text = "";
                txtmotdepass.UseSystemPasswordChar = false;
                txtmotdepass.PasswordChar = '*';
                txtmotdepass.ForeColor = Color.WhiteSmoke; // Change la couleur de text
            }

        }
        private void txtmotdepass_Leave(object sender, EventArgs e)
        {
            // Pour remettre le TextBox
            if (txtmotdepass.Text == "")
            {
                txtmotdepass.Text = "Mot de Passe";
                txtmotdepass.UseSystemPasswordChar = true; // désactive le passeword caché
                txtmotdepass.ForeColor = Color.Silver;
            }
        }
        private void txtNom_Enter(object sender, EventArgs e)
        {
            //************* VIDE LE TEXTBOX ***************
            if (txtNom.Text == "Nom de l'utilisateur")
            {
                txtNom.Text = "";
                txtNom.ForeColor = Color.WhiteSmoke; // Change la couleur de text
            }
        }
        private void txtNom_Leave(object sender, EventArgs e)
        {
            //************* REMETTRE LE TEXTBOX ***************
            if (txtNom.Text == "")
            {
                txtNom.Text = "Nom de l'utilisateur";
                txtNom.ForeColor = Color.Silver;
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (testobligatoire() == null)
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
            }else
            {
                MessageBox.Show(testobligatoire(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
