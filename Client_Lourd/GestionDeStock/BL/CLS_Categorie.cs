using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.BL
{
    class CLS_Categorie
    {
        private DbStockContext db = new DbStockContext();
        private Categorie cat;
        // Fonction ajouter une categorie
        public bool Ajouter_categorie(string NomCat)
        {
            cat = new Categorie();
            cat.Nom_Categorie = NomCat;
            if(db.Categories.SingleOrDefault(s => s.Nom_Categorie == NomCat)== null) // si n'existe pas alors créé
            {
                db.Categories.Add(cat);
                db.SaveChanges();
                return true;
            }
            else // si existe
            {
                return false;
            }
        }
        // Modifier categorie
        public void Modifier_Catergorie(int idcat, string NomCat)
        {
            cat = new Categorie();
            cat = db.Categories.SingleOrDefault(s => s.ID_CATEGORIE == idcat);
            if (cat != null)
            {
                cat.Nom_Categorie = NomCat;
                db.SaveChanges();
            }
        }
        // Supprimer une catégorie
        public void Supprimer_Categorie(int idcat)
        {
            cat = new Categorie();
            cat = db.Categories.SingleOrDefault(s => s.ID_CATEGORIE == idcat);
            if(cat != null)
            {
                db.Categories.Remove(cat);
                db.SaveChanges();
            }
        }
    }
}
