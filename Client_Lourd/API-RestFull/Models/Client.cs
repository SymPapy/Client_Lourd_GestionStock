﻿namespace API_RestFull.Models
{
    using System;
    using System.Collections.Generic;

    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            this.Commandes = new HashSet<Commande>();
        }

        public int ID_Client { get; set; }
        public string Nom_Client { get; set; }
        public string Prenom_Client { get; set; }
        public string Adresse_Client { get; set; }
        public string Telephone_Client { get; set; }
        public string Pays_Client { get; set; }
        public string Ville_CLient { get; set; }
        public string Email_Client { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Commande> Commandes { get; set; }
    }
}
