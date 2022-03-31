using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.BL
{
    class CLS_Commande_Detail
    {
        private DbStockContext db = new DbStockContext();
        private Commande clscmd;
        private Detail_Commande clsD;
        public int idcommande;
        //public int commande; // test
        //private Produit clsf; // test
        
        // Sauvegarder la commande
        public void Ajouter_Commande( DateTime datecommande, int Idclient, string totalht, string tva, string totalttc )
        {
            clscmd = new Commande();
            clscmd.DATE_Commande = datecommande;
            clscmd.ID_Client = Idclient;
            clscmd.Total_HT = totalht;
            clscmd.TVA = tva;
            clscmd.Total_TTC = totalttc;
            db.Commandes.Add(clscmd);
            db.SaveChanges();
            idcommande = clscmd.ID_Commande;
        }
        // Sauvegarder le détail de la commande

        public void Ajouter_Detail( int idproduit, string nomproduit ,int quantite, string prix, string remise, string total )
        {
            clsD = new Detail_Commande();
            //clsf = new Produit(); // test
            clsD.ID_Commande = idcommande;
            clsD.ID_Produit = idproduit;
            clsD.Nom_Produit = nomproduit;
            clsD.Quantite = quantite;
            clsD.Prix = prix;
            clsD.Remise = remise;
            clsD.Total = total;
            db.Detail_Commande.Add(clsD);
            //commande = clsD.Quantite - clsf.Quantite_Produit; // test
            //db.Produits.Remove(commande); // test
            // Produit pr = db.Produits.Add(s => s.clsD.Quantite == clsf.Quantite_Produit);// test
            
            db.SaveChanges();
        }
        // TEST DECREMENTATION STOCK
        /*
        public void Deduction_Commande(int quantite)
        {
            clsf = new Detail_Commande();
            clsf.Quantite = quantite;
            db.Detail_Commande.Remove(clsf);
        }*/
        // TEST
        /*
        public void Deduction_Commande(int Quantite)
        {
            PR = new Detail_Commande();
            PR = db.Detail_Commande.SingleOrDefault(s => s.ID_Produit == Quantite);
            if (PR != null)
            {
                PR.ID_Commande = idcommande;
                PR.Quantite = Quantite;
                db.SaveChanges();
            }
        }
        */
    }
}
