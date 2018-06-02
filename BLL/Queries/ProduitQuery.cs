using Metier.Entities;
using Metier.FluentEntitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Queries
{
    class ProduitQuery
    {
        private readonly ContextFluent contexte;

        public ProduitQuery(ContextFluent contexte)
        {
            this.contexte = contexte;
        }

        public IQueryable<Produit> GetAll()
        {
            return contexte.Produits;
        }

        public IQueryable<Produit> GetById(int id)
        {
            return contexte.Produits.Where(c => c.Id == id);
        }
    }
}
