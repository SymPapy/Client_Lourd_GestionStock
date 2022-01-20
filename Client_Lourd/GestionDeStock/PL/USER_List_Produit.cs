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
            PL.FRM_Ajouter_Modifier_Produit frmproduit = new PL.FRM_Ajouter_Modifier_Produit(this);
            frmproduit.lblTitre.Text = "Modifier un Produit";
            frmproduit.btnactualiser.Visible = false;
            frmproduit.ShowDialog();
        }
    }
}
