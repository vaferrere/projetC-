using Metier.Entities;
using Metier.FluentEntitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Queries
{
    class StatutQuery
    {
        private readonly ContextFluent contexte;

        public StatutQuery(ContextFluent contexte)
        {
            this.contexte = contexte;
        }

        public IQueryable<Statut> GetAll()
        {
            return contexte.Statuts;
        }

        public IQueryable<Statut> GetById(int id)
        {
            return contexte.Statuts.Where(c => c.Id == id);
        }
    }
}
