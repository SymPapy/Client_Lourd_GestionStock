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
    public partial class USER_Liste_Categorie : UserControl
    {
        private static USER_Liste_Categorie usercategorie;
        private DbStockContext db;
        // Créer une instance pour le usercontrole
        public static USER_Liste_Categorie Instance
        {
            get
            {
                if(usercategorie == null)
                {
                    usercategorie = new USER_Liste_Categorie();
                }
                return usercategorie;
            }
        }
        public USER_Liste_Categorie()
        {
            InitializeComponent();
            db = new DbStockContext();
        }
        public void remplirdatagrid() // Remplir le datagrid
        {
            db = new DbStockContext();
            dvgcategorie.Rows.Clear();
            foreach(var Cat in db.Categories)
            {
                dvgcategorie.Rows.Add(false, Cat.ID_CATEGORIE, Cat.Nom_Categorie);
            }
        }
        private void txtrecherche_Enter(object sender, EventArgs e)
        {
            if(txtrecherche.Text == "Rechercher")
            {
                txtrecherche.Text = "";
                txtrecherche.ForeColor = Color.Black;
            }
        }
        private void USER_Liste_Categorie_Load(object sender, EventArgs e)
        {
            remplirdatagrid();
        }

        private void btnajouterclient_Click(object sender, EventArgs e)
        {
            PL.FRM_Ajoute_Modifie_Categorie frmcat = new PL.FRM_Ajoute_Modifie_Categorie(this);
            frmcat.ShowDialog();
        }

        private void dvgcategorie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PL.FRM_Ajoute_Modifie_Categorie frmcat = new PL.FRM_Ajoute_Modifie_Categorie(this);
            if (dvgcategorie.Columns[e.ColumnIndex].Name == "Modifier") // si click sur modifier dans le datagrid
            {
                // id de categorie
                frmcat.idcategorie = (int)dvgcategorie.Rows[e.RowIndex].Cells[1].Value;
                // Afficher nom de categorie dans le formulaire pour le modifier
                frmcat.lblTitre.Text = "Modifier la Catégorie";
                frmcat.txtNom.Text = dvgcategorie.Rows[e.RowIndex].Cells[2].Value.ToString();
                frmcat.ShowDialog();
            }
            // Supprimer une catégorie
            if(dvgcategorie.Columns[e.ColumnIndex].Name == "Supprimer") // si click sur supprimer dans le datagrid
            {
                BL.CLS_Categorie clscat = new BL.CLS_Categorie();
                DialogResult PR = MessageBox.Show("Voulez-vous supprimer cette catégorie ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(PR == DialogResult.Yes)
                {
                    // On verifie si il y'a des produits dans cette catégorie
                    int idcat = (int)dvgcategorie.Rows[e.RowIndex].Cells[1].Value;
                    int P = db.Produits.Count(s => s.ID_CATEGORIE == idcat); // Donne le nombre de produit
                    if(P == 0) // si aucun produit Alors
                    {
                        clscat.Supprimer_Categorie(idcat);
                        // Actualiser datagridview
                        remplirdatagrid();
                        MessageBox.Show("Catégorie supprimé avec succès","Suppression",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else // Sinon
                    {
                        DialogResult PDP = MessageBox.Show("Il y a " + P + " Produit(s) dans cette catégorie, voulez-vous les supprimer ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if(PDP == DialogResult.Yes)
                        {
                            clscat.Supprimer_Categorie(idcat);
                            // Actualiser datagridview
                            remplirdatagrid();
                            MessageBox.Show("Catégorie supprimé avec succès", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            MessageBox.Show("Suppression de la catégorie annulé", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Suppression de la catégorie annulé", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtrecherche_TextChanged(object sender, EventArgs e)
        {
            var maListe = db.Categories.ToList();
            maListe = maListe.Where(s => s.Nom_Categorie.IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
            dvgcategorie.Rows.Clear();
            foreach( var l in maListe)
            {
                dvgcategorie.Rows.Add(false, l.ID_CATEGORIE, l.Nom_Categorie);
            }
        }
    }
}
