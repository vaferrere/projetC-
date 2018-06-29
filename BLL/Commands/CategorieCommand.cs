using Metier.Entities;
using Metier.FluentEntitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Commands
{
    public class CategorieCommand
    {
        private readonly ContextFluent contexte;

        public CategorieCommand(ContextFluent contexte)
        {
            this.contexte = contexte;
        }

        public int Ajouter(Categorie categorie)
        {
            contexte.Categories.Add(categorie);
            return contexte.SaveChanges();
        }

        public void Modifier(Categorie categorie)
        {
            Categorie oldCategorie = contexte.Categories.Where(c => c.Id == categorie.Id).FirstOrDefault();

            if (oldCategorie != null)
            {
                oldCategorie.Libelle = categorie.Libelle;
                oldCategorie.Actif = categorie.Actif;
            }

            contexte.SaveChanges();
        }

        public void Supprimer(int id)
        {
            Categorie oldCategorie = contexte.Categories.Where(c => c.Id == id).FirstOrDefault();

            if(oldCategorie != null)
            {
                contexte.Categories.Remove(oldCategorie);
            }

            contexte.SaveChanges();
        }

        public void Purge()
        {
            contexte.Database.ExecuteSqlCommand("delete from APP_CATEGORIE");
        }
    }
}
