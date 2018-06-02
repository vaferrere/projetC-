using Metier.Entities;
using Metier.FluentEntitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VueConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContextFluent context = new ContextFluent();

                Statut statut = new Statut();
                statut.Libelle = "Ma liste";

                Client client = new Client();
                client.Nom = "Vincent";
                client.Prenom = "Mathieu";
                client.Actif = true;

                Commande commande = new Commande();
                commande.DateCommande = DateTime.Now;
                commande.Observation = "vive le c#";
                commande.Status = statut;
                commande.Client = client;

                context.Commandes.Add(commande);
                context.SaveChanges();

                List<Statut> statuts = context.Statuts.ToList();

                foreach (Statut mStatut in statuts)
                {
                    Console.WriteLine(String.Format("\nL'id de ce status est : {0} et son libelle: {1}", mStatut.Id, mStatut.Libelle));
                }

                Console.WriteLine("\nhey\n");
                Console.ReadLine();
            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}
