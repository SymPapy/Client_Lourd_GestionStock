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

        //********************************* CREER UNE INSTANCE POUR LE USERCONTROL ***************************
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
        //********************************* AJOUTER DANS LE DATAGRIDVIEW (IHM) ********************************
        public void Actualisedatagrid()
        {
            db = new DbStockContext();
            dvgclient.Rows.Clear(); // Vider le datagrid view
            foreach (var S in db.Clients)
            {
                dvgclient.Rows.Add(false, S.ID_Client, S.Nom_Client, S.Prenom_Client, S.Adresse_Client, S.Telephone_Client, S.Email_Client, S.Ville_CLient, S.Pays_Client); // Ajouter les lignes dans datagrid
            }

        }
        //*****************************VERIFIE COMBIEN DE LIGNE SONT SELECTIONNES *****************************
        public string SelectVerif()
        {
            int Nombreligneselect = 0;
            for (int i = 0; i < dvgclient.Rows.Count; i ++)
            {
                if ((bool)dvgclient.Rows[i].Cells[0].Value == true) // Si ligne selectionné
                {
                    Nombreligneselect++;
                }
            }
            if (Nombreligneselect == 0)
            {
                return "Selectionner le client que vous souhaitez modifier";
            }
            if (Nombreligneselect > 1)
            {
                return "Vous ne pouvez modifier qu'un seul client à la fois";
            }
            return null;
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textrechercher.Text == "Rechercher")
            {
                textrechercher.Text = "";
                textrechercher.ForeColor = Color.Black;
            }
        }
        private void USER_Liste_Client_Load(object sender, EventArgs e)
        {
            Actualisedatagrid();
        }
        //*******************************************************
        //**
        //************* EVENEMENT CLICK AJOUTER CLIENT
        //**
        //*******************************************************
        private void btnajouteclient_Click(object sender, EventArgs e)
        {
            //**************************** AFFICHER LE FORMULAIRE D'AJOUT CLIENT ************************************
            PL.FRM_Ajoute_Modifier_Client frmclient = new FRM_Ajoute_Modifier_Client(this);
            // this fait rappel this.usclient = userC;
            frmclient.ShowDialog();
        }

        //*******************************************************
        //**
        //************* EVENEMENT CLICK MODIFIER CLIENT
        //**
        //*******************************************************
        private void btnmodifierclient_Click(object sender, EventArgs e)
        {
            PL.FRM_Ajoute_Modifier_Client frmclient = new PL.FRM_Ajoute_Modifier_Client(this);
            if (SelectVerif() == null )
            {
                for (int i = 0; i < dvgclient.Rows.Count; i++)
                {
                    if ((bool) dvgclient.Rows[i].Cells[0].Value == true) // si le checkbox est vrai alors affiche les infos du client
                    {
                        frmclient.IdSELECT = (int) dvgclient.Rows[i].Cells[1].Value;
                        frmclient.txtNom.Text = dvgclient.Rows[i].Cells[2].Value.ToString();
                        frmclient.txtPrenom.Text = dvgclient.Rows[i].Cells[3].Value.ToString();
                        frmclient.txtAdresse.Text = dvgclient.Rows[i].Cells[4].Value.ToString();
                        frmclient.txtTel.Text = dvgclient.Rows[i].Cells[5].Value.ToString();
                        frmclient.txtMail.Text = dvgclient.Rows[i].Cells[6].Value.ToString();
                        frmclient.txtVille.Text = dvgclient.Rows[i].Cells[7].Value.ToString();
                        frmclient.txtPays.Text = dvgclient.Rows[i].Cells[8].Value.ToString();
                    }
                }
                frmclient.lblTitre.Text = "Modifier un Client";
                frmclient.btnActualiser.Visible = false;
                frmclient.ShowDialog();
            }else
            {
                MessageBox.Show(SelectVerif(), "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //*******************************************************
        //**
        //************* EVENEMENT CLICK SUPPRIMER CLIENT
        //**
        //*******************************************************
        private void btnsupprimerclient_Click(object sender, EventArgs e)
        {
            BL.CLS_Client clclient = new BL.CLS_Client();

            //******************** POUR SUPPRIMER TOUT LES CLIENTS SELECTIONNES *************************
            int select = 0;
            for (int i = 0; i<dvgclient.Rows.Count; i++)
            {
                if ((bool)dvgclient.Rows[i].Cells[0].Value== true)
                {
                    select++;
                }
            }
            if(select==0)
            {
                MessageBox.Show("Aucun clients sélectionnés", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                DialogResult R = MessageBox.Show("Voulez-vous supprimer ", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if ( R == DialogResult.Yes )
                {
                    //************************** POUR SUPPRIMER TOUTE LES LIGNES SELECTIONNES (CLIENT) **************
                    for (int i = 0; i < dvgclient.Rows.Count; i++)
                    {
                        if ((bool)dvgclient.Rows[i].Cells[0].Value == true)
                        {
                            clclient.supprimer_Client( int.Parse(dvgclient.Rows[i].Cells[1].Value.ToString()) );
                        }
                    }
                    //************************* ACTUALISER LE DATAGRIDVIEW (CLIENT) ***************************
                    Actualisedatagrid();
                    MessageBox.Show("Supprimé avec succès", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }else
                {
                    MessageBox.Show("Suppression annulé", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
