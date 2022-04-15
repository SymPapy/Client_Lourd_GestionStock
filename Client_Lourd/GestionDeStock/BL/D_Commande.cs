using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.BL
{
    public class D_Commande
    {
        //Sauvegarder les produit commandé dans la liste
        public static List<D_Commande> listeDetail = new List<D_Commande>();
        public int Id { get; set; }
        public string Nom { get; set; }
        public int Quantite { get; set; }
        public string Prix { get; set; }
        public string Remise { get; set; }
        public string Total { get; set; }

        // *********** TEST D'AMELIORATION ****************
        
        private DbStockContext db = new DbStockContext();
        private Commande PR;
        
        // Supprimer Commande
        public void Supprimer_Commande(int id)
        {
            PR = new Commande();
            PR = db.Commandes.SingleOrDefault(s => s.ID_Commande == id);
            if (PR != null)
            {
                db.Commandes.Remove(PR);
                db.SaveChanges();
            }
        }

        // test modification du stock en fonction de la liste de commande

        private Produit CMD;
        // Modifier quantité Produit
        public void Modifier_Produit_CMD(int IDP, int quantite)
        {
            CMD = new Produit();
            CMD = db.Produits.SingleOrDefault(s => s.Id_Produit == IDP);
            if (CMD != null)
            {
                CMD.Quantite_Produit = quantite;
                db.SaveChanges();
            }
        }
    }
}
