using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace GestionDeStock.PL
{
    public partial class USER_Liste_Commande : UserControl
    {
        private static USER_Liste_Commande UserCommande;
        private DbStockContext db;
        // Créer une instance pour le UserControl
        public static USER_Liste_Commande Instance
        {
            get
            {
                if(UserCommande == null)
                {
                    UserCommande = new USER_Liste_Commande();
                }
                return UserCommande;
            }
        }
        public USER_Liste_Commande()
        {
            InitializeComponent();
            db = new DbStockContext();
        }
        // Remplir le datagrid Commande
        public void RemplirData()
        {
            dvgCommande.Rows.Clear();
            Client c = new Client();
            string NomPrenom;

            foreach ( var LC in db.Commandes)
            {
                // Afficher le nom prenom du client
                c = db.Clients.Single(s => s.ID_Client == LC.ID_Client);
                NomPrenom = c.Nom_Client + " " + c.Prenom_Client;
                dvgCommande.Rows.Add(LC.ID_Commande, LC.DATE_Commande, NomPrenom, LC.Total_HT, LC.TVA, LC.Total_TTC);
            }
        }
        private void USER_Liste_Commande_Load_1(object sender, EventArgs e)
        {
            RemplirData();
        }
        private void btnajouter_Click(object sender, EventArgs e)
        {
            PL.FRM_Detail_Commande frmC = new FRM_Detail_Commande(this);
            frmC.ShowDialog();
        }

        private void btnrecherche_Click(object sender, EventArgs e)
        {
            // Recherche commande passé entre deux date
            var listecommande = db.Commandes.ToList();
            if (dvgCommande.Rows.Count != 0)
            {
                listecommande = listecommande.Where(s => s.DATE_Commande.Date >= dateD.Value.Date && s.DATE_Commande <= dateF.Value.Date).ToList();
                // Remplir le datagrid
                dvgCommande.Rows.Clear();
                Client c = new Client();
                string NomPrenom;

                foreach (var lc in listecommande)
                {
                    // Afficher le nom prenom du client
                    c = db.Clients.Single(s => s.ID_Client == lc.ID_Client);
                    NomPrenom = c.Nom_Client + " " + c.Prenom_Client;
                    dvgCommande.Rows.Add(lc.ID_Commande, lc.DATE_Commande, NomPrenom, lc.Total_HT, lc.TVA, lc.Total_TTC);
                }
            }
        }

        private void btnimprimer_Click(object sender, EventArgs e)
        {
            RAP.FRM_RAPPORTE frmrap = new RAP.FRM_RAPPORTE();
            db = new DbStockContext();
            try
            {
                // La commande selectionné
                int Idcommande = (int)dvgCommande.CurrentRow.Cells[0].Value;
                var Commande = db.Commandes.Single(s => s.ID_Commande == Idcommande);
                // Client
                var ClientCommande = db.Clients.Single(s => s.ID_Client == Commande.ID_Client);
                // Détail de commande 
                var listedetail = db.Detail_Commande.Where(s => s.ID_Commande == Idcommande).ToList();
                // Ajout listedetail dans le datasource
                frmrap.RPAfficher.LocalReport.ReportEmbeddedResource = "GestionDeStock.RAP.RPT_COMMANDE.rdlc";
                frmrap.RPAfficher.LocalReport.DataSources.Add(new ReportDataSource("dataCommande", listedetail));

                // Ajouter info du client
                ReportParameter NomPrenom = new ReportParameter("NomPrenomClient", ClientCommande.Nom_Client + " " + ClientCommande.Prenom_Client);
                ReportParameter Adresse = new ReportParameter("AdresseClient", ClientCommande.Adresse_Client);
                ReportParameter Telephone = new ReportParameter("TelephoneClient", ClientCommande.Telephone_Client);
                ReportParameter Mail = new ReportParameter("EmailClient", ClientCommande.Email_Client);

                // Ajouter info Commande
                ReportParameter numeroCommande = new ReportParameter("IDCommande", Idcommande.ToString());
                ReportParameter dateCommande = new ReportParameter("DateCommande", Commande.DATE_Commande.ToString());

                // Ajouter TVA HT TTC
                ReportParameter TotalHT = new ReportParameter("TotalHT", Commande.Total_HT);
                ReportParameter TVA = new ReportParameter("tva", Commande.TVA);
                ReportParameter TotalTTC = new ReportParameter("TotalTTC", Commande.Total_TTC);

                // Enregistrer les valeurs
                frmrap.RPAfficher.LocalReport.SetParameters(new ReportParameter[] { NomPrenom, Adresse, Telephone, Mail, numeroCommande, dateCommande, TotalHT, TVA, TotalTTC });
                frmrap.RPAfficher.RefreshReport();
                frmrap.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // *******************ZONE DE TESTE D'AMELIORATION **************************************************************
        /*
        // TEST VERIF
        public string SelectVerif()
        {
            int Nombreligneselect = 0;
            for (int i = 0; i < dvgCommande.Rows.Count; i++)
            {
                if ((bool)dvgCommande.Rows[i].Cells[6].Value == true) // Si ligne selectionné
                {
                    Nombreligneselect++;
                }
            }
            if (Nombreligneselect == 0)
            {
                return "Selectionner la commande que vous souhaitez supprimer";
            }
            if (Nombreligneselect > 1)
            {
                return "Vous ne pouvez selectionner qu'une commande à la fois";
            }
            return null;
        }

        // TEST ACTUALISATION DVG
        public void Actualisedatagrid()
        {
            db = new DbStockContext();
            dvgCommande.Rows.Clear(); // Vider le datagrid view
            foreach (var S in db.Commandes)
            {
                dvgCommande.Rows.Add(false, S.ID_Commande, S.DATE_Commande, S.Client, S.Total_HT, S.TVA, S.Total_TTC); // Ajouter les lignes dans datagrid
            }

        }

        // TEST SUPPRESION

        private void btnsupprimerclient_Click(object sender, EventArgs e)
        {
            BL.D_Commande cluser = new BL.D_Commande();

            //******************** POUR SUPPRIMER TOUT LES CLIENTS SELECTIONNES *************************
            int select = 0;
            for (int i = 0; i < dvgCommande.Rows.Count; i++)
            {
                if ((bool)dvgCommande.Rows[i].Cells[6].Value == true)
                {
                    select++;
                }
            }
            if (select == 0)
            {
                MessageBox.Show("Aucune commandes sélectionnées", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult R = MessageBox.Show("Voulez-vous supprimer ", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    //************************** POUR SUPPRIMER TOUTE LES LIGNES SELECTIONNES (USER) **************
                    for (int i = 0; i < dvgCommande.Rows.Count; i++)
                    {
                        if ((bool)dvgCommande.Rows[i].Cells[6].Value == true)
                        {
                            cluser.Supprimer_Commande(int.Parse(dvgCommande.Rows[i].Cells[0].Value.ToString()));
                        }
                    }
                    //************************* ACTUALISER LE DATAGRIDVIEW (USER) ***************************
                    Actualisedatagrid();
                    MessageBox.Show("Supprimé avec succès", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Suppression annulé", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        */
    }
}
