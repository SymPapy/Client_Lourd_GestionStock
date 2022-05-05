namespace API_RestFull.Models
{
    using System;
    using System.Collections.Generic;

    public partial class Detail_Commande
    {
        public int IdDetail { get; set; }
        public int ID_Commande { get; set; }
        public int ID_Produit { get; set; }
        public string? Nom_Produit { get; set; }
        public int Quantite { get; set; }
        public string? Prix { get; set; }
        public string? Remise { get; set; }
        public string? Total { get; set; }

        public virtual Commande Commande { get; set; }
        public virtual Produit Produit { get; set; }
    }
}