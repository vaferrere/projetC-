using Metier.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier.FluentEntitites
{
    class ClientFluent : EntityTypeConfiguration<Client>
    {
        public ClientFluent()
        {
            ToTable("APP_CLIENT");
            HasKey(s => s.Id);
            Property(s => s.Id).HasColumnName("CLI_ID").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(s => s.Nom).HasColumnName("CLI_NOM").IsRequired().HasMaxLength(32);
            Property(s => s.Prenom).HasColumnName("CLI_PRENOM").IsRequired().HasMaxLength(32);
            Property(s => s.Actif).HasColumnName("CLI_ACTIF").IsRequired();
        }
    }
}
