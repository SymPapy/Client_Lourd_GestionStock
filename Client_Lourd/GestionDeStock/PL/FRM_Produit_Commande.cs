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
        public FRM_Produit_Commande()
        {
            InitializeComponent();
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
    }
}
