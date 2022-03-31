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
        /*
        private DbStockContext db = new DbStockContext();
        private Commande PR;
        
        // Supprimer Produit TEST
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
        */
    }
}
