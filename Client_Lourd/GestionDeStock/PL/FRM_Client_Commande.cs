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
    public partial class FRM_Client_Commande : Form
    {
        private DbStockContext db;

        public FRM_Client_Commande()
        {
            InitializeComponent();
            db = new DbStockContext();
        }

        private void FRM_Client_Commande_Load(object sender, EventArgs e)
        {
            // Remplir datagrid par liste des clients
            foreach( var LC in db.Clients)
            {
                dvgclient.Rows.Add(LC.ID_Client,LC.Nom_Client, LC.Prenom_Client, LC.Adresse_Client, LC.Telephone_Client, LC.Email_Client, LC.Ville_CLient, LC.Pays_Client);

            }
        }

        private void dvgclient_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Quitter le formulaire
            Close();
        }
    }
}
