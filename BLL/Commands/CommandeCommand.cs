using Metier.Entities;
using Metier.FluentEntitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Commands
{
    class CommandeCommand
    {
        private readonly ContextFluent contexte;

        public CommandeCommand(ContextFluent contexte)
        {
            this.contexte = contexte;
        }

        public int Ajouter(Commande commande)
        {
            contexte.Commandes.Add(commande);
            return contexte.SaveChanges();
        }

        public void Modifier(Commande commande)
        {
            Commande oldCommande = contexte.Commandes.Where(c => c.Id == commande.Id).FirstOrDefault();

            if (oldCommande != null)
            {
                oldCommande.DateCommande = commande.DateCommande;
                oldCommande.Observation = commande.Observation;
                oldCommande.StatusId = commande.StatusId;
                oldCommande.Status = commande.Status;
                oldCommande.ClientId = commande.ClientId;
                oldCommande.Client = oldCommande.Client;
            }

            contexte.SaveChanges();
        }

        public void Supprimer(int id)
        {
            Commande oldCommande = contexte.Commandes.Where(c => c.Id == id).FirstOrDefault();

            if (oldCommande != null)
            {
                contexte.Commandes.Remove(oldCommande);
            }

            contexte.SaveChanges();
        }
    }
}
