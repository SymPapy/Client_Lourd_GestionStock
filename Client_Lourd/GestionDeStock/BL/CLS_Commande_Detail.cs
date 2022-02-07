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
            clsD.ID_Commande = idcommande;
            clsD.ID_Produit = idproduit;
            clsD.Nom_Produit = nomproduit;
            clsD.Quantite = quantite;
            clsD.Prix = prix;
            clsD.Remise = remise;
            clsD.Total = total;
            db.Detail_Commande.Add(clsD);
            db.SaveChanges();
        }
    }
}
