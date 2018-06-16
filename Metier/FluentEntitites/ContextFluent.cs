using Metier.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier.FluentEntitites
{
    public class ContextFluent : DbContext
    {
        public ContextFluent() : base("dbOmazone")
        {
            //Database.SetInitializer<ContextFluent>(new DropCreateDatabaseIfModelChanges<ContextFluent>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("dbo")
                .Configurations.Add(new StatutFluent())
                .Add(new ClientFluent())
                .Add(new CommandeFluent())
                .Add(new CategorieFluent())
                .Add(new ProduitFluent());
        }

        public DbSet<Statut> Statuts { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Commande> Commandes { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Produit> Produits { get; set; }
    }
}
