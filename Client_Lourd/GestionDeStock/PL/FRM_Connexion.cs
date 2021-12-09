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
    public partial class FRM_Connexion : Form
    {
        private DbStockContext db;
        private Form frmmenu;

        // Classe Connexion
        BL.CLS_Connexion C = new BL.CLS_Connexion();

        public FRM_Connexion( Form Menu )
        {
            InitializeComponent();
            this.frmmenu = Menu;
            // initialiser la BDD
            db = new DbStockContext();
        }
        // Verification des champs obligatoires
        string testobligatoire()
        {
            if(txtNom.Text == "" || txtNom.Text == "Nom d'utilisateur" )
            {
                return "Entrer votre nom d'utilisateur";
            }
            if(txtmotdepass.Text == "" || txtmotdepass.Text == "Mot de Passe")
            {
                return "Entrer un Mot de Passe";
            }
            // si les conditions sont remplies alors :
            return null;
        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            // Quitter le formulaire
            this.Close();
        }


        private void txtNom_Enter(object sender, EventArgs e)
        {
            // Pour vider le TextBox
            if(txtNom.Text == "Nom d'utilisateur")
            {
                txtNom.Text = "";
                txtNom.ForeColor = Color.WhiteSmoke; // Change la couleur de text
            }
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

        private void txtNom_Leave(object sender, EventArgs e)
        {
            // Pour remettre le TextBox
            if( txtNom.Text == "" )
            {
                txtNom.Text = "Nom d'utilisateur";
                txtNom.ForeColor = Color.Silver;
            }
        }

        private void txtmotdepass_Leave(object sender, EventArgs e)
        {
            // Pour remettre le TextBox
            if ( txtmotdepass.Text == "" )
            {
                txtmotdepass.Text = "Mot de Passe";
                txtmotdepass.UseSystemPasswordChar = true; // désactive le passeword caché
                txtmotdepass.ForeColor = Color.Silver;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(testobligatoire() == null )
            {
                if(C.ConnexionValide(db, txtNom.Text, txtmotdepass.Text) == true) // utilisateur existe
                {
                    MessageBox.Show("Connexion réussi","Connexion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    (frmmenu as FRM_Menu).activerform();
                    this.Close(); // quitte le formulaire de connexion
                }
                else // False = n'existe pas
                {
                    MessageBox.Show("Connexion échoué", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else
            {
                MessageBox.Show(testobligatoire(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
