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
        // Remplir datagrid de commande par liste
        public void Actualise_DetailCommande()
        {
            // Calcule total HT TTC TVA
            float Totalht = 0, TVA = 0;
            float Totalttc;
            if(txtTVA.Text != "")
            {
                TVA = float.Parse(txtTVA.Text);
            }

            dvgdetailCommandes.Rows.Clear();
            foreach(var L in BL.D_Commande.listeDetail)
            {
                dvgdetailCommandes.Rows.Add(L.Id, L.Nom, L.Quantite, L.Prix, L.Remise, L.Total);
                Totalht = Totalht + float.Parse(L.Total);
            }
            txttotalht.Text = Totalht.ToString();
            // Calcule total ttc
            Totalttc = (Totalht + (Totalht * TVA / 100));
            // Afficher total ttc dans textbox
            txtttc.Text = Totalttc.ToString();
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

        private void dvgProduit_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FRM_Produit_Commande frmp = new FRM_Produit_Commande(this);
            if((int) dvgProduit.CurrentRow.Cells[2].Value == 0)
            {
                MessageBox.Show("Stock vide", "Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Affichage information du produit
                frmp.lblid.Text = dvgProduit.CurrentRow.Cells[0].Value.ToString();
                frmp.lblnom.Text = dvgProduit.CurrentRow.Cells[1].Value.ToString();
                frmp.lblstock.Text = dvgProduit.CurrentRow.Cells[2].Value.ToString();
                frmp.lblprix.Text = dvgProduit.CurrentRow.Cells[3].Value.ToString();
                frmp.texttotal.Text = dvgProduit.CurrentRow.Cells[3].Value.ToString();
                frmp.ShowDialog();
            }
        }

        private void modifierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRM_Produit_Commande frm = new FRM_Produit_Commande(this);
            Produit PR = new Produit();
            if(dvgdetailCommandes.CurrentRow != null)
            {
                frm.grpproduit.Text = "Modifier Produit";
                // Afficher information du produit
                frm.lblid.Text = dvgdetailCommandes.CurrentRow.Cells[0].Value.ToString();
                frm.lblnom.Text = dvgdetailCommandes.CurrentRow.Cells[1].Value.ToString();
                // Importer stock de produit
                int IDP = int.Parse(dvgdetailCommandes.CurrentRow.Cells[0].Value.ToString());
                PR = db.Produits.Single(s => s.Id_Produit == IDP);
                frm.lblstock.Text = PR.Quantite_Produit.ToString();
                frm.lblprix.Text = dvgdetailCommandes.CurrentRow.Cells[3].Value.ToString();
                frm.txtquantite.Text = dvgdetailCommandes.CurrentRow.Cells[2].Value.ToString();
                frm.textremise.Text = dvgdetailCommandes.CurrentRow.Cells[4].Value.ToString();
                frm.texttotal.Text = dvgdetailCommandes.CurrentRow.Cells[5].Value.ToString();
                frm.ShowDialog();
            }
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dvgdetailCommandes.CurrentRow != null)
            {
                DialogResult PR = MessageBox.Show("Voulez-vous supprimer ce produit ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(PR == DialogResult.Yes)
                {
                    // Supprimer produit en commande
                    int index = BL.D_Commande.listeDetail.FindIndex(s => s.Id == int.Parse(dvgdetailCommandes.CurrentRow.Cells[0].Value.ToString()));
                    BL.D_Commande.listeDetail.RemoveAt(index);
                    // Actualiser le datagrid
                    Actualise_DetailCommande();
                    MessageBox.Show("Produit supprimé avec succès", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Suppression du produit annulé", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void txtTVA_TextChanged_1(object sender, EventArgs e)
        {
            // Calcul TTC
            Actualise_DetailCommande();
        }
    }
}
