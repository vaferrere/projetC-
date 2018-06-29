using Metier.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier.FluentEntitites
{
    class CommandeFluent : EntityTypeConfiguration<Commande>
    {
        public CommandeFluent()
        {
            ToTable("APP_COMMANDE");
            HasKey(c => c.Id);
            Property(c => c.Id).HasColumnName("CMD_ID").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(c => c.DateCommande).HasColumnName("CMD_DATECOMMANDE").IsRequired();
            Property(c => c.Observation).HasColumnName("CMD_OBSERVATION").IsRequired().HasMaxLength(256);
            HasRequired(c => c.Status).WithMany().HasForeignKey(c => c.StatusId);
            HasRequired(c => c.Client).WithMany().HasForeignKey(c => c.ClientId);
            
        }
    }
}
