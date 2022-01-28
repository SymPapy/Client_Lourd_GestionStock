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
    public partial class FRM_Ajoute_Modifie_Categorie : Form
    {
        private UserControl usercat;
        public FRM_Ajoute_Modifie_Categorie(UserControl usercategorie)
        {
            InitializeComponent();
            this.usercat = usercategorie;
        }

        private void txtNom_Enter(object sender, EventArgs e)
        {
            if(txtNom.Text == "Nom de Categorie")
            {
                txtNom.Text = "";
                txtNom.ForeColor = Color.White;
            }
        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            Close();
        }
        public int idcategorie;
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            BL.CLS_Categorie clcat = new BL.CLS_Categorie();
            if(txtNom.Text == "" || txtNom.Text == "Nom de Categorie")
            {
                MessageBox.Show("Entrer le nom de la catégorie", "Ajouter une categorie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(lblTitre.Text == "Ajouter une Catégorie")
                {
                    if (clcat.Ajouter_categorie(txtNom.Text) == false)
                    {
                        MessageBox.Show("Cette catégorie existe déjà", "Ajouter une categorie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Catégorie ajouté avec succès", "Ajouter une categorie", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (usercat as USER_Liste_Categorie).remplirdatagrid();
                    }
                }
                if(lblTitre.Text == "Modifier la Catégorie")
                {
                    DialogResult DR = MessageBox.Show("Voulez-vous modifier cette catégorie ?", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(DR == DialogResult.Yes)
                    {
                        clcat.Modifier_Catergorie(idcategorie, txtNom.Text);
                        MessageBox.Show("Catégorie modifié avec succès", "Modification",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        // Actualiser le datagrid
                        (usercat as USER_Liste_Categorie).remplirdatagrid();
                    }
                    else
                    {
                        MessageBox.Show("La modification a été annulé", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
