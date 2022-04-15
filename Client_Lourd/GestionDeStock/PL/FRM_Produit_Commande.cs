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
    public partial class FRM_Produit_Commande : Form
    {
        public Form frmdetail;
        public FRM_Produit_Commande(Form frm)
        {
            InitializeComponent();
            frmdetail = frm;
        }

        private void txtquantite_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Text numerique
            if (!char.IsDigit(e.KeyChar) && e.KeyChar !=8)
            {
                e.Handled = true;
            }
        }

        private void textremise_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtquantite_TextChanged(object sender, EventArgs e)
        {
            if(txtquantite.Text != "") // Pas vide 
            {
                int quantite = int.Parse(txtquantite.Text);
                int prix = int.Parse(lblprix.Text);
                if(int.Parse(txtquantite.Text) > int.Parse(lblstock.Text))
                {
                    MessageBox.Show("Attention il y a " + int.Parse(lblstock.Text) + " en stock", "Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    // vider textbox quantité
                    txtquantite.Text = "";
                    texttotal.Text = lblprix.Text;
                }
                else
                {
                    // Calcule total
                    texttotal.Text = (quantite * prix).ToString();
                }
            }
            else
            {
                texttotal.Text = lblprix.Text;
            }
        }

        private void textremise_TextChanged(object sender, EventArgs e)
        {
            if(textremise.Text != "")
            {
                int quantite;
                if (txtquantite.Text != "")
                {
                    quantite = int.Parse(txtquantite.Text);
                }
                else
                {
                    quantite = 1;
                }
                int prix = int.Parse(lblprix.Text);
                int total = quantite * prix;
                int remise = int.Parse(textremise.Text);
                texttotal.Text = (total - (total * remise / 100)).ToString();
            }
            else
            {
                int quantite;
                if (txtquantite.Text != "")
                {
                    quantite = int.Parse(txtquantite.Text);
                }
                else
                {
                    quantite = 1;
                }
                int prix = int.Parse(lblprix.Text);
                texttotal.Text = (quantite * prix).ToString();
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            // Si txtbox quantité et txtbox remise vide
            int Quant, Re;
            if(txtquantite.Text != "")
            {
                Quant = int.Parse(txtquantite.Text);
            }
            else
            {
                Quant = 1;
            }
            if(textremise.Text != "")
            {
                Re = int.Parse(textremise.Text);
            }
            else
            {
                Re = 0;
            }
            // Ajouter Produit dans Commande
            BL.D_Commande DETAIL = new BL.D_Commande
            {
                Id = int.Parse(lblid.Text),
                Nom = lblnom.Text,
                Quantite = Quant,
                Prix = lblprix.Text,
                Remise = Re.ToString(),
                Total = texttotal.Text,
            };
            
            
            // Ajouter dans liste
            if(grpproduit.Text == "Produit en vente")
            {
                if (BL.D_Commande.listeDetail.SingleOrDefault(s=> s.Id == DETAIL.Id)!= null)
                {
                    MessageBox.Show("Le produit existe déjà dans la commande actuelle", "Produit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    BL.D_Commande.listeDetail.Add(DETAIL);
                }
            }
            else
            {
                // Modifier la liste
                DialogResult PR = MessageBox.Show("Voulez-vous modifier ce produit ?", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(PR == DialogResult.Yes)
                {
                    // Trouver index du produit modifier
                    int index = BL.D_Commande.listeDetail.FindIndex(s => s.Id == int.Parse(lblid.Text));
                    BL.D_Commande.listeDetail[index] = DETAIL;
                    MessageBox.Show("Produit modifié avec succès", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Close();
                }
                else
                {
                    MessageBox.Show("Modification du produit annulé", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            // Actualiser datagrid
            (frmdetail as FRM_Detail_Commande).Actualise_DetailCommande();

        }
    }
}
