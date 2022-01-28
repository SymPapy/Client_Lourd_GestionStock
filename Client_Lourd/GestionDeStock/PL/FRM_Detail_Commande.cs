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
    public partial class FRM_Detail_Commande : Form

    {
        private DbStockContext db;
        public FRM_Detail_Commande()
        {
            InitializeComponent();
            db = new DbStockContext();
        }
        // Function Remplir datagrid de produit
        public void RemplirdvgProduit()
        {
            db = new DbStockContext();
            foreach(var l in db.Produits)
            {
                dvgProduit.Rows.Add(l.Id_Produit, l.Nom_Produit, l.Quantite_Produit, l.Prix_Produit);
            }
        }

        private void txtNom_Enter(object sender, EventArgs e)
        {
            if(txtrecherche.Text == "Recherche")
            {
                txtrecherche.Text = "";
                txtrecherche.ForeColor = Color.White;
            }
        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FRM_Detail_Commande_Load(object sender, EventArgs e)
        {
            RemplirdvgProduit();
        }

        private void txtrecherche_TextChanged(object sender, EventArgs e)
        {
            db = new DbStockContext();
            var listRecherche = db.Produits.ToList();
            listRecherche = listRecherche.Where(s => s.Nom_Produit.IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();

            dvgProduit.Rows.Clear();
            foreach (var l in listRecherche)
            {
                dvgProduit.Rows.Add(l.Id_Produit, l.Nom_Produit, l.Quantite_Produit, l.Prix_Produit);
            }
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            PL.FRM_Client_Commande frmC = new FRM_Client_Commande();
            frmC.ShowDialog();
        }
    }
}
