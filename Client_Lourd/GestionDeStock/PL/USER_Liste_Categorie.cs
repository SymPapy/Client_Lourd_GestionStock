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
using Microsoft.Office.Interop.Excel;

namespace GestionDeStock.PL
{
    public partial class USER_Liste_Categorie : UserControl
    {
        private static USER_Liste_Categorie usercategorie;
        private DbStockContext db;
        // Créer une instance pour le usercontrole
        public static USER_Liste_Categorie Instance
        {
            get
            {
                if(usercategorie == null)
                {
                    usercategorie = new USER_Liste_Categorie();
                }
                return usercategorie;
            }
        }
        public USER_Liste_Categorie()
        {
            InitializeComponent();
            db = new DbStockContext();
        }
        public void remplirdatagrid() // Remplir le datagrid
        {
            db = new DbStockContext();
            dvgcategorie.Rows.Clear();
            foreach(var Cat in db.Categories)
            {
                dvgcategorie.Rows.Add(false, Cat.ID_CATEGORIE, Cat.Nom_Categorie);
            }
        }
        //*****************************VERIFIE COMBIEN DE LIGNE SONT SELECTIONNES *****************************
        public string SelectVerif()
        {
            int Nombreligneselect = 0;
            for (int i = 0; i < dvgcategorie.Rows.Count; i++)
            {
                if ((bool)dvgcategorie.Rows[i].Cells[0].Value == true) // Si ligne selectionné
                {
                    Nombreligneselect++;
                }
            }
            if (Nombreligneselect == 0)
            {
                return "Selectionner la catégorie que vous souhaitez afficher";
            }
            if (Nombreligneselect > 1)
            {
                return "Vous ne pouvez afficher qu'une seule catégorie à la fois";
            }
            return null;
        }
        private void txtrecherche_Enter(object sender, EventArgs e)
        {
            if(txtrecherche.Text == "Rechercher")
            {
                txtrecherche.Text = "";
                txtrecherche.ForeColor = Color.Black;
            }
        }
        private void USER_Liste_Categorie_Load(object sender, EventArgs e)
        {
            remplirdatagrid();
        }

        private void btnajouterclient_Click(object sender, EventArgs e)
        {
            PL.FRM_Ajoute_Modifie_Categorie frmcat = new PL.FRM_Ajoute_Modifie_Categorie(this);
            frmcat.ShowDialog();
        }

        private void dvgcategorie_CellContentClick(object sender, DataGridViewCellEventArgs e) // ICI TEST
        {
            PL.FRM_Ajoute_Modifie_Categorie frmcat = new PL.FRM_Ajoute_Modifie_Categorie(this);
            if (dvgcategorie.Columns[e.ColumnIndex].Name == "Modifier") // si click sur modifier dans le datagrid
            {
                // id de categorie
                frmcat.idcategorie = (int)dvgcategorie.Rows[e.RowIndex].Cells[1].Value;
                // Afficher nom de categorie dans le formulaire pour le modifier
                frmcat.lblTitre.Text = "Modifier la Catégorie";
                frmcat.txtNom.Text = dvgcategorie.Rows[e.RowIndex].Cells[2].Value.ToString();
                frmcat.ShowDialog();
            }
            // Supprimer une catégorie
            if(dvgcategorie.Columns[e.ColumnIndex].Name == "Supprimer") // si click sur supprimer dans le datagrid
            {
                BL.CLS_Categorie clscat = new BL.CLS_Categorie();
                DialogResult PR = MessageBox.Show("Voulez-vous supprimer cette catégorie ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(PR == DialogResult.Yes)
                {
                    // On verifie si il y'a des produits dans cette catégorie
                    int idcat = (int)dvgcategorie.Rows[e.RowIndex].Cells[1].Value;
                    int P = db.Produits.Count(s => s.ID_CATEGORIE == idcat); // Donne le nombre de produit
                    if(P == 0) // si aucun produit Alors
                    {
                        clscat.Supprimer_Categorie(idcat);
                        // Actualiser datagridview
                        remplirdatagrid();
                        MessageBox.Show("Catégorie supprimé avec succès","Suppression",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else // Sinon
                    {
                        DialogResult PDP = MessageBox.Show("Il y a " + P + " Produit(s) dans cette catégorie, voulez-vous les supprimer ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if(PDP == DialogResult.Yes)
                        {
                            clscat.Supprimer_Categorie(idcat);
                            // Actualiser datagridview
                            remplirdatagrid();
                            MessageBox.Show("Catégorie supprimé avec succès", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            MessageBox.Show("Suppression de la catégorie annulé", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Suppression de la catégorie annulé", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtrecherche_TextChanged(object sender, EventArgs e)
        {
            var maListe = db.Categories.ToList();
            maListe = maListe.Where(s => s.Nom_Categorie.IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
            dvgcategorie.Rows.Clear();
            foreach( var l in maListe)
            {
                dvgcategorie.Rows.Add(false, l.ID_CATEGORIE, l.Nom_Categorie);
            }
        }

        private void btnimprimertout_Click(object sender, EventArgs e)
        {
            RAP.FRM_RAPPORTE frmR = new RAP.FRM_RAPPORTE();
            db = new DbStockContext();
            try
            {
                // Listes Categories
                var ListeCat = db.Categories.ToList();
                // Nombre de Catégorie
                int NBcategorie = db.Categories.Count();
                // Ajouter DataSource
                frmR.RPAfficher.LocalReport.ReportEmbeddedResource = "GestionDeStock.RAP.RPT_LISTES_CATEGORIE.rdlc";
                frmR.RPAfficher.LocalReport.DataSources.Add(new ReportDataSource("databasecategorie", ListeCat)); // Ajout
                // Date du système
                ReportParameter date = new ReportParameter("Date",DateTime.Now.ToShortDateString());
                // Nombre de categorie
                ReportParameter  NbC = new ReportParameter("NBCategorie", NBcategorie.ToString());
                frmR.RPAfficher.LocalReport.SetParameters(new ReportParameter[] { date, NbC });
                frmR.RPAfficher.RefreshReport();
                frmR.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            db = new DbStockContext();
            string NomCategorie = "";
            int idcategorie = 0;
            if(SelectVerif()!= null)
            {
                MessageBox.Show(SelectVerif(), "Selectionner", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                using (SaveFileDialog sf = new SaveFileDialog() { Filter = "Excel workbook|*xlsx", ValidateNames = true })
                {
                    if( sf.ShowDialog() == DialogResult.OK)
                    {
                        Microsoft.Office.Interop.Excel.Application APP = new Microsoft.Office.Interop.Excel.Application();
                        Workbook wb = APP.Workbooks.Add(XlSheetType.xlWorksheet);
                        Worksheet ws = (Worksheet)APP.ActiveSheet;
                        APP.Visible = false;
                        // Nom de ctageorie et ID Categorie
                        for (int j = 0; j < dvgcategorie.Rows.Count; j++)
                        {
                            if((bool)dvgcategorie.Rows[j].Cells[0].Value == true)
                            {
                                NomCategorie = dvgcategorie.Rows[j].Cells[2].Value.ToString();
                                idcategorie = (int) dvgcategorie.Rows[j].Cells[1].Value;
                            }
                        }
                        // Ecrire le nom de categorie dans le fichier excel
                        ws.Range["A1:D1"].Merge();
                        ws.Range["A1:D1"].Value = NomCategorie;
                        // Ajouter cells de produit
                        ws.Cells[2, 1] = "Id Produit";
                        ws.Cells[2, 2] = "Nom de Produit";
                        ws.Cells[2, 3] = "Quantité";
                        ws.Cells[2, 4] = "Prix";
                        // Liste les produits dans cette catégorie
                        var ListeProduit = db.Produits.Where(s => s.ID_CATEGORIE == idcategorie).ToList();
                        int i = 3;
                        foreach(var LP in ListeProduit)
                        {
                            ws.Cells[i, 1] = LP.Id_Produit ;
                            ws.Cells[i, 2] = LP.Nom_Produit;
                            ws.Cells[i, 3] = LP.Quantite_Produit;
                            ws.Cells[i, 4] = LP.Prix_Produit;
                            i++;
                        }
                        // Style du fichier excel
                        // Produit
                        ws.Range["A2:D2"].Interior.Color = Color.Teal; // Background Color
                        ws.Range["A2:D2"].Font.Color = Color.White; // Font Color
                        ws.Range["A2:D2"].Font.Size = 15;
                        
                        // Catégorie
                        ws.Range["A1:D1"].Interior.Color = Color.DarkGreen; // Background Color
                        ws.Range["A1:D1"].Font.Color = Color.White; // Font Color
                        ws.Range["A1:D1"].Font.Size = 15;

                        ws.Range["A:D"].HorizontalAlignment = XlHAlign.xlHAlignCenter;
                        ws.Range["A2:D2"].ColumnWidth = 16;
                        //-----------------------------------------------------
                        wb.SaveAs(sf.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false); // Sauvegarder dans le fichier excel
                        APP.Quit();
                        MessageBox.Show("Sauvegarde réussite", "Excel", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
        }
    }
}
