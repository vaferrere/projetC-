using Metier.Entities;
using Metier.FluentEntitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL.Queries
{
    class ClientQuery
    {
        private readonly ContextFluent contexte;

        public ClientQuery(ContextFluent contexte)
        {
            this.contexte = contexte;
        }

        public IQueryable<Client> GetAll()
        {
            return contexte.Clients;
        }

        public IQueryable<Client> GetById(int id)
        {
            return contexte.Clients.Where(c => c.Id == id);
        }
    }
}
