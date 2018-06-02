using Metier.Entities;
using Metier.FluentEntitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Commands
{
    class StatutCommand
    {
        private readonly ContextFluent contexte;

        public StatutCommand(ContextFluent contexte)
        {
            this.contexte = contexte;
        }

        public int Ajouter(Statut statut)
        {
            contexte.Statuts.Add(statut);
            return contexte.SaveChanges();
        }

        public void Modifier(Statut statut)
        {
            Statut oldStatut = contexte.Statuts.Where(c => c.Id == statut.Id).FirstOrDefault();

            if (oldStatut != null)
            {
                oldStatut.Libelle = statut.Libelle;
            }

            contexte.SaveChanges();
        }

        public void Supprimer(int id)
        {
            Statut oldStatut = contexte.Statuts.Where(c => c.Id == id).FirstOrDefault();

            if (oldStatut != null)
            {
                contexte.Statuts.Remove(oldStatut);
            }

            contexte.SaveChanges();
        }
    }
}
