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
            // Coloration des stock vide en rouge
            for (int i = 0; i < dvgProduit.Rows.Count; i++)
            {
                if ((int)dvgProduit.Rows[i].Cells[2].Value == 0)
                {
                    dvgProduit.Rows[i].Cells[2].Style.BackColor = Color.Red;
                }
                else
                {
                    dvgProduit.Rows[i].Cells[2].Style.BackColor = Color.LightGreen;
                }
            }
            // Vider ligne selectionner
            dvgProduit.ClearSelection();
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
            // Afficher les informations du client
            txtNom.Text = frmC.dvgclient.CurrentRow.Cells[1].Value.ToString();
            txtprenomC.Text = frmC.dvgclient.CurrentRow.Cells[2].Value.ToString();
            txttelephoneC.Text = frmC.dvgclient.CurrentRow.Cells[4].Value.ToString();
            txtEmailC.Text = frmC.dvgclient.CurrentRow.Cells[5].Value.ToString();
            txtVilleC.Text = frmC.dvgclient.CurrentRow.Cells[6].Value.ToString();
            txtPaysC.Text = frmC.dvgclient.CurrentRow.Cells[7].Value.ToString();
        }
    }
}
