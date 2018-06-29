using Metier.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier.FluentEntitites
{
    class ProduitFluent : EntityTypeConfiguration<Produit>
    {
        public ProduitFluent()
        {
            ToTable("APP_PRODUIT");
            HasKey(s => s.Id);
            Property(s => s.Id).HasColumnName("PRD_ID").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(s => s.Code).HasColumnName("PRD_CODE").IsRequired();
            Property(s => s.Libelle).HasColumnName("PRD_LIBELLE").IsRequired().HasMaxLength(256);
            Property(s => s.Description).HasColumnName("PRD_DESCRIPTION").IsRequired().HasMaxLength(256);
            Property(s => s.Actif).HasColumnName("PRD_ACTIF").IsRequired();
            Property(s => s.Stock).HasColumnName("PRD_STOCK").IsRequired();
            Property(s => s.Prix).HasColumnName("PRD_PRIX").IsRequired();
            HasRequired(c => c.Categorie).WithMany().HasForeignKey(c => c.CategorieId);
        }
    }
}
