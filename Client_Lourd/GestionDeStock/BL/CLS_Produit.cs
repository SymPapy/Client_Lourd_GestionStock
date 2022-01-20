using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.BL
{
    class CLS_Produit
    {
        private DbStockContext db = new DbStockContext();
        private Produit PR;
        // Ajouter produit
        public bool Ajouter_Produit(string NomP, int quantite, string prix, byte[] imageP, int idcategorie )
        {
            PR = new Produit();
            PR.Nom_Produit = NomP;
            PR.Quantite_Produit = quantite;
            PR.Prix_Produit = prix;
            PR.Image_Produit = imageP;
            PR.ID_CATEGORIE = idcategorie;
            // Verification de l'existance du produit
            if(db.Produits.SingleOrDefault(a => a.Nom_Produit == NomP)== null)
            {
                db.Produits.Add(PR);
                db.SaveChanges();
                return true;
            }else
            {
                return false;
            }
        }
    }
}
