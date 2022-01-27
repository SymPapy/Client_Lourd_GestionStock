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
            PL.FRM_Ajoute_Modifie_Categorie frmcat = new PL.FRM_Ajoute_Modifie_Categorie();
            frmcat.ShowDialog();
        }

        private void dvgcategorie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PL.FRM_Ajoute_Modifie_Categorie frmcat = new PL.FRM_Ajoute_Modifie_Categorie();
            if (dvgcategorie.Columns[e.ColumnIndex].Name == "Modifier") // si click sur modifier dans le datagrid
            {
                // Afficher nom de categorie dans le formulaire pour le modifier
                frmcat.lblTitre.Text = "Modifier la Catégorie";
                frmcat.txtNom.Text = dvgcategorie.Rows[e.RowIndex].Cells[2].Value.ToString();
                frmcat.ShowDialog();
            }
        }
    }
}
