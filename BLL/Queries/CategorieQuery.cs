using Metier.Entities;
using Metier.FluentEntitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Queries
{
    class CategorieQuery
    {
        private readonly ContextFluent contexte;

        public CategorieQuery(ContextFluent contexte)
        {
            this.contexte = contexte;
        }

        public IQueryable<Categorie> GetAll()
        {
            return contexte.Categories;
        }

        public IQueryable<Categorie> GetById(int id)
        {
            return contexte.Categories.Where(c => c.Id == id);
        }
    }
}
