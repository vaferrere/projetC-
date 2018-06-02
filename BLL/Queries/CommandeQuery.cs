using Metier.Entities;
using Metier.FluentEntitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Queries
{
    class CommandeQuery
    {
        private readonly ContextFluent contexte;

        public CommandeQuery(ContextFluent contexte)
        {
            this.contexte = contexte;
        }

        public IQueryable<Commande> GetAll()
        {
            return contexte.Commandes;
        }

        public IQueryable<Commande> GetById(int id)
        {
            return contexte.Commandes.Where(c => c.Id == id);
        }
    }
}
