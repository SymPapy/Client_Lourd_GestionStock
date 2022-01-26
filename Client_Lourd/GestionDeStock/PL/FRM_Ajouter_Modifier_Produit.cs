using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GestionDeStock.PL
{
    public partial class FRM_Ajouter_Modifier_Produit : Form
    {
        private DbStockContext db;
        private UserControl userProduit;
        public FRM_Ajouter_Modifier_Produit(UserControl User)
        {
            InitializeComponent();
            db = new DbStockContext();
            this.userProduit = User;
            // Affiche les catégories dispo en BDD dans le comboBOX
            combocategorie.DataSource = db.Categories.ToList();
            combocategorie.DisplayMember = "Nom_Categorie";
            combocategorie.ValueMember = "ID_CATEGORIE";
        }
        string testobligatoire()
        {
            if(txtnomP.Text == "Nom du Produit" || txtnomP.Text == "")
            {
                return "Entrer le nom du produit";
            }
            if (txtquantite.Text == "Quantité" || txtquantite.Text == "")
            {
                return "Entrer la quantité";
            }
            if (txtprix.Text == "Prix" || txtprix.Text == "")
            {
                return "Entrer le prix";
            }
            if(PicProduit.Image == null)
            {
                return "Ajouter une image au produit";
            }
            if(combocategorie.Text == "")
            {
                return "Ajouter une catégorie au produit";
            }
            return null;
        }

        private void txtNomP_Enter(object sender, EventArgs e)
        {
            if(txtnomP.Text == "Nom du Produit")
            {
                txtnomP.Text = "";
                txtnomP.ForeColor = Color.White;
            }
        }

        private void txtNomP_Leave(object sender, EventArgs e)
        {
            if (txtnomP.Text == "")
            {
                txtnomP.Text = "Nom du Produit";
                txtnomP.ForeColor = Color.Silver;
            }
        }

        private void txtQuantite_Enter(object sender, EventArgs e)
        {
            if (txtquantite.Text == "Quantité")
            {
                txtquantite.Text = "";
                txtquantite.ForeColor = Color.White;
            }
        }

        private void txtQuantite_Leave(object sender, EventArgs e)
        {
            if (txtquantite.Text == "")
            {
                txtquantite.Text = "Quantité";
                txtquantite.ForeColor = Color.Silver;
            }
        }

        private void txtPrix_Enter(object sender, EventArgs e)
        {
            if (txtprix.Text == "Prix")
            {
                txtprix.Text = "";
                txtprix.ForeColor = Color.White;
            }
        }

        private void txtPrix_Leave(object sender, EventArgs e)
        {
            if (txtprix.Text == "")
            {
                txtprix.Text = "Prix";
                txtprix.ForeColor = Color.Silver;
            }
        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnparcourir_Click(object sender, EventArgs e)
        {
            // Afficher l'explorateur de fichier [ Image ]
            OpenFileDialog OP = new OpenFileDialog();
            OP.Filter = "|*.JPG;*.PNG;*.GIF;*.BMP;*.JPEG"; // Permet d'afficher seulement les extensions suivante
            if(OP.ShowDialog()==DialogResult.OK)
            {
                PicProduit.Image = Image.FromFile(OP.FileName);
            }
        }

        private void btnactualiser_Click(object sender, EventArgs e)
        {
            // Vider le formulaire
            txtnomP.Text = "Nom du Produit"; txtnomP.ForeColor = Color.Silver;
            txtquantite.Text = "Quantité"; txtquantite.ForeColor = Color.Silver;
            txtprix.Text = "Prix"; txtprix.ForeColor = Color.Silver;
            combocategorie.Text = "";
            PicProduit.Image = null;
        }

        private void txtquantite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57) // Code ASCI des numéros
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        private void txtprix_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57) // Code ASCI des numéros
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
        public int IDPRODUIT;
        private void btnenregistrer_Click(object sender, EventArgs e)
        {
            if(testobligatoire() != null)
            {
                MessageBox.Show(testobligatoire(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                if(lblTitre.Text == "Ajouter un Produit")
                {
                    BL.CLS_Produit clsproduit = new BL.CLS_Produit();
                    // Convertir l'image en format Byte - Ajouter using system.IO
                    MemoryStream MR = new MemoryStream();
                    PicProduit.Image.Save(MR, PicProduit.Image.RawFormat);
                    byte[] byteimageP = MR.ToArray(); // converti l'image en format byte[]
                    if (clsproduit.Ajouter_Produit(txtnomP.Text, int.Parse(txtquantite.Text), txtprix.Text, byteimageP, Convert.ToInt32(combocategorie.SelectedValue))== true)
                    {
                        MessageBox.Show("Produit ajouté avec succès", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (userProduit as USER_List_Produit).Actualiserdvg();
                        Close();
                    }else
                    {
                        MessageBox.Show("Produit déjà existant", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else // Modification du Produit
                {
                    MemoryStream MR = new MemoryStream();
                    PicProduit.Image.Save(MR, PicProduit.Image.RawFormat);
                    byte[] byteimageP = MR.ToArray(); // converti l'image en format byte[]
                    BL.CLS_Produit clsproduit = new BL.CLS_Produit();
                    DialogResult RS = MessageBox.Show("Voulez-vous modifier ce produit ?", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(RS == DialogResult.Yes)
                    {
                        clsproduit.Modifier_Produit(IDPRODUIT, txtnomP.Text, int.Parse(txtquantite.Text),txtprix.Text, byteimageP, Convert.ToInt32(combocategorie.SelectedValue));
                        MessageBox.Show("Produit modifié avec succès", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        // actualiser le datagrid
                        (userProduit as USER_List_Produit).Actualiserdvg();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Modification du produit annulé", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
