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
    public partial class USER_Utilisateurs : UserControl
    {
        private static USER_Utilisateurs User;
        private DbStockContext db;

        public static USER_Utilisateurs Instance
        {
            get
            {
                if (User == null)
                {
                    User = new USER_Utilisateurs();
                }
                return User;
            }
        }
        public USER_Utilisateurs()
        {
            InitializeComponent();
            db = new DbStockContext();
        }

        private void btnajouteclient_Click(object sender, EventArgs e)
        {
            //**************************** AFFICHER LE FORMULAIRE D'AJOUT UTILISATEUR ************************************
            PL.FRM_Ajoute_Modifier_Utilisateur frmuser = new FRM_Ajoute_Modifier_Utilisateur(this);
            // this fait rappel this.usclient = userC;
            frmuser.ShowDialog();
        }

        public void Actualisedatagrid()
        {
            db = new DbStockContext();
            dvguser.Rows.Clear(); // Vider le datagrid view
            foreach (var S in db.Utilisateurs)
            {
                dvguser.Rows.Add(false, S.NomUtilisateur); // Ajouter les lignes dans datagrid
            }
        }
        public string SelectVerif()
        {
            int Nombreligneselect = 0;
            for (int i = 0; i < dvguser.Rows.Count; i++)
            {
                if ((bool)dvguser.Rows[i].Cells[0].Value == true) // Si ligne selectionné
                {
                    Nombreligneselect++;
                }
            }
            if (Nombreligneselect == 0)
            {
                return "Selectionner l'utilisateur que vous souhaitez modifier";
            }
            if (Nombreligneselect > 1)
            {
                return "Vous ne pouvez modifier qu'un seul utilisateur à la fois";
            }
            return null;
        }

        private void USER_Utilisateurs_Load(object sender, EventArgs e)
        {
            Actualisedatagrid();
        }

      /*  private void btnmodifierclient_Click(object sender, EventArgs e)
        {
            PL.FRM_Ajoute_Modifier_Utilisateur frmuser = new PL.FRM_Ajoute_Modifier_Utilisateur(this);
            if (SelectVerif() == null)
            {
                for (int i = 0; i < dvguser.Rows.Count; i++)
                {
                    if ((bool)dvguser.Rows[i].Cells[0].Value == true) // si le checkbox est vrai alors affiche les infos du client
                    {
                        frmuser.txtNom.Text = dvguser.Rows[i].Cells[1].Value.ToString();
                        
                    }
                }
                frmuser.lblTitre.Text = "Modifier un utilisateur";
                frmuser.ShowDialog();
            }
            else
            {
                MessageBox.Show(SelectVerif(), "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } */

        private void btnsupprimerclient_Click(object sender, EventArgs e)
        {
            BL.CLS_Utilisateurs cluser = new BL.CLS_Utilisateurs();

            //******************** POUR SUPPRIMER TOUT LES CLIENTS SELECTIONNES *************************
            int select = 0;
            for (int i = 0; i < dvguser.Rows.Count; i++)
            {
                if ((bool)dvguser.Rows[i].Cells[0].Value == true)
                {
                    select++;
                }
            }
            if (select == 0)
            {
                MessageBox.Show("Aucun utilisateur sélectionnés", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult R = MessageBox.Show("Voulez-vous supprimer ", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    //************************** POUR SUPPRIMER TOUTE LES LIGNES SELECTIONNES (USER) **************
                    for (int i = 0; i < dvguser.Rows.Count; i++)
                    {
                        if ((bool)dvguser.Rows[i].Cells[0].Value == true)
                        {
                            cluser.Supprimer_Utilisateur(dvguser.Rows[i].Cells[1].Value.ToString());
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
    }
}
