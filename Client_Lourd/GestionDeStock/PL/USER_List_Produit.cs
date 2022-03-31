using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Reporting.WinForms;
using Microsoft.Office.Interop.Excel;

namespace GestionDeStock.PL
{
    public partial class USER_List_Produit : UserControl
    {
        private static USER_List_Produit Userclient;
        private DbStockContext db;

        //********************************* CREER UNE INSTANCE POUR LE USERCONTROL ***************************
        public static USER_List_Produit Instance
        {
            get
            {
                if (Userclient == null)
                {
                    Userclient = new USER_List_Produit();
                }
                return Userclient;
            }
        }
        public USER_List_Produit()
        {
            InitializeComponent();
            db = new DbStockContext();
        }
        // Actualiser le datagrid Produit
        public void Actualiserdvg()
        {
            db = new DbStockContext();
            dvgProduit.Rows.Clear();
            // Pour afficher le nom de catégorie via idcategorie
            Categorie Cat = new Categorie();
            foreach(var Lis in db.Produits)
            {
                Cat = db.Categories.SingleOrDefault(s => s.ID_CATEGORIE == Lis.ID_CATEGORIE); // si le idcategorie dans produit = idcategorie dans categorie
                if(Cat != null)
                {
                    dvgProduit.Rows.Add(false, Lis.Id_Produit, Lis.Nom_Produit, Lis.Quantite_Produit, Lis.Prix_Produit, Cat.Nom_Categorie); // Cat.Nom_Categorie pour afficher le nom de la catégorie
                }
            }
            // Coloration des stock vide en rouge
            for(int i =0; i< dvgProduit.Rows.Count; i ++)
            {
                if((int)dvgProduit.Rows[i].Cells[3].Value == 0)
                {
                    dvgProduit.Rows[i].Cells[3].Style.BackColor = Color.Red;
                }
                else
                {
                    dvgProduit.Rows[i].Cells[3].Style.BackColor = Color.LightGreen;
                }
            }
        }

        //*****************************VERIFIE COMBIEN DE LIGNE SONT SELECTIONNES *****************************
        public string SelectVerif()
        {
            int Nombreligneselect = 0;
            for (int i = 0; i < dvgProduit.Rows.Count; i++)
            {
                if ((bool)dvgProduit.Rows[i].Cells[0].Value == true) // Si ligne selectionné
                {
                    Nombreligneselect++;
                }
            }
            if (Nombreligneselect == 0)
            {
                return "Selectionner le produit que vous souhaitez afficher";
            }
            if (Nombreligneselect > 1)
            {
                return "Vous ne pouvez afficher qu'un seul produit à la fois";
            }
            return null;
        }

        private void USER_List_Produit_Load(object sender, EventArgs e)
        {
            Actualiserdvg();
        }

        // ***********************************************************************************
        private void textrechercher_Enter(object sender, EventArgs e)
        {
            if (textrechercher.Text == "Rechercher")
            {
                textrechercher.Text = "";
                textrechercher.ForeColor = Color.Black;
            }
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            PL.FRM_Ajouter_Modifier_Produit frmProduit = new PL.FRM_Ajouter_Modifier_Produit(this);
            frmProduit.ShowDialog();
        }
        
        private void btnmodifier_Click(object sender, EventArgs e)
        {
            Produit PR = new Produit();
            if (SelectVerif()!= null)
            {
                MessageBox.Show(SelectVerif(), "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PL.FRM_Ajouter_Modifier_Produit frmproduit = new PL.FRM_Ajouter_Modifier_Produit(this);
                frmproduit.lblTitre.Text = "Modifier un Produit";
                frmproduit.btnactualiser.Visible = false;
                for (int i = 0; i < dvgProduit.Rows.Count; i++)  // verifie la ligne selectionné
                {
                    if ((bool)dvgProduit.Rows[i].Cells[0].Value == true)
                    {
                        int MYIDSELECT = (int)dvgProduit.Rows[i].Cells[1].Value;
                        PR = db.Produits.SingleOrDefault(s => s.Id_Produit == MYIDSELECT); // vérifie si l'ID produit = ID selectionner du datagridview
                        if (PR != null) // si existe
                        {
                            frmproduit.combocategorie.Text = dvgProduit.Rows[i].Cells[5].Value.ToString();
                            frmproduit.txtnomP.Text = dvgProduit.Rows[i].Cells[2].Value.ToString();
                            frmproduit.txtquantite.Text = dvgProduit.Rows[i].Cells[3].Value.ToString();
                            frmproduit.txtprix.Text = dvgProduit.Rows[i].Cells[4].Value.ToString();
                            frmproduit.IDPRODUIT = (int) dvgProduit.Rows[i].Cells[1].Value;
                            // Affiche l'image du produit pour la modification
                            MemoryStream MS = new MemoryStream(PR.Image_Produit); // convertie l'image produit pour l'afficher dans la picturebox 
                            frmproduit.PicProduit.Image = Image.FromStream(MS);
                         }
                    }
                }
                frmproduit.ShowDialog();
            }
        }

        private void btnafficherphoto_Click(object sender, EventArgs e)
        {
            Produit PR = new Produit();
            if(SelectVerif()!= null)
            {
                MessageBox.Show(SelectVerif(), "Selectionner", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for(int i = 0; i< dvgProduit.Rows.Count; i ++)  // verifie la ligne selectionné
                {
                    if((bool)dvgProduit.Rows[i].Cells[0].Value == true)
                    {
                        int MYIDSELECT = (int) dvgProduit.Rows[i].Cells[1].Value;
                        PR = db.Produits.SingleOrDefault(s => s.Id_Produit == MYIDSELECT); // vérifie si l'ID produit = ID selectionner du datagridview
                        if(PR != null) // si existe
                        {
                            FRM_Photo_Produit frmP = new FRM_Photo_Produit();
                            MemoryStream MS = new MemoryStream(PR.Image_Produit); // convertie l'image produit pour l'afficher dans la picturebox 
                            frmP.ProduitImage.Image = Image.FromStream(MS);
                            frmP.ProduitNom.Text = dvgProduit.Rows[i].Cells[2].Value.ToString();
                            // Afficher le formulaire
                            frmP.ShowDialog();
                        }
                    }
                }
            }
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            if(SelectVerif() == "Selectionner le produit que vous souhaitez afficher") // Verifie si le produit est sélectionné
            {
                MessageBox.Show(SelectVerif(), "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                DialogResult DR = MessageBox.Show("Voulez-vous supprimer les produits sélectionnés ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(DR == DialogResult.Yes)
                {
                      // Verifier combien de ligne selectionner
                     for (int i = 0; i < dvgProduit.Rows.Count; i++)
                    {
                        if((bool)dvgProduit.Rows[i].Cells[0].Value == true)
                        {
                            BL.CLS_Produit clproduit = new BL.CLS_Produit();
                            int idselect = (int)dvgProduit.Rows[i].Cells[1].Value;
                            clproduit.Supprimer_Produit(idselect);
                        }
                    }
                    // Actualiser datagrid
                    Actualiserdvg();
                    MessageBox.Show("Produit supprimé avec succès", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Suppression annulé", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void textrechercher_TextChanged(object sender, EventArgs e)
        {
            db = new DbStockContext();
            var listRecherche = db.Produits.ToList(); // listeRecherche = liste des clients
          // Recherche Produit par nom

            listRecherche = listRecherche.Where(s => s.Nom_Produit.IndexOf(textrechercher.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
            // ignore la casse de majuscule ou minuscule
            // != -1 existe dans la BDD

            // vider le dataGrid
            dvgProduit.Rows.Clear();
            // Ajouter ListeRecherche dans le datagrid
            Categorie cat = new Categorie();         
            foreach (var l in listRecherche)
            {
                cat = db.Categories.SingleOrDefault(s => s.ID_CATEGORIE == l.ID_CATEGORIE); // Pour afficher le nom de catégorie
                dvgProduit.Rows.Add(false,l.Id_Produit,l.Nom_Produit,l.Quantite_Produit,l.Prix_Produit, cat.Nom_Categorie);
            }
        }

        private void btnimprimerSelect_Click(object sender, EventArgs e)
        {
            db = new DbStockContext();
            int idselect = 0;
            string Nomcategorie = null;
            RAP.FRM_RAPPORTE frmrpt = new RAP.FRM_RAPPORTE();
            Produit PR = new Produit();
            if(SelectVerif()!= null)
            {
                MessageBox.Show(SelectVerif(), "Imprimer la fiche produit", MessageBoxButtons.OK, MessageBoxIcon.Error); // Vérifie si le user coche plusieurs lignes
            }
            else
            {
                for(int i = 0; i < dvgProduit.Rows.Count; i++ )
                {
                    if((bool)dvgProduit.Rows[i].Cells[0].Value == true) // si ligne coché
                    {
                        idselect = (int) dvgProduit.Rows[i].Cells[1].Value; // l'ID de la ligne selectionné
                        Nomcategorie = dvgProduit.Rows[i].Cells[5].Value.ToString(); // Nom de la catégorie
                    }
                }
                ///////////////////////////////////////////////////////
                PR = db.Produits.SingleOrDefault(s => s.Id_Produit == idselect);
                if(PR != null) // si produit existe
                {
                    // Donne le rapport Produit
                    frmrpt.RPAfficher.LocalReport.ReportEmbeddedResource = "GestionDeStock.RAP.RPT_Produit.rdlc"; // Path du rapport
                    // Ajouter using microsoft.reporting.winform
                    ReportParameter Pcategorie = new ReportParameter("RPCategorie", Nomcategorie); // Nom de catégorie
                    ReportParameter Pnom = new ReportParameter("RPNom", PR.Nom_Produit); // Nom de produit
                    ReportParameter Pquantite = new ReportParameter("RPQuantite", PR.Quantite_Produit.ToString()); // Quantité produit
                    ReportParameter Pprix = new ReportParameter("RPPrix", PR.Prix_Produit); // Prix du produit
                    // Image de produit
                    string ImageString = Convert.ToBase64String(PR.Image_Produit);
                    ReportParameter Pimage = new ReportParameter("RPImage", ImageString); // Image produit / Convertie en string base64
                    // Sauvegarde les nouveaux paramètres dans le rapport
                    frmrpt.RPAfficher.LocalReport.SetParameters(new ReportParameter[] { Pcategorie, Pnom, Pquantite, Pprix, Pimage });
                    frmrpt.RPAfficher.RefreshReport();
                    frmrpt.ShowDialog(); // Affiche le formulaire de rapport
                }
            }
        }

        private void btnimprimertout_Click(object sender, EventArgs e)
        {
            RAP.FRM_RAPPORTE frrpt = new RAP.FRM_RAPPORTE();
            db = new DbStockContext();
            try
            {
                var ListeProduit = db.Produits.ToList();
                frrpt.RPAfficher.LocalReport.ReportEmbeddedResource = "GestionDeStock.RAP.RPT_LISTE_PRODUITS.rdlc"; // Path du rapport
                // Ajouter data source
                frrpt.RPAfficher.LocalReport.DataSources.Add(new ReportDataSource("databaseproduit", ListeProduit));
                ReportParameter date = new ReportParameter("Date", DateTime.Now.ToString()); // Ajout date du système
                frrpt.RPAfficher.LocalReport.SetParameters(new ReportParameter[] { date });
                frrpt.RPAfficher.RefreshReport();
                frrpt.ShowDialog();
            }
            catch(Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            db = new DbStockContext();
            using (SaveFileDialog SFD = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", ValidateNames = true }) // filtre fichier excel
            {
                if(SFD.ShowDialog()== DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)app.ActiveSheet;
                    app.Visible = false;
                    // Ajouter les lignes de fichier excel
                    ws.Cells[1, 1] = "Id Produit";
                    ws.Cells[1, 2] = "Nom Produit";
                    ws.Cells[1, 3] = "Quantité";
                    ws.Cells[1, 4] = "Prix";
                    // Ajouter Liste de produit de la base de donnée dans un fichier excel
                    var ListeProduit = db.Produits.ToList();
                    int i = 2;
                    foreach(var L in ListeProduit)
                    {
                        ws.Cells[i, 1] = L.Id_Produit;
                        ws.Cells[i, 2] = L.Nom_Produit;
                        ws.Cells[i, 3] = L.Quantite_Produit;
                        ws.Cells[i, 4] = L.Prix_Produit;
                        i++;
                    }
                    // Changer le style de fichier ------------------
                    ws.Range["A1:D1"].Interior.Color = Color.Teal; // Background Color
                    ws.Range["A1:D1"].Font.Color = Color.White; // Font Color
                    ws.Range["A1:D1"].Font.Size = 15; // Font Size
                    // centrer le text
                    ws.Range["A:D"].HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    ws.Range["A1:D1"].ColumnWidth = 16; // change la taille des colonnes
                    //-----------------------------------------------------
                    wb.SaveAs(SFD.FileName); // Sauvegarder dans le fichier excel
                    app.Quit();
                    MessageBox.Show("Sauvegarde réussite", "Excel", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Actualiser le datagridview
            Actualiserdvg();
        }

        private void dvgProduit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
