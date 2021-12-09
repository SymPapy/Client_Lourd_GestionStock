using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace GestionDeStock.PL
{
    public partial class FRM_Ajoute_Modifier_Client : Form
    {
        private UserControl usclient;
        public FRM_Ajoute_Modifier_Client(UserControl userC)
        {
            InitializeComponent();
            this.usclient = userC; // actualise l'ajout d'un client dans le datagrid
        }
        // Les comp obligatoires
        string testobligatoire()
        {
            if(txtNom.Text =="" || txtNom.Text== "Nom du Client")
            {
                return "Entrer le Nom du Client";
            }
            if (txtPrenom.Text == "" || txtPrenom.Text == "Prenom du Client")
            {
                return "Entrer le Prenom du Client";
            }
            if (txtAdresse.Text == "" || txtAdresse.Text == "Adresse du Client")
            {
                return "Entrer l'Adresse du Client";
            }
            if (txtTel.Text == "" || txtTel.Text == "Téléphone du Client")
            {
                return "Entrer le Téléphone du Client";
            }
            if (txtPays.Text == "" || txtPays.Text == "Pays du Client")
            {
                return "Entrer le Pays du Client";
            }
            if (txtMail.Text == "" || txtMail.Text == "Email du Client")
            {
                return "Entrer l'Email du Client";
            }
            if (txtVille.Text == "" || txtVille.Text == "Ville du Client")
            {
                return "Entrer la Ville du Client";
            }
            // Vérifier l'email valide
            if(txtMail.Text != "" || txtMail.Text!= "Email du Client")
            {
                try
                {
                    new MailAddress(txtMail.Text); // pour verifier si l'email est valide ou non

                }catch(Exception e)
                {
                    return "Email invalide";
                }
            }
            return null;
        }

        private void txtNom_Enter(object sender, EventArgs e)
        {
            if(txtNom.Text == "Nom du Client")
            {
                txtNom.Text = "";
                txtNom.ForeColor = Color.White;
            }
        }

        private void txtNom_Leave(object sender, EventArgs e)
        {
            if (txtNom.Text == "")
            {
                txtNom.Text = "Nom du Client";
                txtNom.ForeColor = Color.Silver;
            }
        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            Close(); // quitter le formulaire
        }

        private void txtPrenom_Enter(object sender, EventArgs e)
        {
            if (txtPrenom.Text == "Prenom du Client")
            {
                txtPrenom.Text = "";
                txtPrenom.ForeColor = Color.White;
            }
        }

        private void txtPrenom_Leave(object sender, EventArgs e)
        {
            if (txtPrenom.Text == "")
            {
                txtPrenom.Text = "Prenom du Client";
                txtPrenom.ForeColor = Color.Silver;
            }
        }

        private void txtTel_Enter(object sender, EventArgs e)
        {
            if (txtTel.Text == "Téléphone du Client")
            {
                txtTel.Text = "";
                txtTel.ForeColor = Color.White;
            }
        }

        private void txtTel_Leave(object sender, EventArgs e)
        {
            if (txtTel.Text == "")
            {
                txtTel.Text = "Téléphone du Client";
                txtTel.ForeColor = Color.Silver;
            }
        }

        private void txtMail_Enter(object sender, EventArgs e)
        {
            if (txtMail.Text == "Email du Client")
            {
                txtMail.Text = "";
                txtMail.ForeColor = Color.White;
            }
        }

        private void txtMail_Leave(object sender, EventArgs e)
        {
            if (txtMail.Text == "")
            {
                txtMail.Text = "Email du Client";
                txtMail.ForeColor = Color.Silver;
            }
        }

        private void txtVille_Enter(object sender, EventArgs e)
        {
            if (txtVille.Text == "Ville du Client")
            {
                txtVille.Text = "";
                txtVille.ForeColor = Color.White;
            }
        }

        private void txtVille_Leave(object sender, EventArgs e)
        {
            if (txtVille.Text == "")
            {
                txtVille.Text = "Ville du Client";
                txtVille.ForeColor = Color.Silver;
            }
        }

        private void txtAdresse_Enter(object sender, EventArgs e)
        {
            if (txtAdresse.Text == "Adresse du Client")
            {
                txtAdresse.Text = "";
                txtAdresse.ForeColor = Color.White;
            }
        }

        private void txtAdresse_Leave(object sender, EventArgs e)
        {
            if (txtAdresse.Text == "")
            {
                txtAdresse.Text = "Adresse du Client";
                txtAdresse.ForeColor = Color.Silver;
            }
        }

        private void txtPays_Enter(object sender, EventArgs e)
        {
            if(txtPays.Text == "Pays du Client")
            {
                txtPays.Text = "";
                txtPays.ForeColor = Color.White;
            }
        }

        private void txtPays_Leave(object sender, EventArgs e)
        {
            if(txtPays.Text == "")
            {
                txtPays.Text = "Pays du Client";
                txtPays.ForeColor = Color.Silver;
            }
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Zone de texte numérique
            if(e.KeyChar < 48  || e.KeyChar > 57) // Code ASCI des numéros
            {
                e.Handled = true;
            }
            if(e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if(testobligatoire()!=null)
            {
                MessageBox.Show(testobligatoire(),"Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BL.CLS_Client clclient = new BL.CLS_Client();
               if(clclient.Ajouter_Client(txtNom.Text, txtPrenom.Text, txtAdresse.Text, txtTel.Text, txtVille.Text, txtPays.Text, txtMail.Text)== true)
                {
                    MessageBox.Show("Client ajouté avec succès","Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    (usclient as USER_Liste_Client).Actualisedatagrid();
                }
                else
                {
                    MessageBox.Show("Le client existe déjà", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            // Vider les champs de texte
            txtNom.Text = "Nom du Client"; txtNom.ForeColor = Color.Silver;
            txtPrenom.Text = "Prenom du Client"; txtPrenom.ForeColor = Color.Silver;
            txtTel.Text = "Téléphone du Client"; txtTel.ForeColor = Color.Silver;
            txtAdresse.Text = "Adresse du Client"; txtAdresse.ForeColor = Color.Silver;
            txtVille.Text = "Ville du Client"; txtVille.ForeColor = Color.Silver;
            txtMail.Text = "Mail du Client"; txtMail.ForeColor = Color.Silver;
            txtPays.Text = "Pays du Client"; txtPays.ForeColor = Color.Silver;
        }

        private void FRM_Ajoute_Modifier_Client_Load(object sender, EventArgs e)
        {

        }
    }
}
