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
    public partial class USER_List_Produit : UserControl
    {
        private static USER_List_Produit Userclient;
        private DbStockContext db;

        //********************************* CREER UNE INSTANCE POUR LE USERCONTROL ***************************
        public static USER_List_Produit Instance
        {
            get
            {
                if (Userclient == null)
                {
                    Userclient = new USER_List_Produit();
                }
                return Userclient;
            }
        }
        public USER_List_Produit()
        {
            InitializeComponent();
            db = new DbStockContext();
        }
        // Actualiser le datagrid Produit
        public void Actualiserdvg()
        {
            db = new DbStockContext();
            dvgProduit.Rows.Clear();
            // Pour afficher le nom de catégorie via idcategorie
            Categorie Cat = new Categorie();
            foreach(var Lis in db.Produits)
            {
                Cat = db.Categories.SingleOrDefault(s => s.ID_CATEGORIE == Lis.ID_CATEGORIE); // si le idcategorie dans produit = idcategorie dans categorie
                if(Cat != null)
                {
                    dvgProduit.Rows.Add(false, Lis.Id_Produit, Lis.Nom_Produit, Lis.Quantite_Produit, Lis.Prix_Produit, Cat.Nom_Categorie); // Cat.Nom_Categorie pour afficher le nom de la catégorie
                }
            }
        }

        //*****************************VERIFIE COMBIEN DE LIGNE SONT SELECTIONNES *****************************
        public string SelectVerif()
        {
            int Nombreligneselect = 0;
            for (int i = 0; i < dvgProduit.Rows.Count; i++)
            {
                if ((bool)dvgProduit.Rows[i].Cells[0].Value == true) // Si ligne selectionné
                {
                    Nombreligneselect++;
                }
            }
            if (Nombreligneselect == 0)
            {
                return "Selectionner le produit que vous souhaitez afficher";
            }
            if (Nombreligneselect > 1)
            {
                return "Vous ne pouvez afficher qu'un seul produit à la fois";
            }
            return null;
        }

        private void USER_List_Produit_Load(object sender, EventArgs e)
        {
            Actualiserdvg();
        }

        // ***********************************************************************************
        private void textrechercher_Enter(object sender, EventArgs e)
        {
            if (textrechercher.Text == "Rechercher")
            {
                textrechercher.Text = "";
                textrechercher.ForeColor = Color.Black;
            }
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            PL.FRM_Ajouter_Modifier_Produit frmProduit = new PL.FRM_Ajouter_Modifier_Produit(this);
            frmProduit.ShowDialog();
        }
        
        private void btnmodifier_Click(object sender, EventArgs e)
        {
            Produit PR = new Produit();
            if (SelectVerif()!= null)
            {
                MessageBox.Show(SelectVerif(), "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PL.FRM_Ajouter_Modifier_Produit frmproduit = new PL.FRM_Ajouter_Modifier_Produit(this);
                frmproduit.lblTitre.Text = "Modifier un Produit";
                frmproduit.btnactualiser.Visible = false;
                for (int i = 0; i < dvgProduit.Rows.Count; i++)  // verifie la ligne selectionné
                {
                    if ((bool)dvgProduit.Rows[i].Cells[0].Value == true)
                    {
                        int MYIDSELECT = (int)dvgProduit.Rows[i].Cells[1].Value;
                        PR = db.Produits.SingleOrDefault(s => s.Id_Produit == MYIDSELECT); // vérifie si l'ID produit = ID selectionner du datagridview
                        if (PR != null) // si existe
                        {
                            frmproduit.combocategorie.Text = dvgProduit.Rows[i].Cells[5].Value.ToString();
                            frmproduit.txtnomP.Text = dvgProduit.Rows[i].Cells[2].Value.ToString();
                            frmproduit.txtquantite.Text = dvgProduit.Rows[i].Cells[3].Value.ToString();
                            frmproduit.txtprix.Text = dvgProduit.Rows[i].Cells[4].Value.ToString();
                            frmproduit.IDPRODUIT = (int) dvgProduit.Rows[i].Cells[1].Value;
                            // Affiche l'image du produit pour la modification
                            MemoryStream MS = new MemoryStream(PR.Image_Produit); // convertie l'image produit pour l'afficher dans la picturebox 
                            frmproduit.PicProduit.Image = Image.FromStream(MS);
                         }
                    }
                }
                frmproduit.ShowDialog();
            }
        }

        private void btnafficherphoto_Click(object sender, EventArgs e)
        {
            Produit PR = new Produit();
            if(SelectVerif()!= null)
            {
                MessageBox.Show(SelectVerif(), "Selectionner", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for(int i = 0; i< dvgProduit.Rows.Count; i ++)  // verifie la ligne selectionné
                {
                    if((bool)dvgProduit.Rows[i].Cells[0].Value == true)
                    {
                        int MYIDSELECT = (int) dvgProduit.Rows[i].Cells[1].Value;
                        PR = db.Produits.SingleOrDefault(s => s.Id_Produit == MYIDSELECT); // vérifie si l'ID produit = ID selectionner du datagridview
                        if(PR != null) // si existe
                        {
                            FRM_Photo_Produit frmP = new FRM_Photo_Produit();
                            MemoryStream MS = new MemoryStream(PR.Image_Produit); // convertie l'image produit pour l'afficher dans la picturebox 
                            frmP.ProduitImage.Image = Image.FromStream(MS);
                            frmP.ProduitNom.Text = dvgProduit.Rows[i].Cells[2].Value.ToString();
                            // Afficher le formulaire
                            frmP.ShowDialog();
                        }
                    }
                }
            }
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            if(SelectVerif() == "Selectionner le produit que vous souhaitez afficher") // Verifie si le produit est sélectionné
            {
                MessageBox.Show(SelectVerif(), "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                DialogResult DR = MessageBox.Show("Voulez-vous supprimer les produits sélectionnés ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(DR == DialogResult.Yes)
                {
                      // Verifier combien de ligne selectionner
                     for (int i = 0; i < dvgProduit.Rows.Count; i++)
                    {
                        if((bool)dvgProduit.Rows[i].Cells[0].Value == true)
                        {
                            BL.CLS_Produit clproduit = new BL.CLS_Produit();
                            int idselect = (int)dvgProduit.Rows[i].Cells[1].Value;
                            clproduit.Supprimer_Produit(idselect);
                        }
                    }
                    // Actualiser datagrid
                    Actualiserdvg();
                    MessageBox.Show("Produit supprimé avec succès", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Suppression annulé", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
