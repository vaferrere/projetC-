using Metier.Entities;
using Metier.FluentEntitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Commands
{
    class ClientCommand
    {
        private readonly ContextFluent contexte;

        public ClientCommand(ContextFluent contexte)
        {
            this.contexte = contexte;
        }

        public int Ajouter(Client client)
        {
            contexte.Clients.Add(client);
            return contexte.SaveChanges();
        }

        public void Modifier(Client client)
        {
            Client oldClient = contexte.Clients.Where(c => c.Id == client.Id).FirstOrDefault();

            if (oldClient != null)
            {
                oldClient.Nom = client.Nom;
                oldClient.Prenom = client.Prenom;
                oldClient.Actif = client.Actif;
            }

            contexte.SaveChanges();
        }

        public void Supprimer(int id)
        {
            Client oldClient = contexte.Clients.Where(c => c.Id == id).FirstOrDefault();

            if (oldClient != null)
            {
                contexte.Clients.Remove(oldClient);
            }

            contexte.SaveChanges();
        }

        public void Purge()
        {
            contexte.Database.ExecuteSqlCommand("delete from APP_CLIENT");
        }
    }
}
