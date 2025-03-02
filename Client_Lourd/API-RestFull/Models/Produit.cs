﻿namespace API_RestFull.Models
{
    using System;
    using System.Collections.Generic;
    public partial class Produit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Produit()
        {
            this.Detail_Commande = new HashSet<Detail_Commande>();
        }

        public int Id_Produit { get; set; }
        public string Nom_Produit { get; set; }
        public int Quantite_Produit { get; set; }
        public string Prix_Produit { get; set; }
        public byte[] Image_Produit { get; set; }
        public int ID_CATEGORIE { get; set; }

        public virtual Categorie Categorie { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detail_Commande> Detail_Commande { get; set; }
    }
}