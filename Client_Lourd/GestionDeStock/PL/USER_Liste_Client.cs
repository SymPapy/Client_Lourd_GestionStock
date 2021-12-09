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
    public partial class USER_Liste_Client : UserControl
    {
        private static USER_Liste_Client Userclient;
        private DbStockContext db;
        // Créer une instance pour le UserControl
        public static USER_Liste_Client Instance
        {
            get
            {
                if(Userclient == null)
                {
                    Userclient = new USER_Liste_Client();
                }
                return Userclient;
            }
        }
        public USER_Liste_Client()
        {
            InitializeComponent();
            db = new DbStockContext();
        }
        // Ajouter dans le datagridview (IHM)
        public void Actualisedatagrid()
        {
            dvgclient.Rows.Clear(); // Vider le datagrid view
            foreach (var S in db.Clients)
            {
                dvgclient.Rows.Add(false, S.ID_Client, S.Nom_Client, S.Prenom_Client, S.Adresse_Client, S.Telephone_Client, S.Email_Client, S.Ville_CLient, S.Pays_Client); // Ajouter les lignes dans datagrid
            }

        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textrechercher.Text == "Rechercheré")
            {
                textrechercher.Text = "";
                textrechercher.ForeColor = Color.Black;
            }
        }
        private void USER_Liste_Client_Load(object sender, EventArgs e)
        {
            Actualisedatagrid();
        }

        private void btnajouteclient_Click(object sender, EventArgs e)
        {
            // afficher le formulaire d'ajout client
            PL.FRM_Ajoute_Modifier_Client frmclient = new FRM_Ajoute_Modifier_Client(this); // this fait rappel this.usclient = userC;
            frmclient.ShowDialog();
        }

        private void btnmodifierclient_Click(object sender, EventArgs e)
        {
            PL.FRM_Ajoute_Modifier_Client frmclient = new PL.FRM_Ajoute_Modifier_Client(this);
            frmclient.lblTitre.Text = "Modifier un Client";
            frmclient.btnActualiser.Visible = false;
            frmclient.ShowDialog();
        }
    }
}
