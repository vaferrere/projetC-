using Metier.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier.FluentEntitites
{
    class CategorieFluent : EntityTypeConfiguration<Categorie>
    {
        public CategorieFluent()
        {
            ToTable("APP_CATEGORIE");
            HasKey(c => c.Id);
            Property(c => c.Id).HasColumnName("CAT_ID").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(c => c.Libelle).HasColumnName("CAT_LIEBELLE").IsRequired().HasMaxLength(256);
            Property(c => c.Actif).HasColumnName("CAT_ACTIF").IsRequired();

        }
    }
}
