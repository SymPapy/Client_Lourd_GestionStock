using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace API_RestFull.Models
{
    public partial class DbStockContext : DbContext
    {
        public DbStockContext(DbContextOptions<DbStockContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Categorie> Categories { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Commande> Commandes { get; set; }
        public virtual DbSet<Detail_Commande> Detail_Commande { get; set; }
        public virtual DbSet<Produit> Produits { get; set; }
        public virtual DbSet<Utilisateur> Utilisateurs { get; set; }
        
    }
}

    

