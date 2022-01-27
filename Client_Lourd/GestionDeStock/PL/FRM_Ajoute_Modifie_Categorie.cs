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
    public partial class FRM_Ajoute_Modifie_Categorie : Form
    {
        public FRM_Ajoute_Modifie_Categorie()
        {
            InitializeComponent();
        }

        private void txtNom_Enter(object sender, EventArgs e)
        {
            if(txtNom.Text == "Nom de Categorie")
            {
                txtNom.Text = "";
                txtNom.ForeColor = Color.White;
            }
        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
