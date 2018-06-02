using Metier.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier.FluentEntitites
{
    public class StatutFluent : EntityTypeConfiguration<Statut>
    {
        public StatutFluent()
        {
            ToTable("APP_STATUT");
            HasKey(s => s.Id);
            Property(s => s.Id).HasColumnName("STA_ID").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(s => s.Libelle).HasColumnName("STA_LIBELLE").IsRequired().HasMaxLength(128);
        }
    }
}
